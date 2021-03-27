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
        #region dodavanje_univerziteta
        public void Dodavanje_univerziteta(string naziv, string drzava, string grad)
        {
            
            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "upis_univerziteta";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@naziv", naziv);
                cmd.Parameters.AddWithValue("@drzava", drzava);
                cmd.Parameters.AddWithValue("@grad", grad);


                MySqlDataReader rdr = cmd.ExecuteReader();

            }

           
        }
        #endregion

        #region izbrisi_univerzitet
        public void Izbrisi_univerzitet(int id)
        {
            
            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                 con.Open();

                 string rtn = "izbrisi_univerzitet";

                 MySqlCommand cmd = new MySqlCommand(rtn, con);
                 cmd.CommandType = CommandType.StoredProcedure;

                 cmd.Parameters.AddWithValue("@id_in", id);


                 MySqlDataReader rdr = cmd.ExecuteReader();

            }
           
        }
        #endregion

        #region sacuvaj_izmene_na_univerzitetu
        public void Sacuvaj_izmene_na_univerzitetu(int id, string naziv, string drzava, string grad)
        {
            
            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "promeni_univerzitet";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_in", id);
                cmd.Parameters.AddWithValue("@naziv_in", naziv);
                cmd.Parameters.AddWithValue("@drzava_in", drzava);
                cmd.Parameters.AddWithValue("@grad_in", grad);

                MySqlDataReader rdr = cmd.ExecuteReader();

            }
        }
        #endregion

        #region daj_sve_univerzitete
        public List<Dictionary<string, string>> Daj_sve_univerzitete()
        {
            List<Dictionary<string, string>> rez = null;
            
            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "daj_sve_univerzitete";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;


                MySqlDataReader rdr = cmd.ExecuteReader();
                rez = new List<Dictionary<string, string>>();
                while (rdr.Read())
                {
                    var d = new Dictionary<string, string>();
                    d.Add("naziv", rdr.GetString(rdr.GetOrdinal("naziv")));
                    d.Add("id", rdr.GetString(rdr.GetOrdinal("id")));
                    d.Add("grad", rdr.GetString(rdr.GetOrdinal("grad")));
                    d.Add("drzava", rdr.GetString(rdr.GetOrdinal("drzava")));

                    rez.Add(d);
                }

            }
            return rez;
        }
        #endregion

        #region daj_sve_promene_na_univerzitetu
        public List<Dictionary<string, string>> Daj_sve_promene_na_univerzitetu()
        {
            List<Dictionary<string, string>> rez = null;

            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "daj_listu_svih_promena_na_univerzitetu";

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
