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
        private static readonly log4net.ILog loger = Logger.GetLogger();

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
            return UInt32.TryParse(idUnos.Text.ToString(), out _);
        }

        public void Osvezi_sadrzaj()
        {
            dugmeUkloniProfesora.Enabled = false;
            panelPrikazRezultata.Visible = false;
            profesorImePrikaz.Text = String.Empty;
            korisnickoImePrikaz.Text = String.Empty;
            telefonPrikaz.Text = String.Empty;
            emailPrikaz.Text = String.Empty;
            idPrikaz.Text = String.Empty;
            datumRodjenjaPrikaz.Text = String.Empty;
            this.id_profesora_za_brisanje = -1;        
        }

        public void Postavi_parametre(List<Tuple<string, string>> parametri)
        {
            throw new NotImplementedException();
        }

        private void dugmePretraga_Click(object sender, EventArgs e)
        {
            // pretraga profesora
            if (!Validacija())
            {
                MessageBox.Show(MenadzerStatusnihKodova.NEPRAVILAN_UNOS_PORUKA, MenadzerStatusnihKodova.NEPRAVILAN_UNOS, 
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Osvezi_sadrzaj();
            try
            {
                var rezultat = Baza.daj_instancu().Daj_informacije_o_profesoru(UInt32.Parse(idUnos.Text.ToString()));
                if(rezultat.Count > 0)
                {          
                    profesorImePrikaz.Text = rezultat["ime"] + " " + rezultat["prezime"];
                    korisnickoImePrikaz.Text = rezultat["korisnicko_ime"];
                    telefonPrikaz.Text = rezultat["telefon"];
                    emailPrikaz.Text = rezultat["email"];

                    jmbgPrikaz.Text = rezultat["jmbg"]; 
                    zvanjePrikaz.Text = rezultat["zvanje"];

                    idPrikaz.Text = rezultat["id"];
                    this.id_profesora_za_brisanje = Convert.ToInt32(rezultat["id"]);
                    datumRodjenjaPrikaz.Text = rezultat["datum_rodjenja"];

                    dugmeUkloniProfesora.Enabled = true;
                    panelPrikazRezultata.Visible = true;
                }
                else
                {
                    MessageBox.Show(MenadzerStatusnihKodova.PROFESOR_NIJE_PRONADJEN, MenadzerStatusnihKodova.ZAPIS_NIJE_PRONADJEN,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch(Exception exception)
            {
                loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormaUpravljanjeProfesorima_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void dugmeNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaPocetnaStrana>(this);
        }

        private void dugmeUkloniProfesora_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Da li ste sigurni da želite da obrišete profesora?", "Potvrda", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                try
                {
                    Baza.daj_instancu().Izbrisi_profesora(this.id_profesora_za_brisanje);
                    Osvezi_sadrzaj();
                    MessageBox.Show(MenadzerStatusnihKodova.PROFESOR_OBRISAN, MenadzerStatusnihKodova.USPEH,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception exception)
                {
                    loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                    MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }  
        }

        private void dugmeDodajStudenta_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaDodavanjeProfesora>(this, null, true);
        }

        private void dugmePredmetiNaKojimaPredaje_Click(object sender, EventArgs e)
        {
            List<Tuple<string, string>> parametri = new List<Tuple<string, string>>();
            parametri.Add(new Tuple<string, string>("id", idPrikaz.Text));
            parametri.Add(new Tuple<string, string>("naslov", string.Format("{0} {1}", profesorImePrikaz.Text, this.id_profesora_za_brisanje)));


            MenadzerFormi.dajFormu<FormaPredmetiNaKojimaPredajeProfesor>(this, parametri, true);
        }
    }
}
