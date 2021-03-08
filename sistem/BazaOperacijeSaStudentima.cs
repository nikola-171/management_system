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

        public void Izbrisi_studenta(int id)
        {
            
            List<Tuple<string, Tuple<string, string>>> parametri = new List<Tuple<string, Tuple<string, string>>>();
            parametri.Add(new Tuple<string, Tuple<string, string>>("int", new Tuple<string, string>("id_in", id.ToString())));
 

            Izvrši_upit("izbrisi_studenta", ref parametri);
            
        }

        public void Dodaj_studenta(string ime, string prezime, string email, string telefon, int dan, int mesec,
                                   int godina, string mesto_boravka, string ulica, string broj, string korisnicko_ime,
                                   string lozinka, int departman, int status)
        {
            
            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "dodaj_novog_studenta";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@smer_in", departman);
                cmd.Parameters.AddWithValue("@ime_in", ime);
                cmd.Parameters.AddWithValue("@prezime_in", prezime);
                cmd.Parameters.AddWithValue("@godina_rodjenja_in", godina);
                cmd.Parameters.AddWithValue("@mesec_rodjenja_in", mesec);
                cmd.Parameters.AddWithValue("@dan_rodjenja_in", dan);
                cmd.Parameters.AddWithValue("@ulica_in", ulica);
                cmd.Parameters.AddWithValue("@broj_in", broj);
                cmd.Parameters.AddWithValue("@mesto_boravka_in", mesto_boravka);
                cmd.Parameters.AddWithValue("@korisnicko_ime_in", korisnicko_ime);
                cmd.Parameters.AddWithValue("@lozinka_in", lozinka);
                cmd.Parameters.AddWithValue("@status_in",status);
                cmd.Parameters.AddWithValue("@telefon_in", telefon);
                cmd.Parameters.AddWithValue("@email_in", email);


                MySqlDataReader rdr = cmd.ExecuteReader();         

            }
        }

        public Dictionary<string, string> Daj_informacije_o_studentu(int broj_indeksa)
        {
            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "daj_podatke_o_studentu";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@broj_indeksa_in", broj_indeksa);

                MySqlDataReader rdr = cmd.ExecuteReader();

                Dictionary<string, string> rezultat = new Dictionary<string, string>();

                if (rdr.Read())
                {


                    rezultat.Add("broj_indeksa", rdr.GetString(rdr.GetOrdinal("broj_indeksa")));
                    rezultat.Add("ime", rdr.GetString(rdr.GetOrdinal("ime")));
                    rezultat.Add("prezime", rdr.GetString(rdr.GetOrdinal("prezime")));
                    rezultat.Add("smer", rdr.GetString(rdr.GetOrdinal("naziv")));
                    rezultat.Add("fakultet", rdr.GetString(rdr.GetOrdinal("fakultet")));
                    rezultat.Add("diplomirao", rdr.GetString(rdr.GetOrdinal("diplomirao")));
                    rezultat.Add("espb", rdr.GetString(rdr.GetOrdinal("espb")));
                    rezultat.Add("prosek", rdr.GetString(rdr.GetOrdinal("prosek")));
                    rezultat.Add("status_studenta", rdr.GetString(rdr.GetOrdinal("status_studenta")));



                }
                return rezultat;

            }
        }
    }
}
