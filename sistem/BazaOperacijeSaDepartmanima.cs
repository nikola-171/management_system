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
    }
}
