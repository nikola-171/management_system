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
        public List<Dictionary<string, string>> Daj_sve_profesore()
        {
            List<Dictionary<string, string>> rezultat = new List<Dictionary<string, string>>();

            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "daj_sve_profesore";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;
            

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    Dictionary<string, string> red = new Dictionary<string, string>();

                    red.Add("id", rdr.GetString(rdr.GetOrdinal("id")));
                    red.Add("ime", rdr.GetString(rdr.GetOrdinal("ime")));
                    red.Add("prezime", rdr.GetString(rdr.GetOrdinal("prezime")));
                    red.Add("email", rdr.GetString(rdr.GetOrdinal("email")));
                    red.Add("telefon", rdr.GetString(rdr.GetOrdinal("telefon")));
                    red.Add("godina_rodjenja", rdr.GetString(rdr.GetOrdinal("godina_rodjenja")));
                    red.Add("mesec_rodjenja", rdr.GetString(rdr.GetOrdinal("mesec_rodjenja")));
                    red.Add("dan_rodjenja", rdr.GetString(rdr.GetOrdinal("dan_rodjenja")));
                    red.Add("korisnicko_ime", rdr.GetString(rdr.GetOrdinal("korisnicko_ime")));

                    rezultat.Add(red);
                }

            }

            return rezultat;
        }
        public void Dodaj_profesora(string ime, string prezime, string email, string telefon, int dan, int mesec,
                                   int godina, string korisnicko_ime,
                                   string lozinka)
        {

            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "dodaj_novog_profesora";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ime_in", ime);
                cmd.Parameters.AddWithValue("@prezime_in", prezime);
                cmd.Parameters.AddWithValue("@godina_rodjenja_in", godina);
                cmd.Parameters.AddWithValue("@mesec_rodjenja_in", mesec);
                cmd.Parameters.AddWithValue("@dan_rodjenja_in", dan);
                cmd.Parameters.AddWithValue("@korisnicko_ime_in", korisnicko_ime);
                cmd.Parameters.AddWithValue("@lozinka_in", lozinka);
                cmd.Parameters.AddWithValue("@telefon_in", telefon);
                cmd.Parameters.AddWithValue("@email_in", email);


                MySqlDataReader rdr = cmd.ExecuteReader();

            }
        }

        public Dictionary<string, string> Daj_informacije_o_profesoru(int id)
        {
            Dictionary<string, string> rezultat = new Dictionary<string, string>();

            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "daj_profesora_na_osnovu_id";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_in", id);

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {

                    rezultat.Add("id", rdr.GetString(rdr.GetOrdinal("id")));
                    rezultat.Add("ime", rdr.GetString(rdr.GetOrdinal("ime")));
                    rezultat.Add("prezime", rdr.GetString(rdr.GetOrdinal("prezime")));                  
                    rezultat.Add("godina_rodjenja", rdr.GetString(rdr.GetOrdinal("godina_rodjenja")));
                    rezultat.Add("mesec_rodjenja", rdr.GetString(rdr.GetOrdinal("mesec_rodjenja")));
                    rezultat.Add("dan_rodjenja", rdr.GetString(rdr.GetOrdinal("dan_rodjenja")));
                    rezultat.Add("email", rdr.GetString(rdr.GetOrdinal("email")));
                    rezultat.Add("telefon", rdr.GetString(rdr.GetOrdinal("telefon")));
                    rezultat.Add("korisnicko_ime", rdr.GetString(rdr.GetOrdinal("korisnicko_ime")));

                }
                
            }
            return rezultat;
        }
        public void Izbrisi_profesora(int id)
        {

            List<Tuple<string, Tuple<string, string>>> parametri = new List<Tuple<string, Tuple<string, string>>>();
            parametri.Add(new Tuple<string, Tuple<string, string>>("int", new Tuple<string, string>("id_in", id.ToString())));


            Izvrši_upit("izbrisi_profesora", ref parametri);

        }

        public void Dodeli_predmet_profesoru(UInt32 profesor, UInt32 predmet, sbyte tip)
        {
            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "dodaj_profesor_predmet_par";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@profesor_in", profesor);
                cmd.Parameters.AddWithValue("@predmet_in", predmet);
                cmd.Parameters.AddWithValue("@tip_in", tip);


                MySqlDataReader rdr = cmd.ExecuteReader();

               // if (rdr.Read())
               // {
                    
               // }

            }
        }
    }
}
