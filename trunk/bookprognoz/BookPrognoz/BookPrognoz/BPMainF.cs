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

        public BPMainF()
        {
            InitializeComponent();
        }

        
        public BPMainF(FbConnection conn) :this()
        {
            _connection = conn;            
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
        }
    }
}
