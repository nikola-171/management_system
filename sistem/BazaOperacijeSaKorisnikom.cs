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
        public Dictionary<string, string> Daj_podatke_o_adminu(string admin_ime)
        {
            Dictionary<string, string> podaci = new Dictionary<string, string>();

            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "daj_podatke_o_administrator";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@admin_ime_in", admin_ime);

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    podaci.Add("ime", rdr.GetString(rdr.GetOrdinal("ime")));
                    podaci.Add("prezime", rdr.GetString(rdr.GetOrdinal("prezime")));
                    podaci.Add("email", rdr.GetString(rdr.GetOrdinal("email")));
                    podaci.Add("telefon", rdr.GetString(rdr.GetOrdinal("telefon")));
                    podaci.Add("administrator_ime", rdr.GetString(rdr.GetOrdinal("administrator_ime")));
                }
            }
            
            return podaci;
        }
        public bool Validacija_korisnika(string admin_ime, string admin_lozinka)
        {
            bool status = false;

            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "validacija";
                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@admin_ime_in", admin_ime);
                cmd.Parameters.AddWithValue("@admin_lozinka_in", admin_lozinka);

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    status = rdr.GetBoolean(rdr.GetOrdinal("status"));
                }
            }
            return status;
        }
        public int Registracija_korisnika(string admin_ime, string admin_lozinka, string email, string telefon, string ime, string prezime)
        {
            int status = -1;

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
                cmd.Parameters.AddWithValue("@ime_in", ime);
                cmd.Parameters.AddWithValue("@prezime_in", prezime);

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    status = rdr.GetInt32(rdr.GetOrdinal("status"));
                }
            }
            return status;
        }

    }
}
