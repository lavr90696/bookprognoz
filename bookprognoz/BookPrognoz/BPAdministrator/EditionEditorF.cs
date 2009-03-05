using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace BPAdministrator
{
    public partial class EditionEditorF : Form
    {
        FbConnection _fbConnection;
        DataTable _events;

        public FbConnection FbConnection
        {
            get { return _fbConnection; }
            set { _fbConnection = value; }
        }

        public EditionEditorF()
        {
            InitializeComponent();
            _eventsGrid.AutoGenerateColumns = false;
            CreateEventsTable();
        }

        void CreateEventsTable()
        {
            _events = new DataTable();
            _events.Columns.Add("number");
            _events.Columns.Add("homeTeam");
            _events.Columns.Add("awayTeam");

            for (int i = 0; i < 11; i++)
            {
                _events.Rows.Add(new object[] { i+1, null, null });
            }

            _eventsGrid.DataSource = _events;
        }

        bool SaveEdition()
        {
            if (!CheckData())
                return false;

            FbTransaction trans = _fbConnection.BeginTransaction();
            try
            {                
                FbCommand cmd = new FbCommand(@"create_edition", _fbConnection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = trans;

                cmd.Parameters.Add("number", Convert.ToInt32(_editionNumber.Text));
                cmd.Parameters.Add("startDate", _startDateDTP.Value);
                cmd.Parameters.Add("end_date", _endDateDTP.Value);                

                FbParameter param = new FbParameter("id", FbDbType.Integer);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();

                int editionId = Convert.ToInt32(param.Value);
                foreach (DataRow dr in _events.Rows)
                {
                    cmd = new FbCommand(@"add_event_to_edition", _fbConnection);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = trans;

                    cmd.Parameters.Add("home", dr["homeTeam"].ToString());
                    cmd.Parameters.Add("away", dr["awayTeam"].ToString());
                    cmd.Parameters.Add("number", Convert.ToInt32(dr["number"]));
                    cmd.Parameters.Add("edition", editionId);
                    cmd.ExecuteNonQuery();
                }


            }
            catch (FbException ex)
            {
                MessageBox.Show(ex.Message,
                   this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                trans.Rollback();

                return false;
            }

            trans.Commit();

            return true;
        }

        bool CheckData()
        {
            if (_startDateDTP.Value > _endDateDTP.Value)
            {
                MessageBox.Show("Дата начала тиража не может быть больше даты окончания",
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            int tmp;
            if (string.IsNullOrEmpty(_editionNumber.Text) || !Int32.TryParse(_editionNumber.Text, out tmp))
            {
                MessageBox.Show("Не верный номер тиража",
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            foreach (DataRow dr in _events.Rows)
            {
                if (String.IsNullOrEmpty(dr["homeTeam"].ToString()) ||
                    String.IsNullOrEmpty(dr["awayTeam"].ToString()))
                {
                    MessageBox.Show("Неверные данные в событии номер " + dr["number"].ToString(),
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return false;
                }
            }

            return true;
        }

        private void _saveB_Click(object sender, EventArgs e)
        {
            if (SaveEdition())
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
