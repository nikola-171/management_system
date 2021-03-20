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
        private static readonly log4net.ILog loger = Logger.GetLogger();
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
            catch (Exception exception)
            {
                loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool Validacija()
        {
            return (!naziv_departmana_unos.Text.Equals(string.Empty) && !trajanje_unos.Text.Equals(string.Empty) && 
                    !espb_unos.Text.Equals(string.Empty) && !listaNivoaStudija.SelectedIndex.Equals(-1) &&
                    !listaFakulteta.SelectedIndex.Equals(-1) && int.TryParse(espb_unos.Text, out _) &&
                    int.TryParse(trajanje_unos.Text, out _));
        }
        
        private void dugmeDodajDepartman_Click_1(object sender, EventArgs e)
        {
            // upisivanje departmana 
            if (!Validacija())
            {
                MessageBox.Show(MenadzerStatusnihKodova.NEPRAVILAN_UNOS_PORUKA, MenadzerStatusnihKodova.NEPRAVILAN_UNOS,
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            try
            {
                Baza.daj_instancu().Dodaj_departman(this.mapa_fakulteta[Convert.ToString(listaFakulteta.SelectedItem)], naziv_departmana_unos.Text,
                                                    trajanje_unos.Text, espb_unos.Text, Convert.ToString(listaNivoaStudija.SelectedItem));
                MessageBox.Show("uspešno registrovan departman", MenadzerStatusnihKodova.USPEH,
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {
                loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormaDodavanjeDepartmana_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
