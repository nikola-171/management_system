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
    public partial class FormaRegistracija : Form, DodavanjeParametara
    {
        private static readonly log4net.ILog loger = Logger.GetLogger();

        public FormaRegistracija()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            MenadzerFormi.Zatvori();
        }

        private void dugme_nazad_Click(object sender, EventArgs e)
        {
             MenadzerFormi.dajFormu<FormaLogovanje>(this);   
        }

        private void Zakljucaj_polja(bool zakljucaj)
        {
            if (zakljucaj)
            {
                ucitavanje_poruka.Text = "učitavanje, molimo sačekajte...";
            }
            else
            {
                ucitavanje_poruka.Text = "";
            }
            this.UseWaitCursor = zakljucaj;
            dugme_nazad.Enabled = zakljucaj;
            dugme_registracija.Enabled = zakljucaj;
            ime_unos.Enabled = zakljucaj;
            prezime_unos.Enabled = zakljucaj;
            korisnicko_ime_unos.Enabled = zakljucaj;
            lozinka_unos.Enabled = zakljucaj;
            lozinka_ponovo_unos.Enabled = zakljucaj;
            email_unos.Enabled = zakljucaj;
            telefon_unos.Enabled = zakljucaj;
        }

        private void dugme_registracija_Click(object sender, EventArgs e)
        {
            if(ime_unos.Text.Trim().Equals("") || prezime_unos.Text.Trim().Equals("") ||
               korisnicko_ime_unos.Text.Trim().Equals("") || lozinka_unos.Text.Trim().Equals("") ||
               lozinka_ponovo_unos.Text.Trim().Equals("") || email_unos.Text.Trim().Equals("") ||
               telefon_unos.Text.Trim().Equals(""))
            {
                MessageBox.Show(MenadzerStatusnihKodova.NEPRAVILAN_UNOS_PORUKA, MenadzerStatusnihKodova.NEPRAVILAN_UNOS, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!lozinka_unos.Text.Trim().Equals(lozinka_ponovo_unos.Text.Trim()))
                {
                    MessageBox.Show(MenadzerStatusnihKodova.NEPOKLAPANJE_LOZINKI_PORUKA, MenadzerStatusnihKodova.NEPRAVILAN_UNOS, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    this.UseWaitCursor = true;
                    ucitavanje_poruka.Text = "Učitavanje, molimo sačekajte...";
                    dugme_nazad.Enabled = false;
                    dugme_registracija.Enabled = false;
                    ime_unos.Enabled = false;
                    prezime_unos.Enabled = false;
                    korisnicko_ime_unos.Enabled = false;
                    lozinka_unos.Enabled = false;
                    lozinka_ponovo_unos.Enabled = false;
                    email_unos.Enabled = false;
                    telefon_unos.Enabled = false;

                    try
                    {
                        int status = Baza.daj_instancu().Registracija_korisnika(korisnicko_ime_unos.Text.Trim(), lozinka_unos.Text.Trim(),
                                                                    email_unos.Text.Trim(), telefon_unos.Text.Trim(), ime_unos.Text.Trim(), prezime_unos.Text.Trim());
                        

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
                            MessageBox.Show("Nismo uspeli da uspostavimo konekciju ka serveru, molimo pokušajte kasnije." , "registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }             
                    }
                    catch (Exception exception)
                    {
                        loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                        MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        korisnicko_ime_unos.Text = string.Empty;
                        lozinka_unos.Text = string.Empty;
                        ime_unos.Text = string.Empty;
                        prezime_unos.Text = string.Empty;
                        email_unos.Text = string.Empty;
                        telefon_unos.Text = string.Empty;
                        lozinka_ponovo_unos.Text = string.Empty;

                       

                        this.UseWaitCursor = false;
                        ucitavanje_poruka.Text = string.Empty;
                        dugme_nazad.Enabled = true;
                        dugme_registracija.Enabled = true;
                        ime_unos.Enabled = true;
                        prezime_unos.Enabled = true;
                        korisnicko_ime_unos.Enabled = true;
                        lozinka_unos.Enabled = true;
                        lozinka_ponovo_unos.Enabled = true;
                        email_unos.Enabled = true;
                        telefon_unos.Enabled = true;
                    }
                }
            }
          
        }

        public void Postavi_parametre(List<Tuple<string, string>> parametri)
        {
            throw new NotImplementedException();
        }

        public void Osvezi_sadrzaj()
        {
            throw new NotImplementedException();
        }

      
    }
}
