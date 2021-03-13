using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistem
{
    class MenadzerStatusnihKodova
    {
        //uspeh
        public static readonly string USPEH = "Uspešno";
        public static readonly string ZAPIS_NIJE_PRONADJEN = "Zapis nije pronađen.";

        // lozinke se ne poklapaju
        public static readonly string NEPOKLAPANJE_LOZINKI_PORUKA = "Lozinke se ne poklapaju.";


        public static readonly string NEPRAVILAN_UNOS = "Nepravilan unos.";

        public static readonly string NEPRAVILAN_UNOS_PORUKA = "Molimo unesite validne vrednosti.";

        //status studenta u bazi, ako je 1 onda je student na budzetu, u suprotnom je samofinansirajući
        public static readonly int STUDENT_STATUS_BUDZET = 1;
        public static readonly int STUDENT_STATUS_SAMOFINANSIRANJE = 0;

        public static readonly string STUDENT_BUDZET_PORUKA = "student je na budžetu";
        public static readonly string STUDENT_SAMOFINANSIRANJE_PORUKA = "student je samofinansirajući";

        //status studenta u bazi, ako je 1 onda je student diplomirao, u suprotnom nije
        public static readonly int STUDENT_DIPLOMIRAO = 1;
        public static readonly int STUDENT_NIJE_DIPLOMIRAO = 0;

        public static readonly string STUDENT_NIJE_DIPLOMIRAO_PORUKA = "nije diplomirao";
        public static readonly string STUDENT_DIPLOMIRAO_PORUKA = "diplomirao";

        //tipovi koje saljemo kao parametre
        public static readonly string INT = "int";
        public static readonly string STRING = "string";

        //poruke prilikom grešaka
        public static readonly string GRESKA = "Greška";
        public static readonly string GRESKA_TEKST = "Došlo je do greške, molimo pokušajte kasnije";

        //poruke vezane sa operacije sa profesorima
        public static readonly string PROFESOR_OBRISAN = "Profesor je uspešno obrisan.";
        public static readonly string REGISTROVAN = "Profesor je uspešno registrovan";
        public static readonly string PROFESOR_NIJE_PRONADJEN = "Profesor sa unetim ID-jem nije pronađen.";

        public static string PROFESOR_REGISTROVAN(int id)
        {
            return string.Format("{0}. Njegov ID je {1}.", MenadzerStatusnihKodova.REGISTROVAN, id.ToString());
        }

        /// poruke vezane za studente
        public static readonly string STUDENT_OBRISAN = "Student je uspešno obrisan.";
        public static readonly string STUDENT_NIJE_PRONADJEN = "Student sa unetim brojem indeksa nije pronađen.";

        public static string STUDENT_REGISTROVAN(int indeks)
        {
            return string.Format("Student je uspešno registrovan. Njegov broj indeksa je {0}.", indeks.ToString());
        }




    }
}
