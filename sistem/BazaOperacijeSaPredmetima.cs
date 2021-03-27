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

        #region dodavanje_predmeta
        public void Dodavanje_predmeta(string naziv, sbyte godina, sbyte semestar, sbyte espb, UInt32 departman)
        {
            
                using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
                {
                    con.Open();

                    string rtn = "dodaj_novi_predmet";

                    MySqlCommand cmd = new MySqlCommand(rtn, con);
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@naziv_in", naziv);
                    cmd.Parameters.AddWithValue("@godina_in", godina);
                    cmd.Parameters.AddWithValue("@semestar_in", semestar);
                    cmd.Parameters.AddWithValue("@espb_in", espb);
                    cmd.Parameters.AddWithValue("@departman_in", departman);



                    MySqlDataReader rdr = cmd.ExecuteReader();

                }       
        }
        #endregion

        #region brisanje_predmeta_koji_student_slusa
        public void Brisanje_predmeta_koji_student_slusa(UInt32 student, UInt32 predmet)
        {

            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "izbrisi_studenta_sa_predmeta";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@student_in", student);
                cmd.Parameters.AddWithValue("@predmet_in", predmet);
         

                MySqlDataReader rdr = cmd.ExecuteReader();

            }
        }
        #endregion

        #region daj_sve_predmete
        public List<Dictionary<string, string>> Daj_sve_predmete()
        {
            List<Dictionary<string, string>> rezultat = new List<Dictionary<string, string>>();

            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "daj_predmete_po_smerovima";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Dictionary<string, string> red = new Dictionary<string, string>();
                    red.Add("id", rdr.GetString(rdr.GetOrdinal("predmet")));
                    red.Add("naziv", rdr.GetString(rdr.GetOrdinal("predmet_naziv")));
                    red.Add("godina", rdr.GetString(rdr.GetOrdinal("predmet_godina")));
                    red.Add("semestar", rdr.GetString(rdr.GetOrdinal("predmet_semestar")));
                    red.Add("espb", rdr.GetString(rdr.GetOrdinal("predmet_espb")));
                    red.Add("departman", rdr.GetString(rdr.GetOrdinal("smer_naziv")));

                    rezultat.Add(red);
                }

            }

            return rezultat;
        }
        #endregion
    }
}
