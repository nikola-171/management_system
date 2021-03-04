using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        static Mutex mutex = new Mutex(false, "applikacija_82rn");
        [STAThread]
        static void Main()
        {
            if (!mutex.WaitOne(TimeSpan.FromSeconds(2), false))
            {
                MessageBox.Show("Aplikacija je već pokrenuta", "", MessageBoxButtons.OK);
                return;
            }
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(MenadzerFormi.dajFormu<FormaLogovanje>(null));
            }
            finally
            {
                mutex.ReleaseMutex();
            }
            
        }
    }
}
