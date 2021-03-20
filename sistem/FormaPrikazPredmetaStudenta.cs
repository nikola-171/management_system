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
    public partial class FormaPrikazPredmetaStudenta : Form, DodavanjeParametara
    {
        private static readonly log4net.ILog loger = Logger.GetLogger();

        List<Dictionary<string, string>> predmeti = new List<Dictionary<string, string>>();
        UInt32 broj_indeksa = 0;

        public FormaPrikazPredmetaStudenta()
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
            tabelaPrikazPredmeta.Rows.Clear();
            try
            {
                var rezultat = Baza.daj_instancu().Daj_slistu_predmeta_koje_student_slusa(this.broj_indeksa);

                foreach(var elem in rezultat)
                {
                    tabelaPrikazPredmeta.Rows.Add(elem["predmet"], elem["smer"], elem["id"], elem["fakultetska_godina"]);

                }

            }
            catch (Exception exception)
            {
                loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //throw new NotImplementedException();
        }

        public void Postavi_parametre(List<Tuple<string, string>> parametri)
        {
            var broj_indeksa = 
                 from indeks in parametri
                 where indeks.Item1.Equals("broj_indeksa")
                 select indeks.Item2;

            var naziv = from ime in parametri
                        where ime.Item1.Equals("ime")
                        select ime.Item2;

            this.broj_indeksa = Convert.ToUInt32(broj_indeksa.ToList()[0]);
            labelaUnosStudent.Text = naziv.ToList()[0];
        }

        private void FormaPrikazPredmetaStudenta_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void dugmeNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeStudentima>(this, null, false);
        }
    }
}
