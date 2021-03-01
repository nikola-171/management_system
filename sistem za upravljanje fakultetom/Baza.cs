using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistem
{
    public sealed class Baza
    {
        private static Baza instanca = null;
        private static string KONEKCIJA = "server=localhost;user id=root;database=sistem;password=";
        private Baza() { }

        public bool Provera_autentifikacije_korisnika(string korisnicko_ime,string lozinka)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Baza.KONEKCIJA))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("select * from admin", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                    DataSet ds = new DataSet();
                    adp.Fill(ds);

                    cmd.Dispose();
                    conn.Close();

                    DataRow r = ds.Tables[0].Rows[0];

                }
            }
            catch (MySqlException excpetion)
            {
                throw new Exception("could not connect to mysql");
            }

            return false;
        }
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
