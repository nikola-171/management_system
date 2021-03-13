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
    public partial class FormaDodavanjeProfesora : Form, DodavanjeParametara
    {
        private static readonly log4net.ILog loger = Logger.GetLogger();

        public FormaDodavanjeProfesora()
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
            /// praznimo sva polja
            imeUnos.Clear();
            prezimeUnos.Clear();
            emailUnos.Clear();
            telefonUnos.Clear();
            danUnos.Clear();
            mesecUnos.Clear();
            godinaUnos.Clear();
            korisnickoImeUnos.Clear();
            lozinkaUnos.Clear();
            lozinkaPonovoUnos.Clear();
        }

        private bool ValidacijaLozinki()
        {
            return lozinkaUnos.Text.Equals(lozinkaPonovoUnos.Text);
        }

        private bool Validacija()
        {
            if (imeUnos.Text.Equals(String.Empty) ||
                prezimeUnos.Text.Equals(String.Empty) ||
                emailUnos.Text.Equals(String.Empty) ||
                telefonUnos.Text.Equals(String.Empty) ||
                !Int16.TryParse(godinaUnos.Text, out _) ||
                !SByte.TryParse(mesecUnos.Text, out _) ||
                !SByte.TryParse(danUnos.Text, out _) ||
                korisnickoImeUnos.Text.Equals(String.Empty) ||
                lozinkaUnos.Text.Equals(String.Empty) ||
                lozinkaPonovoUnos.Text.Equals(String.Empty) ||
                emailUnos.Text.Length < 8 ||
                emailUnos.Text.IndexOf('@').Equals(-1) ||
                emailUnos.Text.IndexOf('.').Equals(-1) ||
                (emailUnos.Text.LastIndexOf('.') < emailUnos.Text.IndexOf('@')))
            {
                return false;
            }
            return true;
        }

        public void Postavi_parametre(List<Tuple<string, string>> parametri)
        {
            throw new NotImplementedException();
        }

        private void dugmeNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeProfesorima>(this, null, true);
        }

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidacijaLozinki())
            {
                MessageBox.Show(MenadzerStatusnihKodova.NEPOKLAPANJE_LOZINKI_PORUKA, MenadzerStatusnihKodova.NEPRAVILAN_UNOS,
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (!Validacija())
            {
                MessageBox.Show(MenadzerStatusnihKodova.NEPRAVILAN_UNOS_PORUKA, MenadzerStatusnihKodova.NEPRAVILAN_UNOS,
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            try
            {
                int id_profesora = Baza.daj_instancu().Dodaj_profesora(imeUnos.Text, prezimeUnos.Text, emailUnos.Text, telefonUnos.Text,
                                                    Convert.ToSByte(danUnos.Text), Convert.ToSByte(mesecUnos.Text),
                                                    Convert.ToInt16(godinaUnos.Text),
                                                    korisnickoImeUnos.Text, lozinkaUnos.Text);
                

                MessageBox.Show(MenadzerStatusnihKodova.PROFESOR_REGISTROVAN(id_profesora), MenadzerStatusnihKodova.USPEH,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {
                loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Osvezi_sadrzaj();
            }
        }
    }
}
