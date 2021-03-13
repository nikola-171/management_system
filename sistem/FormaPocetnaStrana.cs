using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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

        private void dugmeIzvestajUniverziteti_Click(object sender, EventArgs e)
        {
            //test
            PdfDocument document = new PdfDocument();
            document.Info.Title = "prvi izveštaj u .net -u ";

            PdfPage strana = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(strana);

            XFont font = new XFont("Verdana", 20, XFontStyle.Regular);

            gfx.DrawString("hello world!", font, XBrushes.Black, new XRect(0, 0, 50 , 50), XStringFormats.TopLeft);
            gfx.DrawString("hello world222!", font, XBrushes.Black, new XRect(0, 50, 50, 50), XStringFormats.TopLeft);
            gfx.DrawString("hello world!333333", font, XBrushes.Black, new XRect(0, 100, 50, 50), XStringFormats.TopLeft);


            const string filename = "test6.pdf";
            document.Save(filename);

            Process.Start(filename);

        }

        private void dugmeAzurirajFakultetskuGodinu_Click(object sender, EventArgs e)
        {
            /// ažuriranje fakultetske godine
            /// automatski se vrši presek studenata na osnovu ostvarenog uspeha u tekućoj godini
            /// i utvrđuje se da li je će student biti na budžetu ili će biti samofinansirajući
            /// u novoj fakultetskoj godini
            /// potreban broj bodova za budžet je 48

            try
            {
                MessageBox.Show(fakultetskaGodinaUnos.Text);
             
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
    }
}
