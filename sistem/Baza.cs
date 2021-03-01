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
        /*implementacija mysql baze*/

        private static Baza instanca = null;
        private static string KONEKCIJA = "server=localhost;user id=fakultet_admin;database=fakultet;port=3308;password=admin_lozinka";
        private Baza() { }

       
        /*registracija */

        public int Registracija_korisnika(string admin_ime,string admin_lozinka, string email, string telefon)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
                {
                    con.Open();

                    string rtn = "upis_administratora";
                    MySqlCommand cmd = new MySqlCommand(rtn, con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@admin_ime", admin_ime);
                    cmd.Parameters.AddWithValue("@admin_lozinka", admin_lozinka);
                    cmd.Parameters.AddWithValue("@email_in", email);
                    cmd.Parameters.AddWithValue("@telefon_in", telefon);


                    MySqlDataReader rdr = cmd.ExecuteReader();

                    int status = -1;

                    if (rdr.Read())
                    {
                        int d = rdr.GetInt32(0);
                    }
                    return status;
                    
                }
            }
            catch (MySqlException excpetion)
            {
                throw new Exception("could not connect to mysql" + excpetion.ToString());
            }
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
