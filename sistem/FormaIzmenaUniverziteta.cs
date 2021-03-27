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
    public partial class FormaIzmenaUniverziteta : Form, DodavanjeParametara
    {
        private static readonly log4net.ILog loger = Logger.GetLogger();
        private string naziv = string.Empty, drzava = string.Empty, grad = string.Empty;
        private int ID = -1;
        
        public FormaIzmenaUniverziteta()
        {
            InitializeComponent();
        }

        public void Postavi_parametre(List<Tuple<string, string>> parametri)
        {
            foreach(var parametar in parametri)
            {
                if (parametar.Item1.Equals("ID"))
                {
                    this.ID = Convert.ToInt32(parametar.Item2);
                }
                else if (parametar.Item1.Equals("naziv"))
                {
                    this.naziv = parametar.Item2;
                }
                else if (parametar.Item1.Equals("drzava"))
                {
                    this.drzava = parametar.Item2;
                }
                else if (parametar.Item1.Equals("grad"))
                {
                    this.grad = parametar.Item2;
                }
            }
            nazivUnos.Text = this.naziv;
            drzavaUnos.Text = this.drzava;
            gradUnos.Text = this.grad;
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

        private void dugmeZaBrisanje_Click(object sender, EventArgs e)
        {
            //brisanje univerziteta
            DialogResult res = MessageBox.Show("Da li ste sigurni da želite da obrišete univerzitet?", "Potvrda", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res.Equals(DialogResult.OK))
            {
                try
                {
                    Baza.daj_instancu().Izbrisi_univerzitet(this.ID);
                    MessageBox.Show("Univerzitet uspešno obrisan", MenadzerStatusnihKodova.USPEH, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MenadzerFormi.dajFormu<FormaUpravljanjeUniverzitetom>(this, null, true);

                }
                catch (Exception exception)
                {
                    loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                    MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }  
        }

        private void FormaIzmenaUniverziteta_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private bool validacija()
        {
            return (!nazivUnos.Text.Trim(' ').Equals(string.Empty) && 
                    !drzavaUnos.Text.Trim(' ').Equals(string.Empty) &&
                    !gradUnos.Text.Trim(' ').Equals(string.Empty));
        }

        private void dugmeZaIzmenu_Click(object sender, EventArgs e)
        {
            // sacuvaj izmene na univerzitetu
            if (!validacija())
            {
                MessageBox.Show(MenadzerStatusnihKodova.NEPRAVILAN_UNOS_PORUKA, MenadzerStatusnihKodova.NEPRAVILAN_UNOS,
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            try
            {

                Baza.daj_instancu().Sacuvaj_izmene_na_univerzitetu(this.ID, nazivUnos.Text, drzavaUnos.Text, gradUnos.Text);

                MessageBox.Show("Izmene uspešno sačuvane", MenadzerStatusnihKodova.USPEH, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {
                loger.Error(MenadzerStatusnihKodova.GRESKA, exception);
                MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        public void Osvezi_sadrzaj()
        {
            throw new NotImplementedException();
        }
    }
}
