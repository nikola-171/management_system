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

        private bool Validacija()
        {
            if(imeUnos.Text.Trim().Length == 0 || prezimeUnos.Text.Trim().Length == 0)
            {
                MessageBox.Show("prazna polja nisu dozvoljena", "prazna polja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                imeUnos.Text = "";
                prezimeUnos.Text = "";
                mestoBoravkaUnos.Text = "";
                ulicaUnos.Text = "";
                brojUnos.Text = "";
                godinaUnos.Text = "";
                mesecUnos.Text = "";
                danUnos.Text = "";
                korisnickoImeUnos.Text = "";
                lozinkaUnos.Text = "";
                lozinkaPonovoUnos.Text = "";
                emailUnos.Text = "";
                telefonUnos.Text = "";


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
            if (Validacija())
            {
                try
                {
                    Baza.daj_instancu().Dodaj_studenta(imeUnos.Text, prezimeUnos.Text, emailUnos.Text, telefonUnos.Text, Convert.ToInt32(danUnos.Text), Convert.ToInt32(mesecUnos.Text),
                                                        Convert.ToInt32(godinaUnos.Text), mestoBoravkaUnos.Text, ulicaUnos.Text, brojUnos.Text, korisnickoImeUnos.Text,
                                                        lozinkaUnos.Text, Convert.ToInt32(this.mapa_vrednosti[listaDepartmana.SelectedItem.ToString()]),
                                                        Convert.ToInt32(this.mapa_vrednosti[listaStatus.SelectedItem.ToString()]));
                    MessageBox.Show("uspešno registrovan student", "uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("došlo je do greške " + exception.ToString());
                }
                finally
                {
                    Osvezi_sadrzaj();
                }
            }
        }
    }
}
