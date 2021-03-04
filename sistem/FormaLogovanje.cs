using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace sistem
{
    public partial class FormaLogovanje : Form
    {
        public FormaLogovanje()
        {
            InitializeComponent();
        }

        private void dugme_logovanje_Click(object sender, EventArgs e)
        {
            if (korisnicko_ime_unos.Text.Trim().Equals("") || lozinka_unos.Text.Trim().Equals(""))
            {
                MessageBox.Show("Prazna polja nisu dozvoljena", "Prazno polje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                korisnicko_ime_unos.Text = "";
                lozinka_unos.Text = "";
            }
            else
            {

                /*provera da li korisnik postoji u bazi*/
                korisnicko_ime_unos.Enabled = false;
                lozinka_unos.Enabled = false;
                dugme_logovanje.Enabled = false;
                dugme_registracija.Enabled = false;
                labelaUcitavanje.Text = "učitavanje, molimo sačekajte";

                try
                {
                    Baza b = Baza.daj_instancu();

                    bool status = b.Validacija_korisnika(korisnicko_ime_unos.Text.Trim(), lozinka_unos.Text.Trim());
                    if (status)
                    {
                        /*stavljamo korisnika u sesiji*/
                        
                        //OVDE GRESKAAA
                        
                        Sesija.dajSessiju().Registruj_korisnika(korisnicko_ime_unos.Text.Trim());
                        korisnicko_ime_unos.Text = "";
                        lozinka_unos.Text = "";
                        MenadzerFormi.dajFormu<FormaPocetnaStrana>(this);

                    }
                    else
                    {
                        MessageBox.Show("korisničko ime ili lozinka nisu ispravni", "neuspešno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Nismo uspeli da uspostavimo konekciju ka serveru, molimo pokušajte kasnije." + exception.ToString(), "Neuspešno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    korisnicko_ime_unos.Enabled = true;
                    korisnicko_ime_unos.Text = "";
                    lozinka_unos.Enabled = true;
                    lozinka_unos.Text = "";
                    dugme_logovanje.Enabled = true;
                    dugme_registracija.Enabled = true;
                    labelaUcitavanje.Text = "";
                }
                       
            }
        }

        private void dugme_registracija_Click(object sender, EventArgs e)
        {
             MenadzerFormi.dajFormu<FormaRegistracija>(this);       
        }

        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            
            MenadzerFormi.Zatvori();      
        }

        
    }
}
