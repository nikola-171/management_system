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
    public partial class FormaIzmenaFakultet : Form, DodavanjeParametara
    {
        private static readonly log4net.ILog loger = Logger.GetLogger();
        private string naziv = "", mesto = "";
        private int ID = -1;

        public FormaIzmenaFakultet()
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
            throw new NotImplementedException();
        }

        private void dugmeNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeFakultetom>(this,null,true);
        }

        private void dugmeBrisi_Click(object sender, EventArgs e)
        {
           

        }

        private void dugmeIzmeni_Click(object sender, EventArgs e)
        {
            

        }

        private void dugmeZaNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeFakultetom>(this, null, true);

        }


        private bool validacija()
        {
            return (!nazivUnos.Text.Trim(' ').Equals(string.Empty) &&
                    !mestoUnos.Text.Trim(' ').Equals(string.Empty));
        }

        private void dugmeZaIzmenu_Click(object sender, EventArgs e)
        {
            //izmena fakulteta
            if (!validacija())
            {
                MessageBox.Show(MenadzerStatusnihKodova.NEPRAVILAN_UNOS_PORUKA, MenadzerStatusnihKodova.NEPRAVILAN_UNOS,
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            try
            {
                Baza.daj_instancu().Izmeni_fakultet(this.ID, nazivUnos.Text, mestoUnos.Text);
                MessageBox.Show("Uspešno izmenjen fakultet ", "uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception excpetion)
            {
                MessageBox.Show("došlo je do greške " + excpetion.ToString());
            }
        }

        private void dugmeZaBrisanje_Click(object sender, EventArgs e)
        {
            //brisanje fakulteta
            DialogResult res = MessageBox.Show("Da li ste sigurni da želite da obrišete fakultet?", "Potvrda", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(res == DialogResult.OK)
            {
                try
                {
                    Baza.daj_instancu().Izbrisi_fakultet(this.ID);
                    MessageBox.Show("Uspešno izbrisan fakultet", MenadzerStatusnihKodova.USPEH, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MenadzerFormi.dajFormu<FormaUpravljanjeFakultetom>(this, null, true);
                }
                catch (Exception exception)
                {
                    loger.Error(MenadzerStatusnihKodova.GRESKA, exception);
                    MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
        }

        private void FormaIzmenaFakultet_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        public void Postavi_parametre(List<Tuple<string, string>> parametri)
        {
            foreach (var parametar in parametri)
            {
                if (parametar.Item1.Equals("ID"))
                {
                    this.ID = Convert.ToInt32(parametar.Item2);
                }
                else if (parametar.Item1.Equals("naziv"))
                {
                    this.naziv = parametar.Item2;
                }
                else if (parametar.Item1.Equals("mesto"))
                {
                    this.mesto = parametar.Item2;
                }
                
            }
            nazivUnos.Text = this.naziv;
            mestoUnos.Text = this.mesto;
            
        }
    }
}
