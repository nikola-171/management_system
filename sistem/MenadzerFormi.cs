using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistem
{
    class MenadzerFormi
    {
        private static readonly List<System.Windows.Forms.Form> forme = new List<System.Windows.Forms.Form>();

        public static int test()
        {
            return MenadzerFormi.forme.Count;
        }
        public static void Zatvori()
        {
            foreach (var forma in MenadzerFormi.forme)
            {
                forma.Dispose();
                forma.Hide();
                forma.Close();
            }
            foreach (Process proc in Process.GetProcessesByName("conhost"))
            {
                proc.Kill();
            }
            Environment.Exit(0);
        }
        public static T dajFormu<T>(System.Windows.Forms.Form trenutna) where T : System.Windows.Forms.Form, new()
        {
            
            T nazad = null;
            foreach (var forma in MenadzerFormi.forme)
            {
                if (forma.GetType() == typeof(T))
                {
                    nazad = (T)forma;
                    break;
                }
            }
            if(nazad == null)
            {
                T nova = new T();
                MenadzerFormi.forme.Add(nova);
                nazad = nova;
            }
            
            if(trenutna != null)
            {
                trenutna.Hide();
                nazad.Show();  
                
            }
            
            return nazad;
            
        }
    }
}
