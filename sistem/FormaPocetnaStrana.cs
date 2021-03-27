using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistem
{
    public partial class FormaPocetnaStrana : Form, DodavanjeParametara
    {
        private static readonly log4net.ILog loger = Logger.GetLogger();

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
           
            this.WindowState = FormWindowState.Maximized;
            /*ucitavanje podataka o administratoru*/   
            try
            {
                var rezultat =  Baza.daj_instancu().Daj_podatke_o_adminu(Sesija.dajSessiju().Daj_admina());
                labelaEmailPrikaz.Text = rezultat["email"];
                labelaTelefonPrikaz.Text = rezultat["telefon"];
                labelaImePrikaz.Text = rezultat["ime"] + " " + rezultat["prezime"];

                fakultetskaGodinaPrikaz.Text = Baza.daj_instancu().daj_tekucu_fakultetsku_godinu();

               
            }
            catch(Exception exception)
            {
                loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

      
        private void dugmeUniverzitet_Click(object sender, EventArgs e)
        {
            //   prikaz forme za upravljanje univerzitetima
            //   korisnik mora da bude ulogovan
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
            MenadzerFormi.dajFormu<FormaUpravljanjeUniverzitetom>(this, null, true);
        }

        private void dugmeUpravljanjeFakultetom_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeFakultetom>(this, null, true);
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

        private void dugmeUpravljanjePredmetima_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjePredmetima>(this, null, true);
        }
     

        private void dugmeAzurirajFakultetskuGodinu_Click(object sender, EventArgs e)
        {
            /// ažuriranje fakultetske godine
            /// automatski se vrši presek studenata na osnovu ostvarenog uspeha u tekućoj godini
            /// i utvrđuje se da li je će student biti na budžetu ili će biti samofinansirajući
            /// u novoj fakultetskoj godini
            /// potreban broj bodova za budžet je 48
            
            if(fakultetskaGodinaUnos.Text.Equals(string.Empty) || 
               fakultetskaGodinaUnos.Text.Length < 7 ||
               fakultetskaGodinaUnos.Text.IndexOf('/').Equals(-1))
            {
                MessageBox.Show(MenadzerStatusnihKodova.NEPRAVILAN_UNOS_PORUKA, MenadzerStatusnihKodova.NEPRAVILAN_UNOS,
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            try
            {        
                 Baza.daj_instancu().Azuriraj_fakultetsku_godinu(fakultetskaGodinaUnos.Text);

                
                 MessageBox.Show("Uspešno ažurirana fakultetska godina", MenadzerStatusnihKodova.USPEH,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                 fakultetskaGodinaPrikaz.Text = fakultetskaGodinaUnos.Text;
                 fakultetskaGodinaUnos.Clear();
            }
            catch (Exception exception)
            {
                loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       

       
        private void listaPredmetaIzvestaj_Click(object sender, EventArgs e)
        {
            string lokacija = @"D:\";
            FolderBrowserDialog dijalog_lokacija = new FolderBrowserDialog();

            DialogResult rezultat = dijalog_lokacija.ShowDialog();

            if (rezultat.Equals(DialogResult.OK))
            {
                lokacija = dijalog_lokacija.SelectedPath;
            }
            else if (rezultat.Equals(DialogResult.Cancel))
            {
                MessageBox.Show("niste izabrali lokaciju", "lokacija dokumenta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            try
            {
                GeneratorIzvestaja.Kreiraj_izvestaj_svih_predmeta(string.Format(@"{0}\{1}", lokacija, "predmeti_sa_profesorima.pdf"));
            }
            catch (Exception exception)
            {
                loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void dugmeIzvestajPromeneUniverzitet_Click(object sender, EventArgs e)
        {
            string lokacija = @"D:\";
            FolderBrowserDialog dijalog_lokacija = new FolderBrowserDialog();

            DialogResult rezultat = dijalog_lokacija.ShowDialog();

            if (rezultat.Equals(DialogResult.OK))
            {
                lokacija = dijalog_lokacija.SelectedPath;
            }
            else if (rezultat.Equals(DialogResult.Cancel))
            {
                MessageBox.Show("niste izabrali lokaciju", "lokacija dokumenta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            try
            {
                GeneratorIzvestaja.Kreiraj_izvestaj_svih_promena_na_univerzitetima(string.Format(@"{0}\{1}", lokacija, "promene_na_univerzitet.pdf"));
            }
            catch (Exception exception)
            {
                loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dugmeIzvestajPromeneFakultet_Click(object sender, EventArgs e)
        {
            string lokacija = @"D:\";
            FolderBrowserDialog dijalog_lokacija = new FolderBrowserDialog();

            DialogResult rezultat = dijalog_lokacija.ShowDialog();

            if (rezultat.Equals(DialogResult.OK))
            {
                lokacija = dijalog_lokacija.SelectedPath;
            }
            else if (rezultat.Equals(DialogResult.Cancel))
            {
                MessageBox.Show("niste izabrali lokaciju", "lokacija dokumenta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            try
            {
                GeneratorIzvestaja.Kreiraj_izvestaj_svih_promena_na_univerzitetima(string.Format(@"{0}\{1}", lokacija, "promene_na_fakultetu.pdf"));
            }
            catch (Exception exception)
            {
                loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dugmeInformacije_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("{0}\n{1}", 
                                          "aplikacija za upravljanje univerzitetom",
                                          "autor Nikola Tošić"),
                                          "App", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
