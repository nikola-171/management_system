﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistem
{
    public sealed class Baza
    {
        /*implementacija mysql baze*/

        private static Baza instanca = null;
        private static readonly string KONEKCIJA = "server=localhost;user id=fakultet_admin;database=fakultet;port=3308;password=admin_lozinka";
        private Baza() { }

        public List<Dictionary<string, string>> Daj_sve_univerzitete()
        {
            List<Dictionary<string, string>> rez = null;
            try
            {
                using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
                {
                    con.Open();

                    string rtn = "daj_sve_univerzitete";

                    MySqlCommand cmd = new MySqlCommand(rtn, con);
                    cmd.CommandType = CommandType.StoredProcedure;

                 
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    rez = new List<Dictionary<string, string>>();
                    while (rdr.Read())
                    {
                        var d = new Dictionary<string, string>();
                        d.Add("naziv", rdr.GetString(rdr.GetOrdinal("naziv")));
                        d.Add("id", rdr.GetString(rdr.GetOrdinal("id")));
                        d.Add("grad", rdr.GetString(rdr.GetOrdinal("grad")));
                        d.Add("drzava", rdr.GetString(rdr.GetOrdinal("drzava")));

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

       
        /*registracija korisnika, dozvoljeno je da postoji samo jedan korisnik
          baza reguliše broj registrovanih korinsika */
        public Dictionary<string, string> Daj_podatke_o_adminu(string admin_ime)
        {
            Dictionary<string, string> podaci = new Dictionary<string, string>();

            try
            {
                using(MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
                {
                    con.Open();

                    string rtn = "daj_podatke_o_administrator";

                    MySqlCommand cmd = new MySqlCommand(rtn, con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@admin_ime_in", admin_ime);
                    

                    MySqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        podaci.Add("ime", rdr.GetString(rdr.GetOrdinal("ime")));
                        podaci.Add("prezime", rdr.GetString(rdr.GetOrdinal("prezime")));
                        podaci.Add("email", rdr.GetString(rdr.GetOrdinal("email")));
                        podaci.Add("telefon", rdr.GetString(rdr.GetOrdinal("telefon")));
                        podaci.Add("administrator_ime", rdr.GetString(rdr.GetOrdinal("administrator_ime")));          
                    }

                }
               
            }catch(MySqlException exception)
            {
                throw new Exception("došlo je do greške prilikom uzimanja podatke iz baze " + exception.ToString());
            }
            return podaci;
        }

        public bool Validacija_korisnika(string admin_ime, string admin_lozinka)
        {
            bool status = false;

            try
            {
                using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
                {
                    con.Open();

                    string rtn = "validacija";
                    MySqlCommand cmd = new MySqlCommand(rtn, con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@admin_ime_in", admin_ime);
                    cmd.Parameters.AddWithValue("@admin_lozinka_in", admin_lozinka);



                    MySqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        status = rdr.GetBoolean(rdr.GetOrdinal("status"));
                    }

               
                }
            }
            catch (MySqlException excpetion)
            {
                throw new Exception("could not connect to mysql" + excpetion.ToString());
            }
            return status;
        }

        public int Registracija_korisnika(string admin_ime,string admin_lozinka, string email, string telefon, string ime, string prezime)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Baza.KONEKCIJA))
                {
                    con.Open();

                    string rtn = "upis_administratora";
                    MySqlCommand cmd = new MySqlCommand(rtn, con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@admin_ime", admin_ime);
                    cmd.Parameters.AddWithValue("@admin_lozinka", admin_lozinka);
                    cmd.Parameters.AddWithValue("@email_in", email);
                    cmd.Parameters.AddWithValue("@telefon_in", telefon);
                    cmd.Parameters.AddWithValue("@ime_in", ime);
                    cmd.Parameters.AddWithValue("@prezime_in", prezime);


                    MySqlDataReader rdr = cmd.ExecuteReader();

                    int status = -1;

                    if (rdr.Read())
                    {
                        status = rdr.GetInt32(rdr.GetOrdinal("status"));
                    }
                    
                    return status;
                    
                }
            }
            catch (MySqlException excpetion)
            {
                throw new Exception("could not connect to mysql" + excpetion.ToString());
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
