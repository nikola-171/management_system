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
        public static T dajFormu<T>(System.Windows.Forms.Form trenutna, List<Tuple<string, string>> parametri_formi = null, bool osvezi_sadrzaj = false) where T : System.Windows.Forms.Form, DodavanjeParametara, new()
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
            if (nazad == null)
            {

                T nova = new T();

                MenadzerFormi.forme.Add(nova);
                nazad = nova;
            }



            if (parametri_formi != null)
            {
                nazad.Postavi_parametre(parametri_formi);
            }

            if (osvezi_sadrzaj)
            {
                nazad.Osvezi_sadrzaj();
            }

            if (trenutna != null)
            {
                trenutna.Hide();
            }
            nazad.Show();

            return nazad;

        }
    }
}
