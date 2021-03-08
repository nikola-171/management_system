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
    public partial class FormaUpravljanjeProfesorima : Form, DodavanjeParametara
    {
        private int id_profesora_za_brisanje = -1;
        public FormaUpravljanjeProfesorima()
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
            
            return true;
        }

        public void Osvezi_sadrzaj()
        {
            dugmeUkloniProfesora.Enabled = false;
            panelPrikazRezultata.Visible = false;
            profesorImePrikaz.Text = "";
            korisnickoImePrikaz.Text = "";
            telefonPrikaz.Text = "";
            emailPrikaz.Text = "";
            idPrikaz.Text = "";
            datumRodjenjaPrikaz.Text = "";
            this.id_profesora_za_brisanje = -1;
        }

        public void Postavi_parametre(List<Tuple<string, string>> parametri)
        {
            throw new NotImplementedException();
        }

        private void dugmePretraga_Click(object sender, EventArgs e)
        {
            // pretraga profesora
            Osvezi_sadrzaj();
            try
            {
                var rezultat = Baza.daj_instancu().Daj_informacije_o_profesoru(Convert.ToInt32(idUnos.Text));
                if(rezultat.Count > 0)
                {
                 
                    profesorImePrikaz.Text = rezultat["ime"] + " " + rezultat["prezime"];
                    korisnickoImePrikaz.Text = rezultat["korisnicko_ime"];
                    telefonPrikaz.Text = rezultat["telefon"];
                    emailPrikaz.Text = rezultat["email"];
                    idPrikaz.Text = rezultat["id"];
                    this.id_profesora_za_brisanje = Convert.ToInt32(rezultat["id"]);
                    datumRodjenjaPrikaz.Text = rezultat["dan_rodjenja"] + "." + rezultat["mesec_rodjenja"] + "." + rezultat["godina_rodjenja"];
                    dugmeUkloniProfesora.Enabled = true;
                    panelPrikazRezultata.Visible = true;
                }
                else
                {
                    MessageBox.Show("profesor sa unetim id-jem nije pronađen", "nije pronađen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch(Exception exception)
            {
                MessageBox.Show("došlo je do greške " + exception.ToString());
            }
        }

        private void FormaUpravljanjeProfesorima_Load(object sender, EventArgs e)
        {
            Osvezi_sadrzaj();
        }

        private void dugmeNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaPocetnaStrana>(this);
        }

        private void dugmeUkloniProfesora_Click(object sender, EventArgs e)
        {
            try
            {
                Baza.daj_instancu().Izbrisi_profesora(this.id_profesora_za_brisanje);
                Osvezi_sadrzaj();
                MessageBox.Show("profesor je uspešno izbrisan", "obrisan", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {
                MessageBox.Show("došlo je do greške " + exception.ToString());

            }
        }
    }
}
