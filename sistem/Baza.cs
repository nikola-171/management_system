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
        /*implementacija mysql baze*/
        //brisanje univerziteta nije uvek moguće zboh ograničenja stranih ključeva, implementiraj status codes

        private static Baza instanca = null;
        private static readonly string KONEKCIJA = "server=localhost;user id=fakultet_admin;database=fakultet;port=3306;password=admin_lozinka";
        private Baza() { }

        
        public MySqlDataReader Izvrši_upit(string naziv_upita, ref List<Tuple<string, Tuple<string, string>>> parametri)
        {
            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                
                con.Open();

                string rtn = naziv_upita;

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;

                //dodavanje parametara

                foreach(var elem in parametri)
                {
                    if(elem.Item1 == "string")
                    {
                        cmd.Parameters.AddWithValue("@"+elem.Item2.Item1, elem.Item2.Item2);
                    }else if(elem.Item1 == "int")
                    {
                        cmd.Parameters.AddWithValue("@" + elem.Item2.Item1, Convert.ToInt32(elem.Item2.Item2));

                    }
                }
               
                MySqlDataReader rdr = cmd.ExecuteReader();

                return rdr;

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
