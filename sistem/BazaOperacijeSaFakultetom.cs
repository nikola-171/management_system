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

        public void Izmeni_fakultet(int id, string naziv, string mesto)
        {
            List<Tuple<string, Tuple<string, string>>> parametri = new List<Tuple<string, Tuple<string, string>>>();
            parametri.Add(new Tuple<string, Tuple<string, string>>("int", new Tuple<string, string>("id_in", id.ToString())));
            parametri.Add(new Tuple<string, Tuple<string, string>>("string", new Tuple<string, string>("naziv_in", naziv)));
            parametri.Add(new Tuple<string, Tuple<string, string>>("string", new Tuple<string, string>("mesto_in", mesto)));
            
            Izvrši_upit("promeni_fakultet", ref parametri);

           
        }

        public void Izbrisi_fakultet(int id)
        {
            try
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
            catch (MySqlException exception)
            {
                throw new Exception("došlo je do greške prilikom uzimanja podatke iz baze " + exception.ToString());
            }
        }

        public void Dodavanje_fakulteta(string naziv, string mesto, int univerzitet)
        {
            try
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
            catch (MySqlException exception)
            {
                throw new Exception("došlo je do greške prilikom uzimanja podatke iz baze " + exception.ToString());
            }
        }

        public List<Dictionary<string, string>> Daj_sve_fakultete()
        {
            List<Dictionary<string, string>> rez = null;
            try
            {
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

            }
            catch (MySqlException exception)
            {
                throw new Exception("došlo je do greške prilikom uzimanja podatke iz baze " + exception.ToString());
            }
            return rez;
        }
    }
}
