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
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

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


            FbConnectionForm cFrm = new FbConnectionForm();
            cFrm.Database = "bookprognoz";
            
            if (cFrm.ShowDialog() == DialogResult.OK)
            {
                MainF form = new MainF(cFrm.Connection);
                Application.Run(form);
            }

#if !DEBUG
            if (zebedeStarted)
                pr.Kill();
#endif

        }


        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
