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
    public partial class FormaPolozeniPredmetiStudenta : Form, DodavanjeParametara
    {
        private static readonly log4net.ILog loger = Logger.GetLogger();

        private UInt32 broj_indeksa = 0;
        public FormaPolozeniPredmetiStudenta()
        {
            InitializeComponent();
        }

        public void Osvezi_sadrzaj()
        {
            tabelaPolozeniPredmeti.Rows.Clear();

            try
            {
                var rezultat = Baza.daj_instancu().Daj_listu_polozenih_ispita(this.broj_indeksa);
                foreach(var elem in rezultat)
                {
                    tabelaPolozeniPredmeti.Rows.Add(elem["predmet"], elem["datum"], elem["ocena"], elem["fakultetska_godina"]);
                }
            }
            catch (Exception exception)
            {
                loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Postavi_parametre(List<Tuple<string, string>> parametri)
        {
            var indeks_priv = from indeks in parametri
                              where indeks.Item1.Equals("broj_indeksa")
                              select indeks.Item2;
            this.broj_indeksa = Convert.ToUInt32(indeks_priv.ToList()[0]);
            var ime_priv = from ime in parametri
                           where ime.Item1.Equals("ime")
                           select ime.Item2;
            labelaUnosStudent.Text = ime_priv.ToList()[0];
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Sesija.dajSessiju().Logout_korisnika();
            MenadzerFormi.Zatvori();
        }

        private void dugmeNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeStudentima>(this, null, false);
        }

        private void FormaPolozeniPredmetiStudenta_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
