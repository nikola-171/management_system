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
    public partial class FormaDodavanjeStudenata : Form, DodavanjeParametara
    {
        private static readonly log4net.ILog loger = Logger.GetLogger();

        private Dictionary<string, int> mapa_vrednosti = new Dictionary<string, int>();
        public FormaDodavanjeStudenata()
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

        private bool ValidacijaLozinki()
        {
            return lozinkaUnos.Text.Equals(lozinkaPonovoUnos.Text);
        }
        private bool Validacija()
        {
            if (imeUnos.Text.Equals(String.Empty) ||
                mestoBoravkaUnos.Text.Equals(String.Empty) ||
                ulicaUnos.Text.Equals(String.Empty) ||
                brojUnos.Text.Equals(String.Empty) ||
                prezimeUnos.Text.Equals(String.Empty) ||
                emailUnos.Text.Equals(String.Empty) ||
                telefonUnos.Text.Equals(String.Empty) ||
             
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

        public void Osvezi_sadrzaj()
        {
            try
            {
                listaDepartmana.Items.Clear();
                listaStatus.Items.Clear();
                mapa_vrednosti.Clear();

                var rezultat = Baza.daj_instancu().Daj_sve_departmane();

                foreach (var elem in rezultat)
                {
                    listaDepartmana.Items.Add(elem["fakultet"] + " - "+ elem["smer"]);
                    mapa_vrednosti.Add(elem["fakultet"] + " - " + elem["smer"], Convert.ToInt32(elem["id"]));
                }
                mapa_vrednosti.Add(MenadzerStatusnihKodova.STUDENT_BUDZET_PORUKA, MenadzerStatusnihKodova.STUDENT_STATUS_BUDZET);
                listaStatus.Items.Add(MenadzerStatusnihKodova.STUDENT_BUDZET_PORUKA);
                mapa_vrednosti.Add(MenadzerStatusnihKodova.STUDENT_SAMOFINANSIRANJE_PORUKA, MenadzerStatusnihKodova.STUDENT_STATUS_SAMOFINANSIRANJE);
                listaStatus.Items.Add(MenadzerStatusnihKodova.STUDENT_SAMOFINANSIRANJE_PORUKA);

                imeUnos.Clear();
                prezimeUnos.Clear();
                mestoBoravkaUnos.Clear();
                ulicaUnos.Clear();
                brojUnos.Clear();
                jmbgUnos.Clear();
                korisnickoImeUnos.Clear();
                lozinkaUnos.Clear();
                lozinkaPonovoUnos.Clear();
                emailUnos.Clear();
                telefonUnos.Clear();


            }
            catch (Exception ee)
            {
                MessageBox.Show("doslo je do greske " + ee.ToString());
            }
        }

        public void Postavi_parametre(List<Tuple<string, string>> parametri)
        {
            Osvezi_sadrzaj();
        }

        private void dugmeNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeStudentima>(this, null, true);
        }

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            //dodavanje studenta
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
                int broj_indeksa = Baza.daj_instancu().Dodaj_studenta(imeUnos.Text, prezimeUnos.Text, emailUnos.Text, telefonUnos.Text, datumRodjenjaUnos.Value.ToString("yyyy-MM-dd").ToString(), mestoBoravkaUnos.Text, ulicaUnos.Text, brojUnos.Text, korisnickoImeUnos.Text,
                                                    lozinkaUnos.Text, Convert.ToInt32(this.mapa_vrednosti[listaDepartmana.SelectedItem.ToString()]),
                                                    Convert.ToInt32(this.mapa_vrednosti[listaStatus.SelectedItem.ToString()]), jmbgUnos.Text);
  
                MessageBox.Show(MenadzerStatusnihKodova.STUDENT_REGISTROVAN(broj_indeksa), MenadzerStatusnihKodova.USPEH,
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

        private void FormaDodavanjeStudenata_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }
    }
}
