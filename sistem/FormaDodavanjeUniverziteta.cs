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

        private void dugmeNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeUniverzitetom>(this, null, true);
        }

        private void dugmeProsledi_Click(object sender, EventArgs e)
        {
            try
            {
                Baza.daj_instancu().Dodavanje_univerziteta(nazivUnos.Text, drzavaUnos.Text, gradUnos.Text);
                MessageBox.Show("Uspešno registrovan univerzitet", "uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MenadzerFormi.dajFormu<FormaUpravljanjeUniverzitetom>(this,null,true);
;            }catch(Exception excpetion)
            {
                MessageBox.Show("greška", "greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
