using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistem
{
    public partial class FormaDodavanjeStudentaPredmetu : Form, DodavanjeParametara
    {
        private static readonly log4net.ILog loger = Logger.GetLogger();

        private List<Dictionary<string, string>> studenti_iz_baze = new List<Dictionary<string, string>>();
        private List<Dictionary<string, string>> predmeti_iz_baze = new List<Dictionary<string, string>>();
        
        public FormaDodavanjeStudentaPredmetu()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Sesija.dajSessiju().Logout_korisnika();
            MenadzerFormi.Zatvori();
        }

        public void Osvezi_sadrzaj()
        {
            try
            {
                // uzimanje liste studenata iz baze i nad njima vršiti upite
                listaStudent.Items.Clear();
                var rezultat = Baza.daj_instancu().Daj_sve_studente();

                foreach(var elem in rezultat)
                {
                    Dictionary<string, string> red = new Dictionary<string, string>();
                    red.Add("naziv", elem["broj_indeksa"] + "-" + elem["ime"] + " " + elem["prezime"]);
                    red.Add("ime", elem["ime"]);
                    red.Add("prezime", elem["prezime"]);
                    red.Add("broj_indeksa", elem["broj_indeksa"]);
                    red.Add("fakultet", elem["fakultet"]);
                    red.Add("departman", elem["departman"]);

                    this.studenti_iz_baze.Add(red);
                    listaStudent.Items.Add(elem["broj_indeksa"] + "-" + elem["ime"] + " " + elem["prezime"]);
                }

                //uzimanje liste predmeta iz baze i nad njima vršiti upite
                listaPredmet.Items.Clear();
                rezultat = Baza.daj_instancu().Daj_sve_predmete();

                foreach(var elem in rezultat)
                {
                    Dictionary<string, string> red = new Dictionary<string, string>();
                    red.Add("id", elem["id"]);
                    red.Add("departman", elem["departman"]);
                    red.Add("naziv", elem["naziv"]);
                    red.Add("espb", elem["espb"]);
                    red.Add("godina", elem["godina"]);
                    red.Add("semestar", elem["semestar"]);

                    listaPredmet.Items.Add(elem["naziv"]);
                    this.predmeti_iz_baze.Add(red);

                }
            }
            catch(Exception exception)
            {
                MessageBox.Show("doslo je do greske " + exception.Message);
            }
        }

        public void Postavi_parametre(List<Tuple<string, string>> parametri)
        {
            
        }

        private void dugmeNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjePredmetima>(this, null, true);
        }

        private void Ocisti_predmet_unos()
        {
            predmetNazivUnos.Text = predmetNazivUnos.Text.Trim(' ');
            predmetDepartmanUnos.Text = predmetDepartmanUnos.Text.Trim(' ');
        }

        private void Ocisti_student_unos()
        {
            studentBrojIndeksaUnos.Text = studentBrojIndeksaUnos.Text.Trim(' ');
            studentDepartmanUnos.Text = studentDepartmanUnos.Text.Trim(' ');
            studentImeUnos.Text = studentImeUnos.Text.Trim(' ');
            studentPrezimeUnos.Text = studentPrezimeUnos.Text.Trim(' ');
        }

        private void dugmePretragaPredmet_Click(object sender, EventArgs e)
        {
            Ocisti_predmet_unos();

            listaPredmet.Items.Clear();
            var rezultat = from predmet in this.predmeti_iz_baze
                           where predmet["naziv"].Contains(predmetNazivUnos.Text) &&
                                 predmet["departman"].Contains(predmetDepartmanUnos.Text)
                           select predmet;

            foreach(var elem in rezultat)
            {
                listaPredmet.Items.Add(elem["naziv"]);
            }
        }

        private bool Validacija()
        {
            return (!listaPredmet.SelectedIndex.Equals(-1) &&
                    !listaStudent.SelectedIndex.Equals(-1));
        }

        private void dugmePretragaStudenta_Click(object sender, EventArgs e)
        {
            Ocisti_student_unos();
            listaStudent.Items.Clear();

            IEnumerable<Dictionary<string, string>> rezultat = null;

            if(studentBrojIndeksaUnos.Text != "")
            {
                rezultat = from student in this.studenti_iz_baze
                               where student["broj_indeksa"] == studentBrojIndeksaUnos.Text &&
                                     student["ime"].Contains(studentImeUnos.Text) &&
                                     student["prezime"].Contains(studentPrezimeUnos.Text) &&
                                     student["departman"].Contains(studentDepartmanUnos.Text)
                               select student;
            }
            else
            {
                rezultat = from student in this.studenti_iz_baze
                           where student["ime"].Contains(studentImeUnos.Text) &&
                                 student["prezime"].Contains(studentPrezimeUnos.Text) &&
                                 student["departman"].Contains(studentDepartmanUnos.Text)
                           select student;
            }

            foreach(var elem in rezultat)
            {
                listaStudent.Items.Add(elem["broj_indeksa"] + "-" + elem["ime"] + " " + elem["prezime"]);
            }
        }

        private void dugmeDodajPredmet_Click(object sender, EventArgs e)
        {
            // dodavanje studenta predmetu
            if (!Validacija())
            {
                MessageBox.Show(MenadzerStatusnihKodova.NEPRAVILAN_UNOS_PORUKA, MenadzerStatusnihKodova.NEPRAVILAN_UNOS,
                               MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            try
            {            
                var broj_indeksa = from student in this.studenti_iz_baze
                                   where student["naziv"] == listaStudent.SelectedItem.ToString()
                                   select student["broj_indeksa"];

                var predmet_id = from predmet in this.predmeti_iz_baze
                                 where predmet["naziv"] == listaPredmet.SelectedItem.ToString()
                                 select predmet["id"];
                
                string status = Baza.daj_instancu().Dodeli_studenta_predmetu(Convert.ToUInt32(broj_indeksa.ToList()[0]), Convert.ToUInt32(predmet_id.ToList()[0]));

                MessageBox.Show(status, MenadzerStatusnihKodova.USPEH, MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception exception)
            {
                loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormaDodavanjeStudentaPredmetu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }
    }
}
