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
    public partial class FormaDodavanjeDepartmana : Form, DodavanjeParametara
    {
        // mapa naziv - id svih fakulteta
        private Dictionary<string, int> mapa_fakulteta = new Dictionary<string, int>();

        public FormaDodavanjeDepartmana()
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
            try
            {
                listaFakulteta.Items.Clear();
                this.mapa_fakulteta.Clear();

                var rezultat = Baza.daj_instancu().Daj_sve_fakultete();


                foreach (var elem in rezultat)
                {
                    listaFakulteta.Items.Add(elem["naziv"]);
                    this.mapa_fakulteta.Add(elem["naziv"], Convert.ToInt32(elem["id"])); 
                }


            }
            catch (Exception ee)
            {
                MessageBox.Show("doslo je do greske " + ee.ToString());
            }   

        }

        public void Postavi_parametre(List<Tuple<string, string>> parametri)
        {
            throw new NotImplementedException();
        }

        private void dugmeNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeDepartmana>(this, null, true);
        }

        private void dugmeDodajDepartman_Click(object sender, EventArgs e)
        {
            // upisivanje departmana 
            try
            {
                Baza.daj_instancu().Dodaj_departman(this.mapa_fakulteta[Convert.ToString(listaFakulteta.SelectedItem)], naziv_departmana_unos.Text,
                                                    trajanje_unos.Text, espb_unos.Text, Convert.ToString(listaNivoaStudija.SelectedItem));
                MessageBox.Show("uspešno registrovan departman", "uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception excpetion)
            {
                MessageBox.Show("došlo je do greške " + excpetion.ToString(),"greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
