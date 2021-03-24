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
        private static readonly string GRESKA = "greška prilikom registrovanja profesora, baza nije vratila ID";

        #region daj_sve_profesore
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
                    red.Add("korisnicko_ime", rdr.GetString(rdr.GetOrdinal("korisnicko_ime")));
                    red.Add("datum_rodjenja", rdr.GetString(rdr.GetOrdinal("datum_rodjenja")));
                    red.Add("jmbg", rdr.GetString(rdr.GetOrdinal("JMBG")));
                    red.Add("zvanje", rdr.GetString(rdr.GetOrdinal("zvanje")));

                    rezultat.Add(red);
                }

            }

            return rezultat;
        }
        #endregion

        #region dodaj_novog_profesora
        public int Dodaj_profesora(string ime, string prezime, string email, string telefon, string datum_rodjenja,
                                   string korisnicko_ime,
                                   string lozinka, string jmbg, string zvanje)
        {

            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "dodaj_novog_profesora";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ime_in", ime);
                cmd.Parameters.AddWithValue("@prezime_in", prezime);
                cmd.Parameters.AddWithValue("@JMBG_in", jmbg);
                cmd.Parameters.AddWithValue("@zvanje_in", zvanje);
                cmd.Parameters.AddWithValue("@datum_rodjenja_in", datum_rodjenja);
                cmd.Parameters.AddWithValue("@korisnicko_ime_in", korisnicko_ime);
                cmd.Parameters.AddWithValue("@lozinka_in", lozinka);
                cmd.Parameters.AddWithValue("@telefon_in", telefon);
                cmd.Parameters.AddWithValue("@email_in", email);

                MySqlDataReader rdr = cmd.ExecuteReader();
                int id_profesora = -1;

                if (rdr.Read())
                {
                    id_profesora = rdr.GetInt32(rdr.GetOrdinal("id_profesora"));
                }

                /// ako baza ne vrati ID znaci da se desila greska u bazi i stoga bacamo exception
               
                if (id_profesora.Equals(-1))
                {
                    throw new Exception(Baza.GRESKA);
                }

                return id_profesora;

            }
        }
        #endregion

        #region daj_informacije_o_profesoru_na_osnovu_njegovo-ID
        public Dictionary<string, string> Daj_informacije_o_profesoru(UInt32 id)
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
                    rezultat.Add("email", rdr.GetString(rdr.GetOrdinal("email")));
                    rezultat.Add("telefon", rdr.GetString(rdr.GetOrdinal("telefon")));
                    rezultat.Add("korisnicko_ime", rdr.GetString(rdr.GetOrdinal("korisnicko_ime")));
                    rezultat.Add("datum_rodjenja", rdr.GetString(rdr.GetOrdinal("datum_rodjenja")));
                    rezultat.Add("jmbg", rdr.GetString(rdr.GetOrdinal("JMBG")));
                    rezultat.Add("zvanje", rdr.GetString(rdr.GetOrdinal("zvanje")));

                }

            }
            return rezultat;
        }
        #endregion

        #region izbriši_profesora_na_osnovu_njegovo_ID
        public void Izbrisi_profesora(int id)
        {
            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "izbrisi_profesora";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_in", id);

                MySqlDataReader rdr = cmd.ExecuteReader();    

            }

        }
        #endregion

        #region dodeli_predmet_profesoru
        public string Dodeli_predmet_profesoru(UInt32 profesor, UInt32 predmet, sbyte tip)
        {
            bool? status = null;
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

                if (rdr.Read())
                {
                    status = rdr.GetBoolean(rdr.GetOrdinal("msg"));
                }

            }
            if (status.Equals(null))
            {
                throw new Exception("greška prilikom dodavanja profesora predmetu, baza nije vratila odgovor");
            }
            else if ((bool)!status)
            {
                return "Profesor je već dodeljen datom predmetu.";
            }
            return "Profesoru uspešno dodeljen predmet.";
        }
        #endregion

        #region daj_predmete_na_kojima_predaje_profesor
        public List<Dictionary<string, string>> Daj_predmete_na_kojima_predaje_profesor(UInt32 profesor)
        {
            List<Dictionary<string, string>> rezultat = new List<Dictionary<string, string>>();

            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "daj_predmete_na_kojima_predaje_profesor";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_in", profesor);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Dictionary<string, string> red = new Dictionary<string, string>();

                   
                    red.Add("email", rdr.GetString(rdr.GetOrdinal("email")));
        
                    red.Add("naziv", rdr.GetString(rdr.GetOrdinal("naziv")));
                    red.Add("tip", rdr.GetString(rdr.GetOrdinal("tip")));


                    rezultat.Add(red);
                }

            }

            return rezultat;
        }
        #endregion

        #region daj_sve_profesore_iz_arhive
        public List<Dictionary<string, string>> Daj_sve_profesore_iz_arhive()
        {
            List<Dictionary<string, string>> rezultat = new List<Dictionary<string, string>>();

            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "daj_listu_profesora_iz_arhive";

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

                    rezultat.Add(red);
                }

            }

            return rezultat;
        }
        #endregion
    }
}
