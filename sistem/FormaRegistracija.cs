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
    public partial class FormaRegistracija : Form
    {
        public FormaRegistracija()
        {
            InitializeComponent();
        }

        private void dugme_nazad_Click(object sender, EventArgs e)
        {
            FormaLogovanje logovanje = new FormaLogovanje();
            this.Hide();
            logovanje.ShowDialog();
            this.Close();
        }

        private void dugme_registracija_Click(object sender, EventArgs e)
        {
            if(ime_unos.Text.Trim().Equals("") || prezime_unos.Text.Trim().Equals("") ||
               korisnicko_ime_unos.Text.Trim().Equals("") || lozinka_unos.Text.Trim().Equals("") ||
               lozinka_ponovo_unos.Text.Trim().Equals("") || email_unos.Text.Trim().Equals("") ||
               telefon_unos.Text.Trim().Equals(""))
            {
                MessageBox.Show("prazna polja nisu dozvoljena", "Prazno polje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!lozinka_unos.Text.Trim().Equals(lozinka_ponovo_unos.Text.Trim()))
                {
                    MessageBox.Show("Lozinke se ne poklapaju", "Lozinka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        int status = Baza.daj_instancu().Registracija_korisnika(korisnicko_ime_unos.Text.Trim(), lozinka_unos.Text.Trim(),
                                                                    email_unos.Text.Trim(), telefon_unos.Text.Trim());
                        korisnicko_ime_unos.Text = "";
                        lozinka_unos.Text = "";
                        ime_unos.Text = "";
                        prezime_unos.Text = "";
                        email_unos.Text = "";
                        telefon_unos.Text = "";
                        lozinka_ponovo_unos.Text = "";

                        if (status.Equals(0))
                        {
                            MessageBox.Show("uspešno ste se registrovali", "registracija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if(status.Equals(1))
                        {
                            MessageBox.Show("administrator je već registrovan", "registracija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Nismo uspeli da uspostavimo konekciju ka serveru, molimo pokušajte kasnije. ", "registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Nismo uspeli da uspostavimo konekciju ka serveru, molimo pokušajte kasnije." , "Neuspešno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
          
        }
    }
}
