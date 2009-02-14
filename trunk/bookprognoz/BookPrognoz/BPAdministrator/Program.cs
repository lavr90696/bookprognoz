using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FirebirdConnectionForm;
using System.Diagnostics;

namespace BPAdministrator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            
            FbConnectionForm cFrm = new FbConnectionForm();
            cFrm.Database = "bookprognoz";

            if (cFrm.ShowDialog() == DialogResult.OK)
            {
                MainF form = new MainF(cFrm.Connection);
                Application.Run(form);
            }
            
        }
    }
}
