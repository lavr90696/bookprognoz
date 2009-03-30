using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace BookPrognoz
{
    public partial class BPMainF : Form
    {
        FbConnection _connection;
        int _punctId;
        DataTable _events;
        Dictionary<int, string> _issues = new Dictionary<int,string>();

        public BPMainF()
        {
            InitializeComponent();
        }

        
        public BPMainF(FbConnection conn) :this()
        {
            _connection = conn;
            _eventsDGV.AutoGenerateColumns = false;
        }

        private void BPMainF_Load(object sender, EventArgs e)
        {
            string punctValue = BPIniWriter.IniReadValue("MAIN", "PUNCT");
            if (String.IsNullOrEmpty(punctValue))
            {
                SelectPunctF punctF = new SelectPunctF();
                punctF.Connection = _connection;
                if (punctF.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }

                _punctId = punctF.SelectedPunctId;
                BPIniWriter.IniWriteValue("MAIN", "PUNCT", _punctId.ToString());
            }
            else
            {
                _punctId = Convert.ToInt32(punctValue);
            }

            FillEssuesList();

            foreach (KeyValuePair<int, string> kvp in _issues)
            {
                DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
                col.DataPropertyName = kvp.Key.ToString();
                col.HeaderText = kvp.Value;
                col.ReadOnly = false;
                col.FillWeight = 10;
                _eventsDGV.Columns.Add(col);
                 }

            FillEventsTable();
            _eventsDGV.DataSource = _events;

        }

        void FillEventsTable()
        {
            _events = new DataTable("events");
            
             FbCommand cmd = new FbCommand("select eventid, number, home, away from get_events_list", 
                _connection);

            FbDataAdapter da = new FbDataAdapter(cmd);

            DataTable _punctsList = new DataTable();
            da.Fill(_events);


            foreach (KeyValuePair<int, string> kvp in _issues)
            {
                DataColumn col = new DataColumn(kvp.Key.ToString(), typeof(bool));
                col.AllowDBNull = false;
                col.DefaultValue = false;
                _events.Columns.Add(col);
            }
        }

        void FillEssuesList()
        {                       
             FbCommand cmd = new FbCommand("select id, title from get_issue_list", 
                _connection);

             using (FbDataReader dr =  cmd.ExecuteReader())
             {
                 while (dr.Read())
                    _issues.Add(Convert.ToInt32(dr["id"]), dr["title"].ToString());
             }
        }

        private void _eventsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (_eventsDGV.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn )
            {
                bool currentValue = Convert.ToBoolean(_eventsDGV[e.ColumnIndex,e.RowIndex].Value);

                foreach (DataGridViewColumn col in _eventsDGV.Columns)
                {
                    if (col.Index != e.ColumnIndex && col is DataGridViewCheckBoxColumn)
                    {
                        _eventsDGV[col.Index, e.RowIndex].Value = currentValue;
                    }
                }
            }
        }


        void AddTicket(string number, int punctId, DataTable issuesTable)
        {
            if (String.IsNullOrEmpty(number))
                throw new BookPrognozException("Номер не может быть пустым");

            FbTransaction trans = _connection.BeginTransaction();

            if (number.Length > 8)
                throw new BookPrognozException("Номер не может состоять более чем из 6 цифр");

            if (number.Length < 6)
            {
                number = "000000" + number;
                number = number.Substring(number.Length - 6);
            }

            try
            {

                FbCommand cmd = new FbCommand("create_ticket", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = trans;

                cmd.Parameters.Add("number", number);
                cmd.Parameters.Add("punct", punctId);
                FbParameter betIdParam = new FbParameter("id", FbDbType.BigInt);
                betIdParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(betIdParam);

                cmd.ExecuteNonQuery();

                long betId = Convert.ToInt64(betIdParam.Value);

                FbCommand addEventCmd = new FbCommand("add_event_to_bet", _connection);
                addEventCmd.Transaction = trans;
                addEventCmd.CommandType = CommandType.StoredProcedure;

                addEventCmd.Parameters.Add("betId", betId);
                addEventCmd.Parameters.Add("eventId", FbDbType.BigInt);
                addEventCmd.Parameters.Add("issueId", FbDbType.Integer);

                foreach (DataRow dr in issuesTable.Rows)
                {
                    addEventCmd.Parameters["eventId"].Value = dr["eventId"];

                    foreach (DataColumn col in issuesTable.Columns)
                    {
                        if (dr[col.ColumnName] is bool &&
                            ((bool)dr[col.ColumnName]) == true)
                        {
                            addEventCmd.Parameters["issueId"].Value = Convert.ToInt32(col.ColumnName);
                            break;
                        }
                    }
                    addEventCmd.ExecuteNonQuery();
                }
            }
            catch (FbException)
            {
                try
                {
                    trans.Rollback();
                }
                catch 
                {}

                throw;
            }

            trans.Commit();
        }

        private void _addTicketB_Click(object sender, EventArgs e)
        {
            try
            {
                AddTicket(_ticketNumberME.Text, _punctId, _events);
            }
            catch (BookPrognozException ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (FbException ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClearTicket();

        }

        private void ClearTicket()
        {
            _ticketNumberME.Text = string.Empty;

            foreach (DataRow dr in _events.Rows)
            {
                foreach (DataColumn col in _events.Columns)
                {
                    if (dr[col.ColumnName] is bool &&
                        ((bool)dr[col.ColumnName]) == true)
                    {
                        dr[col.ColumnName] = false;
                    }
                }
            }
        }


    }
}
