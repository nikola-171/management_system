using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistem
{
    public partial class Baza
    {
        /*implementacija mysql baze*/
        //brisanje univerziteta nije uvek moguće zboh ograničenja stranih ključeva, implementiraj status codes

        private static Baza instanca = null;
        private static readonly string KONEKCIJA = "server=localhost;user id=fakultet_admin;database=fakultet;port=3308;password=admin_lozinka";
        private Baza() { }
       
        public static Baza daj_instancu()
        {
           if(Baza.instanca == null)
            {
                Baza.instanca = new Baza();
            }

            return Baza.instanca;
        }

    }
}
