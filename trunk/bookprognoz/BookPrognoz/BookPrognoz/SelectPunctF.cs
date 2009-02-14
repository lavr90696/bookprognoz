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
    public partial class SelectPunctF : Form
    {
        FbConnection _connection;
        int _selectedPunctId;

       

        public int SelectedPunctId
        {
            get { return _selectedPunctId; }
            set { _selectedPunctId = value; }
        }

        public FbConnection Connection
        {
            get { return _connection; }
            set { _connection = value; }
        }
        
        public SelectPunctF()
        {
            InitializeComponent();
        }

        void FillPunctsList()
        {
            FbCommand cmd = new FbCommand("select id, title from get_puncts_list", 
                _connection);

            FbDataAdapter da = new FbDataAdapter(cmd);

            DataTable _punctsList = new DataTable();
            da.Fill(_punctsList);

            _punctCB.DisplayMember = "Title";
            _punctCB.ValueMember = "Id";

            _punctCB.DataSource = _punctsList;
        }

        private void _punctCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedPunctId = Convert.ToInt32(_punctCB.SelectedValue);
        }

        private void SelectPunctF_Load(object sender, EventArgs e)
        {
            FillPunctsList();
        }
    }
}
