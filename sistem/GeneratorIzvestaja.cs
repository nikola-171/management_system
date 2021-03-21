using System;
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

       

        #region uzimanje_liste_svih_promena_na_univerzitetima
        private static Tuple<List<float>, DataTable> Daj_sve_promene_na_univerzitetu()
        {

            DataTable promene = new DataTable();
            var rezultat = Baza.daj_instancu().Daj_sve_promene_na_univerzitetu();

            promene.Columns.Add("naziv");
            promene.Columns.Add("korisnik");
            promene.Columns.Add("vreme");
            promene.Columns.Add("poruka");


            foreach (var elem in rezultat)
            {
                promene.Rows.Add(elem["naziv"], elem["korisnik"], elem["vreme"], elem["poruka"]);
                                      
            }

            List<float> velicina_kolone = new List<float>(4);
            velicina_kolone.Add(60);
            velicina_kolone.Add(52);
            velicina_kolone.Add(55);
            velicina_kolone.Add(100);

            return new Tuple<List<float>, DataTable>(velicina_kolone, promene);
        }
        #endregion

        #region uzimanje_liste_svih_promena_na_fakultetima
        private static Tuple<List<float>, DataTable> Daj_sve_promene_na_fakultetu()
        {

            DataTable promene = new DataTable();
            var rezultat = Baza.daj_instancu().Daj_sve_promene_na_fakultetu();

            promene.Columns.Add("naziv");
            promene.Columns.Add("korisnik");
            promene.Columns.Add("vreme");
            promene.Columns.Add("poruka");


            foreach (var elem in rezultat)
            {
                promene.Rows.Add(elem["naziv"], elem["korisnik"], elem["vreme"], elem["poruka"]);

            }

            /// nije dobro ovo sve mora da ide u model
            List<float> velicina_kolone = new List<float>(4);
            velicina_kolone.Add(60);
            velicina_kolone.Add(52);
            velicina_kolone.Add(55);
            velicina_kolone.Add(100);

            return new Tuple<List<float>, DataTable>(velicina_kolone, promene);
        }
        #endregion

        #region stampa_polozenih_ispita_studenta
        private static Tuple<List<float>, DataTable> Stampaj_polozene_ispite(List<Dictionary<string, string>> rezultat)
        {

            DataTable promene = new DataTable();

            promene.Columns.Add("predmet");
            promene.Columns.Add("datum");
            promene.Columns.Add("ocena");
            promene.Columns.Add("fakultetska godina");


            foreach (var elem in rezultat)
            {
                promene.Rows.Add(elem["predmet"], elem["datum"], elem["ocena"], elem["fakultetska_godina"]);

            }

            /// nije dobro ovo sve mora da ide u model
            List<float> velicina_kolone = new List<float>(4);
            velicina_kolone.Add(60);
            velicina_kolone.Add(52);
            velicina_kolone.Add(55);
            velicina_kolone.Add(100);

            return new Tuple<List<float>, DataTable>(velicina_kolone, promene);
        }
        #endregion

        #region stampa_predmeta_na_kojima_predaje_profesor
        private static Tuple<List<float>, DataTable> Stampaj_predmete_profesora(List<Dictionary<string, string>> rezultat)
        {

            DataTable promene = new DataTable();

            promene.Columns.Add("email");
            promene.Columns.Add("naziv");
            promene.Columns.Add("tip");
        

            foreach (var elem in rezultat)
            {
                promene.Rows.Add(elem["email"], elem["naziv"], elem["tip"]);

            }

            List<float> velicina_kolone = new List<float>(3);
            velicina_kolone.Add(80);
            velicina_kolone.Add(50);
            velicina_kolone.Add(45);
            
            return new Tuple<List<float>, DataTable>(velicina_kolone, promene);
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
    
        #region uzimanje_svih_studenata_koji_su_diplomirali
        private static Tuple<List<float>, DataTable> Daj_sve_studente_koji_su_diplomirali()
        {

            DataTable studenti = new DataTable();
            var rezultat = Baza.daj_instancu().Daj_sve_diplomirane_studente();

            studenti.Columns.Add("broj indeksa");
            studenti.Columns.Add("ime");
            studenti.Columns.Add("kontakt");
            studenti.Columns.Add("status");


            foreach (var elem in rezultat)
            {
                studenti.Rows.Add(elem["broj_indeksa"], elem["ime"] + " " + elem["prezime"],
                                      elem["email"] + " - " + elem["telefon"], elem["prosek"] + " espb: " + elem["espb"]);
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


     

        public static void Kreiraj_izvestaj_polozenih_ispita_studentu(string lokacija, List<Dictionary<string, string>> rezultat, string naslov)
        {
            Tuple<List<float>, DataTable> podaci = Stampaj_polozene_ispite(rezultat);
            PdfKreator.Daj_pdf_kreatora().Kreiraj(podaci, lokacija, naslov);
            System.Diagnostics.Process.Start(@lokacija);
        }

        public static void Kreiraj_izvestaj_predmeta_na_kojima_predaje_profesor(string lokacija, List<Dictionary<string, string>> rezultat, string naslov)
        {
            Tuple<List<float>, DataTable> podaci = Stampaj_predmete_profesora(rezultat);
            PdfKreator.Daj_pdf_kreatora().Kreiraj(podaci, lokacija, naslov);
            System.Diagnostics.Process.Start(@lokacija);
        }



        public static void Kreiraj_izvestaj_svih_diplomiranih_studenata(string lokacija)
        {
            Tuple<List<float>, DataTable> podaci = Daj_sve_studente_koji_su_diplomirali();
            PdfKreator.Daj_pdf_kreatora().Kreiraj(podaci, lokacija, "Diplomirani studenti");
            System.Diagnostics.Process.Start(@lokacija);
        }

        public static void Kreiraj_izvestaj_svih_promena_na_univerzitetima(string lokacija)
        {
            Tuple<List<float>, DataTable> podaci = Daj_sve_promene_na_univerzitetu();
            PdfKreator.Daj_pdf_kreatora().Kreiraj(podaci, lokacija, "Promene na univerzitetima");
            System.Diagnostics.Process.Start(@lokacija);
        }

        public static void Kreiraj_izvestaj_svih_promena_na_fakultetima(string lokacija)
        {
            Tuple<List<float>, DataTable> podaci = Daj_sve_promene_na_fakultetu();
            PdfKreator.Daj_pdf_kreatora().Kreiraj(podaci, lokacija, "Promene na fakultetima");
            System.Diagnostics.Process.Start(@lokacija);
        } 

        public static void Kreiraj_izvestaj_svih_predmeta(string lokacija)
        {
            Tuple<List<float>, DataTable> podaci = Daj_sve_predmete();
            PdfKreator.Daj_pdf_kreatora().Kreiraj(podaci, lokacija, "Predmeti");
            System.Diagnostics.Process.Start(@lokacija);
        }

    

    }
}

