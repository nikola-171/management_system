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
    public partial class FormaUpravljanjeDepartmana : Form, DodavanjeParametara
    {
        public FormaUpravljanjeDepartmana()
        {
            InitializeComponent();
        }

        public void Osvezi_sadrzaj()
        {
            try
            {
                tabelaPrikazDepartmana.Rows.Clear();
                var dd = Baza.daj_instancu().Daj_sve_departmane();


                foreach (var elem in dd)
                {

                   
                    tabelaPrikazDepartmana.Rows.Add(elem["id"], elem["univerzitet"], elem["fakultet"], elem["smer"], elem["nivo_studija"], "izmeni");
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Sesija.dajSessiju().Logout_korisnika();
            MenadzerFormi.Zatvori();
        }

        private void dugmeNazad_Click(object sender, EventArgs e)
        {
            //staroo
            MenadzerFormi.dajFormu<FormaPocetnaStrana>(this);
        }

        private void dugmeNazad_Click_1(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaPocetnaStrana>(this);
        }

        private void FormaUpravljanjeDepartmana_Load(object sender, EventArgs e)
        {
            Osvezi_sadrzaj();
        }
    }
}
