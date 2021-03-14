using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistem.modeli
{
    public class StudentModel
    {
        public int broj_indeksa { get; set; }
        public int status_studenta { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string mesto_boravka { get; set; }
        public string ulica { get; set; }
        public string broj { get; set; }
        public int godina_rodjenja { get; set; }
        public int mesec_rodjenja { get; set; }
        public int dan_rodjenja { get; set; }
        public int espb { get; set; }
        public double prosek { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }
    }
}
