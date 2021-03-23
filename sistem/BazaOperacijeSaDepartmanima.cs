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
        #region brisanje_departmana
        public void Izbriši_departman(int id)
        {


            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "izbrisi_smer";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_in", id);
                MySqlDataReader rdr = cmd.ExecuteReader();

                //d.Add("smer", rdr.GetString(rdr.GetOrdinal("smer")));

            }
        }
        #endregion

        #region dodavanje-novog_departmana
        public void Dodaj_departman(int fakultet, string naziv, string trajanje, string espb, string nivo_studija)
        {
            List<Tuple<string, Tuple<string, string>>> parametri = new List<Tuple<string, Tuple<string, string>>>();
            parametri.Add(new Tuple<string, Tuple<string, string>>("int", new Tuple<string, string>("fakultet_in", fakultet.ToString())));
            parametri.Add(new Tuple<string, Tuple<string, string>>("string", new Tuple<string, string>("naziv_in", naziv)));
            parametri.Add(new Tuple<string, Tuple<string, string>>("string", new Tuple<string, string>("nivo_studija_in", nivo_studija)));
            parametri.Add(new Tuple<string, Tuple<string, string>>("string", new Tuple<string, string>("espb_in", espb)));
            parametri.Add(new Tuple<string, Tuple<string, string>>("string", new Tuple<string, string>("trajanje_in", trajanje)));


            Izvrši_upit("dodaj_smer", ref parametri);
        }
        #endregion

        #region uzimanje_liste_svih-departmana
        public List<Dictionary<string, string>> Daj_sve_departmane()
        {
            

            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "prikaz_smerova_po_fakultetima_i_univerzitetima";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataReader rdr = cmd.ExecuteReader();

                List<Dictionary<string, string>> rez = new List<Dictionary<string, string>>();

                while (rdr.Read())
                {
                    Dictionary<string, string> d = new Dictionary<string, string>();

                    d.Add("univerzitet", rdr.GetString(rdr.GetOrdinal("univerzitet")));
                    d.Add("fakultet", rdr.GetString(rdr.GetOrdinal("fakultet")));
                    d.Add("smer", rdr.GetString(rdr.GetOrdinal("smer")));
                    d.Add("id", rdr.GetString(rdr.GetOrdinal("id")));
                    d.Add("nivo_studija", rdr.GetString(rdr.GetOrdinal("nivo_studija")));


                    rez.Add(d);

                }
                return rez;

            }
        }
        #endregion
    }
}
