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
    public partial class FormaDodavanjeProfesoraPredmetu : Form, DodavanjeParametara
    {
        private List<Dictionary<string, string>> departmani_iz_baze = new List<Dictionary<string, string>>();
        private List<Dictionary<string, string>> profesori_iz_baze = new List<Dictionary<string, string>>();


        public FormaDodavanjeProfesoraPredmetu()
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
                var departmani = Baza.daj_instancu().Daj_sve_departmane();

                foreach(var elem in departmani)
                {
                    Dictionary<string, string> red = new Dictionary<string, string>();
                    red.Add("id", elem["id"]);
                    red.Add("fakultet", elem["fakultet"]);
                    red.Add("smer", elem["smer"]);
                    red.Add("univerzitet", elem["univerzitet"]);
                    red.Add("nivo_studija", elem["nivo_studija"]);

                    this.departmani_iz_baze.Add(red);
                }

                

            }catch(Exception exception)
            {
                MessageBox.Show("došlo je do greške " + exception.Message);
            }
        }

        public void Postavi_parametre(List<Tuple<string, string>> parametri)
        {
            throw new NotImplementedException();
        }

        private void dugmeNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjePredmetima>(this, null, true);
        }

        private void FormaDodavanjeProfesoraPredmetu_Load(object sender, EventArgs e)
        {
            Osvezi_sadrzaj();
        }
    }
}
