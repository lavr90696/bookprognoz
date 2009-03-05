using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace BPAdministrator
{
    public partial class EditionViewer : UserControl
    {
        FbConnection _fbConnection;
        DataTable _editionsTable = new DataTable("Editions");


        public FbConnection FbConnection
        {
            get { return _fbConnection; }
            set { _fbConnection = value; }
        }


        public EditionViewer()
        {
            InitializeComponent();
        }

        void FillEditionsList()
        {
            FbCommand cmd = new FbCommand(@"select id, number, end_date, start_date, state, tickets
                                                from get_editions_list",
                                          _fbConnection);

            FbDataAdapter da = new FbDataAdapter(cmd);

            _editionsTable.Clear();
            da.Fill(_editionsTable);
            _editionsGrid.SetDataSource(_editionsTable);
        }

        public void Init()
        {
            FillEditionsList();
        }

        private void _addEditionB_Click(object sender, EventArgs e)
        {
            EditionEditorF frm = new EditionEditorF();
            frm.FbConnection = _fbConnection;
            if (frm.ShowDialog() == DialogResult.OK)
                FillEditionsList();
        }

    }
}
