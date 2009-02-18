using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using FirebirdConnectionForm;

namespace BookPrognoz
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

            bool zebedeStarted = false;

#if !DEBUG
            //runing zebedee
            ProcessStartInfo psi = new ProcessStartInfo(Application.StartupPath + "\\zebedee.exe");
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.Arguments = "-fmyconf.zbd";
            Process pr = new Process();
            pr.StartInfo = psi;

            if (pr.Start())
                zebedeStarted = true;
#endif

            //connecting to DB
            FbConnectionForm cFrm = new FbConnectionForm();
            cFrm.Database = "bookprognoz";                      

            if (cFrm.ShowDialog() == DialogResult.OK)
            {                
                BPMainF form = new BPMainF(cFrm.Connection);
                Application.Run(form);
            }

#if !DEBUG
            if (zebedeStarted)
                pr.Kill();
#endif
           
        }
    }
}
