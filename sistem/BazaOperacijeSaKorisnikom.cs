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
        
        #region uzimanje_informacija_o_administratoru
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
        #endregion

        #region validacija_korisnika
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
        #endregion

        #region uzimanje_tekuce_fakultetske_godine
        public string daj_tekucu_fakultetsku_godinu()
        {
            string tekuca_godina = string.Empty;
            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "daj_tekucu_fakultetsku_godinu";
                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;
       
                MySqlDataReader rdr = cmd.ExecuteReader();        

                if (rdr.Read())
                {
                    tekuca_godina = rdr.GetString(rdr.GetOrdinal("fakultetska_godina"));
                }
            }

            if (tekuca_godina.Equals(string.Empty))
            {
                throw new Exception("greška prilikom uzimanja tekuće fakultetske godine");
            }

            return tekuca_godina;
        }
        #endregion

        #region registracija_korisnika
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
        #endregion

        #region azuriranje_fakultetske_godine
        public void Azuriraj_fakultetsku_godinu(string naziv)
        {
            string s = string.Empty;
            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "unos_nove_fakultetske_godine";
                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@godina", naziv);
   

                MySqlDataReader rdr = cmd.ExecuteReader();    
                
            }    

        }
        #endregion

    }
}
