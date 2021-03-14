﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;
using sistem.pdf_kreator;

namespace sistem
{
    public class GeneratorIzvestaja
    {
        #region uzimanje_svih_profesora
        private static Tuple<List<float>, DataTable> Daj_sve_profesore()
        {

            DataTable studenti = new DataTable();
            var rezultat = Baza.daj_instancu().Daj_sve_profesore();

            studenti.Columns.Add("id");
            studenti.Columns.Add("ime");     
            studenti.Columns.Add("kontakt");
            studenti.Columns.Add("datum rođenja");


            foreach (var elem in rezultat)
            {
                studenti.Rows.Add(elem["id"], elem["ime"] + " " + elem["prezime"],
                                      elem["email"] + " " + elem["telefon"], elem["dan_rodjenja"] + "-" + elem["mesec_rodjenja"] + "-" +elem["godina_rodjenja"]);
            }

            /// nije dobro ovo sve mora da ide u model
            List<float> velicina_kolone = new List<float>(4);
            velicina_kolone.Add(20);
            velicina_kolone.Add(40);
            velicina_kolone.Add(60);
            velicina_kolone.Add(30);

            return new Tuple<List<float>, DataTable>(velicina_kolone, studenti);
        }
        #endregion

        #region uzimanje_svih_studenata
        private static Tuple<List<float>, DataTable> Daj_sve_studente()
        {
            
            DataTable studenti = new DataTable();        
            var rezultat = Baza.daj_instancu().Daj_sve_studente();

            studenti.Columns.Add("broj indeksa");
            studenti.Columns.Add("ime");
            studenti.Columns.Add("fakultet");
            studenti.Columns.Add("status");
      

            foreach(var elem in rezultat)
            {
                studenti.Rows.Add(elem["broj_indeksa"], elem["ime"]+ " " + elem["prezime"],
                                      elem["fakultet"] + " " + elem["departman"], elem["prosek"]+ " espb: "+ elem["espb"]);
            }

            /// nije dobro ovo sve mora da ide u model
            List<float> velicina_kolone = new List<float>(4);
            velicina_kolone.Add(20);
            velicina_kolone.Add(40);
            velicina_kolone.Add(60);
            velicina_kolone.Add(30);

            return  new Tuple<List<float>, DataTable>(velicina_kolone, studenti);       
        }
        #endregion

        #region uzimanje_svih_predmeta
        private static Tuple<List<float>, DataTable> Daj_sve_predmete()
        {

            DataTable studenti = new DataTable();
            var rezultat = Baza.daj_instancu().Daj_sve_predmete();

            studenti.Columns.Add("id");
            studenti.Columns.Add("naziv");
            studenti.Columns.Add("departman");
            studenti.Columns.Add("godina");
            studenti.Columns.Add("semestar");
            studenti.Columns.Add("espv");

            foreach (var elem in rezultat)
            {
                studenti.Rows.Add(elem["id"], elem["naziv"], elem["departman"],
                                      elem["godina"], elem["semestar"], elem["espb"]);
            }

            /// nije dobro ovo sve mora da ide u model
            List<float> velicina_kolone = new List<float>(4);
            velicina_kolone.Add(20);
            velicina_kolone.Add(40);
            velicina_kolone.Add(60);
            velicina_kolone.Add(20);
            velicina_kolone.Add(20);
            velicina_kolone.Add(20);


            return new Tuple<List<float>, DataTable>(velicina_kolone, studenti);
        }
        #endregion

        #region uzimanje_svih_profesora_sa_predmetima_na_kojima_predaju
        private static Tuple<List<float>, DataTable> Daj_sve_profesore_sa_predmetima_na_kojima_predaju()
        {

            DataTable studenti = new DataTable();
            var rezultat = Baza.daj_instancu().Daj_sve_profesore_sa_predmetima_na_kojima_predaju();

            studenti.Columns.Add("profesor id");
            studenti.Columns.Add("ime");
            studenti.Columns.Add("predmet id");
            studenti.Columns.Add("predmet");


            foreach (var elem in rezultat)
            {
                studenti.Rows.Add(elem["profesor_id"], elem["profesor_ime"] + " " + elem["profesor_ime"],
                                      elem["predmet_id"], elem["predmet_naziv"]);
            }

            /// nije dobro ovo sve mora da ide u model
            List<float> velicina_kolone = new List<float>(4);
            velicina_kolone.Add(20);
            velicina_kolone.Add(40);
            velicina_kolone.Add(60);
            velicina_kolone.Add(30);

            return new Tuple<List<float>, DataTable>(velicina_kolone, studenti);
        }
        #endregion

        //nije završeno
        #region uzimanje_svih_studenata_koji_su_diplomirali
        private static Tuple<List<float>, DataTable> Daj_sve_studente_koji_su_diplomirali()
        {

            DataTable studenti = new DataTable();
            var rezultat = Baza.daj_instancu().Daj_sve_studente();

            studenti.Columns.Add("broj indeksa");
            studenti.Columns.Add("ime");
            studenti.Columns.Add("fakultet");
            studenti.Columns.Add("status");


            foreach (var elem in rezultat)
            {
                studenti.Rows.Add(elem["broj_indeksa"], elem["ime"] + " " + elem["prezime"],
                                      elem["fakultet"] + " " + elem["departman"], elem["prosek"] + " espb: " + elem["espb"]);
            }

            /// nije dobro ovo sve mora da ide u model
            List<float> velicina_kolone = new List<float>(4);
            velicina_kolone.Add(20);
            velicina_kolone.Add(40);
            velicina_kolone.Add(60);
            velicina_kolone.Add(30);

            return new Tuple<List<float>, DataTable>(velicina_kolone, studenti);
        }

        #endregion


        public static void Kreiraj_izvestaj_svih_studenata(string lokacija)
        {
            Tuple<List<float>, DataTable> podaci = Daj_sve_studente();
            PdfKreator.Daj_pdf_kreatora().Kreiraj(podaci, lokacija, "Studenti");                   
            System.Diagnostics.Process.Start(@lokacija);
        }

        public static void Kreiraj_izvestaj_svih_profesora(string lokacija)
        {
            Tuple<List<float>, DataTable> podaci = Daj_sve_profesore();
            PdfKreator.Daj_pdf_kreatora().Kreiraj(podaci, lokacija, "Profesori");
            System.Diagnostics.Process.Start(@lokacija);
        }

        public static void Kreiraj_izvestaj_svih_predmeta(string lokacija)
        {
            Tuple<List<float>, DataTable> podaci = Daj_sve_predmete();
            PdfKreator.Daj_pdf_kreatora().Kreiraj(podaci, lokacija, "Predmeti");
            System.Diagnostics.Process.Start(@lokacija);
        }

        public static void Kreiraj_izvestaj_svih_predmeta_sa_profesorima(string lokacija)
        {
            Tuple<List<float>, DataTable> podaci = Daj_sve_profesore_sa_predmetima_na_kojima_predaju();
            PdfKreator.Daj_pdf_kreatora().Kreiraj(podaci, lokacija, "Predmeti sa profesorima");
            System.Diagnostics.Process.Start(@lokacija);
        }

    }
}
