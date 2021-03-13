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
        private string naziv = "", drzava = "", grad = "";
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

        private void dugmeIzmeni_Click(object sender, EventArgs e)
        {
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Sesija.dajSessiju().Logout_korisnika();
            MenadzerFormi.Zatvori();
        }

        private void dugmeBrisi_Click(object sender, EventArgs e)
        {
            

        }

        private void dugmeZaNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeUniverzitetom>(this, null, true);
        }

        private void dugmeZaBrisanje_Click(object sender, EventArgs e)
        {
            //brisanje univerziteta
            try
            {
                Baza.daj_instancu().Izbrisi_univerzitet(this.ID);
                MessageBox.Show("Univerzitet uspešno obrisan", "uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MenadzerFormi.dajFormu<FormaUpravljanjeUniverzitetom>(this, null, true);

            }
            catch (Exception exception)
            {
                MessageBox.Show("došlo je do greške prilikom brisanja univerziteta, molimo pokušajte kasnije", "greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void dugmeZaIzmenu_Click(object sender, EventArgs e)
        {
            // sacuvaj izmene na univerzitetu
            try
            {


                Baza.daj_instancu().Sacuvaj_izmene_na_univerzitetu(this.ID, nazivUnos.Text, drzavaUnos.Text, gradUnos.Text);


                MessageBox.Show("Izmene uspešno sačuvane", "uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception exception)
            {
                MessageBox.Show("Nismo uspeli da sačuvamo izmene, molimo pokušajte kasnije", "greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        public void Osvezi_sadrzaj()
        {
            throw new NotImplementedException();
        }
    }
}
