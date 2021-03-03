using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistem
{
    class Sesija : ISesija
    {
        private readonly string ADMIN_IME = "admin_ime";
        private static Sesija sesija = null;
        private readonly Dictionary<string, string> sesija_niz = new Dictionary<string, string>();

        private Sesija() { }

        public static Sesija dajSessiju()
        {
            if (Sesija.sesija == null)
            {
                Sesija.sesija = new Sesija();
            }
            return Sesija.sesija;
        }

        public void Logout_korisnika()
        {
            sesija_niz.Remove(ADMIN_IME);
        }

        public bool Provera_validnosti()
        {
            return sesija_niz.ContainsKey(ADMIN_IME);
        }

        public void Registruj_korisnika(string admin_ime)
        {
            sesija_niz.Add(ADMIN_IME, admin_ime);     
        }
    }
}
