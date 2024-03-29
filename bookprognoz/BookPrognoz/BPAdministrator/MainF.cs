﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdConnectionForm;
using FirebirdSql.Data.FirebirdClient;

namespace BPAdministrator
{
    public partial class MainF : Form
    {
        FbConnection _connection;
        DataTable _matchesTable = new DataTable();

        public MainF(FbConnection connection)
        {
            _connection = connection;
            InitializeComponent();
            
            _editionViewer.FbConnection = _connection;
        }

        private void MainF_Load(object sender, EventArgs e)
        {
            _editionViewer.Init();
        }
    }
}
