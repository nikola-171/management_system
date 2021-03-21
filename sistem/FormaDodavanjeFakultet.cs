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
    public partial class FormaDodavanjeFakultet : Form, DodavanjeParametara
    {
        private static readonly log4net.ILog loger = Logger.GetLogger();

        private Dictionary<string, int> mapa_id_naziv = new Dictionary<string, int>();
        public FormaDodavanjeFakultet()
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
            return (!nazivUnos.Text.Equals(string.Empty) && !gradUnos.Text.Equals(string.Empty) && !comboUniverziteti.SelectedIndex.Equals(-1));
        }

        public void Osvezi_sadrzaj()
        {

            try
            {
                comboUniverziteti.Items.Clear();
                this.mapa_id_naziv.Clear();
             
                var dd = Baza.daj_instancu().Daj_sve_univerzitete();


                foreach (var elem in dd)
                {
                    mapa_id_naziv.Add(elem["naziv"], Convert.ToInt32(elem["id"]));
                    comboUniverziteti.Items.Add(elem["naziv"]);
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

        private void FormaDodavanjeFakultet_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }


        private void dugmeZaNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeFakultetom>(this, null, true);
        }

        private void dugmeZaProsledi_Click(object sender, EventArgs e)
        {
            //dodavanje fakulteta
            if (!Validacija())
            {
                MessageBox.Show(MenadzerStatusnihKodova.NEPRAVILAN_UNOS_PORUKA, MenadzerStatusnihKodova.NEPRAVILAN_UNOS,
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            try
            {
                Baza.daj_instancu().Dodavanje_fakulteta(nazivUnos.Text, gradUnos.Text, mapa_id_naziv[Convert.ToString(comboUniverziteti.SelectedItem)]);
                MessageBox.Show("uspešno dodat fakultet", MenadzerStatusnihKodova.USPEH, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {
                loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
