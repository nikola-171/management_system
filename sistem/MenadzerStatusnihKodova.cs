using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistem
{
    class MenadzerStatusnihKodova
    {
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





    }
}
