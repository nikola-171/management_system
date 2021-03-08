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
    public partial class FormaPocetnaStrana : Form, DodavanjeParametara
    {
        public FormaPocetnaStrana()
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

        private void FormaPocetnaStrana_Load(object sender, EventArgs e)
        {
            /*ucitavanje sadrzaja*/
            //BOLJE RUKOVANJE GREŠKAMA
            try
            {
                var rezultat =  Baza.daj_instancu().Daj_podatke_o_adminu(Sesija.dajSessiju().Daj_admina());
                labelaEmailPrikaz.Text = rezultat["email"];
                labelaTelefonPrikaz.Text = rezultat["telefon"];
                labelaImePrikaz.Text = rezultat["ime"] + " " + rezultat["prezime"];

            }catch(Exception exception)
            {
                MessageBox.Show("doslo je do greske " + exception.ToString());
            }
           
        }

      

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            /*logout*/
            Sesija.dajSessiju().Logout_korisnika();
            MenadzerFormi.dajFormu<FormaLogovanje>(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
                 
        }

        private void dugmeUniverzitet_Click(object sender, EventArgs e)
        {
            //prikaz forme za upravljanje univerzitetima
            //korisnik mora da bude ulogovan
            if (!Sesija.dajSessiju().Provera_validnosti())
            {
                MenadzerFormi.dajFormu<FormaLogovanje>(this);
            }
            else
            {
                // korisnik je ulogovan
                MenadzerFormi.dajFormu<FormaUpravljanjeUniverzitetom>(this);
            }
        }

        public void Postavi_parametre(List<Tuple<string, string>> parametri)
        {
            throw new NotImplementedException();
        }

        public void Osvezi_sadrzaj()
        {
            throw new NotImplementedException();
        }

        private void dugmeFakultet_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeFakultetom>(this);
        }

        private void dugmeDepartmani_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeDepartmana>(this, null, true);
        }

        private void dugmeLogout_Click(object sender, EventArgs e)
        {
            /*logout*/
            Sesija.dajSessiju().Logout_korisnika();
            MenadzerFormi.dajFormu<FormaLogovanje>(this);
        }

        private void dugmeUpravljanjeUniverzitetom_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeUniverzitetom>(this);
        }

        private void dugmeUpravljanjeFakultetom_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeFakultetom>(this);
        }

        private void dugmeUpravljanjeDepartmanima_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeDepartmana>(this, null, true);
        }

        private void dugmeUpravljanjeStudentima_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeStudentima>(this, null, true);
        }

        private void dugmeUpravljanjeProfesorima_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeProfesorima>(this, null, true);
        }
    }
}
