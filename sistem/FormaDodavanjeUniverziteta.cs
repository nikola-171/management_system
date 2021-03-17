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
    public partial class FormaDodavanjeUniverziteta : Form, DodavanjeParametara
    {
        private static readonly log4net.ILog loger = Logger.GetLogger();

        public FormaDodavanjeUniverziteta()
        {
            InitializeComponent();
        }

        public void Osvezi_sadrzaj()
        {
            throw new NotImplementedException();
        }

        public void Postavi_parametre(List<Tuple<string, string>> parametri)
        {
            throw new NotImplementedException();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Sesija.dajSessiju().Logout_korisnika();
            MenadzerFormi.Zatvori();
        }     

        private void dugmeZaNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeUniverzitetom>(this, null, true);
        }

        private bool Validacija()
        {
            return (!nazivUnos.Text.Equals(string.Empty) && !gradUnos.Text.Equals(string.Empty) && !drzavaUnos.Text.Equals(string.Empty));
        }

        private void dugmeZaProsledi_Click(object sender, EventArgs e)
        {
            if (!Validacija())
            {
                MessageBox.Show(MenadzerStatusnihKodova.NEPRAVILAN_UNOS_PORUKA, MenadzerStatusnihKodova.NEPRAVILAN_UNOS,
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            try
            {
                Baza.daj_instancu().Dodavanje_univerziteta(nazivUnos.Text, drzavaUnos.Text, gradUnos.Text);
                MessageBox.Show("Uspešno registrovan univerzitet", MenadzerStatusnihKodova.USPEH, MessageBoxButtons.OK, MessageBoxIcon.Information);

                MenadzerFormi.dajFormu<FormaUpravljanjeUniverzitetom>(this, null, true);
                
            }
            catch (Exception exception)
            {
                loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
