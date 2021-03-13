﻿using MySql.Data.MySqlClient;
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
        #region brisanje_studenta_iz_baze
        public void Izbrisi_studenta(int id)
        {
            
            List<Tuple<string, Tuple<string, string>>> parametri = new List<Tuple<string, Tuple<string, string>>>();
            parametri.Add(new Tuple<string, Tuple<string, string>>("int", new Tuple<string, string>("id_in", id.ToString())));
 

            Izvrši_upit("izbrisi_studenta", ref parametri);
            
        }
        #endregion

        #region dodavanje_studenata
        public int Dodaj_studenta(string ime, string prezime, string email, string telefon, int dan, int mesec,
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

                int student_broj_indeksa = -1;

                if (rdr.Read())
                {
                    student_broj_indeksa = rdr.GetInt32(rdr.GetOrdinal("broj_indeksa"));
                }

                /// ako baza ne vrati broj indeksa znaci da se desila greska u bazi i stoga bacamo exception

                if (student_broj_indeksa.Equals(-1))
                {
                    throw new Exception(Baza.GRESKA);
                }

                return student_broj_indeksa;

            }
        }
        #endregion

        #region uzimanje_svih_studenata_iz_baze
        public List<Dictionary<string, string>> Daj_sve_studente()
        {
            List<Dictionary<string, string>> rezultat = new List<Dictionary<string, string>>();
            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "daj_sve_studente";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;
           
                MySqlDataReader rdr = cmd.ExecuteReader();
        
                while (rdr.Read())
                {
                    Dictionary<string, string> red = new Dictionary<string, string>();
                    red.Add("broj_indeksa", rdr.GetString(rdr.GetOrdinal("broj_indeksa")));
                    red.Add("ime", rdr.GetString(rdr.GetOrdinal("ime")));
                    red.Add("prezime", rdr.GetString(rdr.GetOrdinal("prezime")));
                    red.Add("departman", rdr.GetString(rdr.GetOrdinal("naziv")));
                    red.Add("fakultet", rdr.GetString(rdr.GetOrdinal("fakultet")));
                    red.Add("diplomirao", rdr.GetString(rdr.GetOrdinal("diplomirao")));
                    red.Add("espb", rdr.GetString(rdr.GetOrdinal("espb")));
                    red.Add("prosek", rdr.GetString(rdr.GetOrdinal("prosek")));
                    red.Add("status", rdr.GetString(rdr.GetOrdinal("status_studenta")));

                    rezultat.Add(red);

                }
            }
            return rezultat;
        }
        #endregion

        #region uzimanje_podataka_o_studentu_na_osnovu_broja_indeksa
        public Dictionary<string, string> Daj_informacije_o_studentu(int broj_indeksa)
        {
            Dictionary<string, string> rezultat = new Dictionary<string, string>();

            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "daj_podatke_o_studentu";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@broj_indeksa_in", broj_indeksa);

                MySqlDataReader rdr = cmd.ExecuteReader();

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
            }
            return rezultat;
        }
        #endregion

        #region dodelivanje_studenta_predmetu
        public void Dodeli_studenta_predmetu(UInt32 broj_indeksa, UInt32 predmet_id)
        {
            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "dodaj_student_slusa_predmet_par";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@student_in", broj_indeksa);
                cmd.Parameters.AddWithValue("@predmet_in", predmet_id);


                MySqlDataReader rdr = cmd.ExecuteReader();

                /*if (rdr.Read())
                {
                    int status = rdr.GetOrdinal("msg");           
                }*/
            }
        }
        #endregion

        #region dodavanje_polozenog_ispita_studentu
        public string Dodaj_polozen_ispit_studentu(UInt32 broj_indeksa, UInt32 predmet_id, string datum, byte ocena)
        {
            using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
            {
                con.Open();

                string rtn = "dodaj_polozen_ispit_studentu";

                MySqlCommand cmd = new MySqlCommand(rtn, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@student_in", broj_indeksa);
                cmd.Parameters.AddWithValue("@predmet_in", predmet_id);
                cmd.Parameters.AddWithValue("@ocena_in", ocena);
                cmd.Parameters.AddWithValue("@datum_in", datum);

                MySqlDataReader rdr = cmd.ExecuteReader();

                // povratna informacija iz baze
                string status = "";

                if (rdr.Read())
                {
                    status = rdr.GetString(rdr.GetOrdinal("msg"));
                }

                return status;
            }
        }
        #endregion
    }
}
