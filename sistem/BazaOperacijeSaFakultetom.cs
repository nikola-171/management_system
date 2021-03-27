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
        // operacije sa fakultetom

        #region izmeni_fakultet
        public void Izmeni_fakultet(int id, string naziv, string mesto)
        {

            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "promeni_fakultet";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@id_in", id);
                cmd.Parameters.AddWithValue("@naziv_in", naziv);
                cmd.Parameters.AddWithValue("@mesto_in", mesto);

                MySqlDataReader rdr = cmd.ExecuteReader();

            }
        }
        #endregion

        #region izbrisi_fakultet
        public void Izbrisi_fakultet(int id)
        {
            
            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "izbrisi_fakultet";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@id_in", id);        

                MySqlDataReader rdr = cmd.ExecuteReader();          

            }       
        }
        #endregion

        #region dodavanje_fakulteta
        public void Dodavanje_fakulteta(string naziv, string mesto, int univerzitet)
        {
            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "dodaj_fakultet";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@naziv_in", naziv);
                cmd.Parameters.AddWithValue("@mesto_in", mesto);
                cmd.Parameters.AddWithValue("@univerzitet_in", univerzitet);


                MySqlDataReader rdr = cmd.ExecuteReader();

            }

        }
        #endregion

        #region daj_sve_fakultete
        public List<Dictionary<string, string>> Daj_sve_fakultete()
        {
            List<Dictionary<string, string>> rez = null;
            
            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "daj_sve_fakultete";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;


                MySqlDataReader rdr = cmd.ExecuteReader();
                rez = new List<Dictionary<string, string>>();
                while (rdr.Read())
                {
                    var d = new Dictionary<string, string>();
                    d.Add("naziv", rdr.GetString(rdr.GetOrdinal("naziv")));
                    d.Add("id", rdr.GetString(rdr.GetOrdinal("id")));
                    d.Add("mesto", rdr.GetString(rdr.GetOrdinal("mesto")));
                    d.Add("univerzitet", rdr.GetString(rdr.GetOrdinal("univerzitet")));

                    rez.Add(d);
                }

            }

            
            return rez;
        }
        #endregion

        #region daj_sve_promene_na_fakultetu
        public List<Dictionary<string, string>> Daj_sve_promene_na_fakultetu()
        {
            List<Dictionary<string, string>> rez = null;

            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "daj_listu_svih_promena_na_fakultetu";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;


                MySqlDataReader rdr = cmd.ExecuteReader();
                rez = new List<Dictionary<string, string>>();
                while (rdr.Read())
                {
                    var d = new Dictionary<string, string>();
                    d.Add("naziv", rdr.GetString(rdr.GetOrdinal("naziv")));
                    d.Add("korisnik", rdr.GetString(rdr.GetOrdinal("korisnik")));
                    d.Add("vreme", rdr.GetString(rdr.GetOrdinal("vreme")));
                    d.Add("poruka", rdr.GetString(rdr.GetOrdinal("poruka")));

                    rez.Add(d);
                }

            }
            return rez;
        }
        #endregion
    }
}
