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
    public partial class FormaUpravljanjePredmetima : Form, DodavanjeParametara
    {
        private List<Dictionary<string, string>> departmani_iz_baze = new List<Dictionary<string, string>>();
      

        public FormaUpravljanjePredmetima()
        {
            InitializeComponent();
        }

        public void Osvezi_sadrzaj()
        {
            this.departmani_iz_baze.Clear();
            listaDepartmana.Items.Clear();

            nazivUnos.Text = "";
            godinaUnos.Text = "";
            semestarUnos.Text = "";
            espbUnos.Text = "";


            try
            {
                var rezultat = Baza.daj_instancu().Daj_sve_departmane();

                foreach(var elem in rezultat)
                {
                    Dictionary<string, string> red = new Dictionary<string, string>();
                    red.Add("id", elem["id"]);
                    red.Add("fakultet", elem["fakultet"]);
                    red.Add("smer", elem["smer"]);
                    red.Add("univerzitet", elem["univerzitet"]);
                    red.Add("nivo_studija", elem["nivo_studija"]);

                    listaDepartmana.Items.Add(elem["smer"]);

                    this.departmani_iz_baze.Add(red);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("došlo je do greške " + exception.Message);
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
            MenadzerFormi.dajFormu<FormaPocetnaStrana>(this);
        }

        private bool validacija()
        {
            return true;
        }

        private void dugmeDodajPredmet_Click(object sender, EventArgs e)
        {

            try
            {
                UInt32 id_departmana = 0;
                foreach(var elem in departmani_iz_baze)
                {
                    if(elem["smer"] == Convert.ToString(listaDepartmana.SelectedItem))
                    {
                        id_departmana = Convert.ToUInt32(elem["id"]);
                        break;
                    }
                }

                Baza.daj_instancu().Dodavanje_predmeta(nazivUnos.Text, Convert.ToSByte(godinaUnos.Text), Convert.ToSByte(semestarUnos.Text), Convert.ToSByte(espbUnos.Text), Convert.ToUInt32(id_departmana));
                MessageBox.Show("uspešno registrovan predmet", "uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }catch(Exception exception)
            {
                MessageBox.Show("došlo je do greške " + exception.ToString());
            }
            finally
            {
                Osvezi_sadrzaj();
            }
        }

        private void dugmeDodajPredmetProfesoru_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaDodavanjeProfesoraPredmetu>(this);
        }

        private void FormaUpravljanjePredmetima_Load(object sender, EventArgs e)
        {
            //uzmem sve departmane pa posle
            Osvezi_sadrzaj();


        }

        private void dugmePretraga_Click(object sender, EventArgs e)
        {
            //pretraga departmana, ukoliko je bez parametara onda vraćam sve departmane
            listaDepartmana.Items.Clear();
            univerzitetUnos.Text = univerzitetUnos.Text.Trim(' ');
            fakultetUnos.Text = fakultetUnos.Text.Trim(' ');
            departmanUnos.Text = departmanUnos.Text.Trim(' ');


            foreach (var elem in this.departmani_iz_baze)
            {

                bool ispunjava_uslov = true;

                if(univerzitetUnos.Text != "")
                {
                    if (!elem["univerzitet"].Contains(univerzitetUnos.Text))
                    {
                        ispunjava_uslov = false;
                    }
                }

                if (fakultetUnos.Text != "")
                {
                    if (!elem["fakultet"].Contains(fakultetUnos.Text))
                    {
                        ispunjava_uslov = false;
                    }
                }

                if (departmanUnos.Text != "")
                {
                    if (!elem["smer"].Contains(departmanUnos.Text))
                    {
                        ispunjava_uslov = false;
                    }
                }

                if (ispunjava_uslov)
                {
                    listaDepartmana.Items.Add(elem["smer"]);
                }
            }
        }
    }
}
