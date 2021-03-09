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
        public void Dodavanje_predmeta(string naziv, sbyte godina, sbyte semestar, sbyte espb, UInt32 departman)//izmeni proceduru
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

        //nije testirano!!!!!!!!!!!!
        public List<Dictionary<string, string>> Daj_sve_predmete()
        {
            List<Dictionary<string, string>> rezultat = new List<Dictionary<string, string>>();

            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "daj_sve_predmete";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;


                MySqlDataReader rdr = cmd.ExecuteReader();

            }

            return rezultat;
        }
    }
}
