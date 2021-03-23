using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistem
{
    public partial class FormaPolozeniPredmetiStudenta : Form, DodavanjeParametara
    {
        private static readonly log4net.ILog loger = Logger.GetLogger();
        private UInt32 broj_indeksa = 0;
        private List<Dictionary<string, string>> predmeti = new List<Dictionary<string, string>>();
        bool potrebno_azuriranje = false;

        private string student = string.Empty;

        public FormaPolozeniPredmetiStudenta()
        {
            InitializeComponent();
        }

        public void Osvezi_sadrzaj()
        {
            tabelaPolozeniPredmeti.Rows.Clear();
            this.predmeti.Clear();

            try
            {
                var rezultat = Baza.daj_instancu().Daj_listu_polozenih_ispita(this.broj_indeksa);
                foreach(var elem in rezultat)
                {
                    tabelaPolozeniPredmeti.Rows.Add(elem["predmet"], elem["predmet_id"] , elem["datum"], elem["ocena"], elem["fakultetska_godina"], "obriši");

                    Dictionary<string, string> red = new Dictionary<string, string>();
                    red.Add("predmet", elem["predmet"]);
                    red.Add("datum", elem["datum"]);
                    red.Add("ocena", elem["ocena"]);
                    red.Add("fakultetska_godina", elem["fakultetska_godina"]);
                    this.predmeti.Add(red);

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
            var indeks_priv = from indeks in parametri
                              where indeks.Item1.Equals("broj_indeksa")
                              select indeks.Item2;
            this.broj_indeksa = Convert.ToUInt32(indeks_priv.ToList()[0]);
            var ime_priv = from ime in parametri
                           where ime.Item1.Equals("ime")
                           select ime.Item2;
            labelaUnosStudent.Text = ime_priv.ToList()[0];

            this.student = string.Format("{0}-{1}", labelaUnosStudent.Text, this.broj_indeksa.ToString());
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

            MenadzerFormi.dajFormu<FormaUpravljanjeStudentima>(this, null, this.potrebno_azuriranje ? true : false);
        }

        private void FormaPolozeniPredmetiStudenta_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void dugmeStampajIspite_Click(object sender, EventArgs e)
        {
            /// stampamo polozene ispite studenta
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
            string lokacija_puna = string.Format(@"{0}\{1}", lokacija, "polozeni_predmeti.pdf");
            if (File.Exists(lokacija_puna))
            {
                MessageBox.Show("fajl već postoji na toj lokaciji", "već postoji", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            try
            {
                GeneratorIzvestaja.Kreiraj_izvestaj_polozenih_ispita_studentu(lokacija_puna, this.predmeti, this.student);
            }
            catch (Exception exception)
            {
                loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabelaPolozeniPredmeti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tabelaPolozeniPredmeti.Columns["akcija"].Index && e.RowIndex >= 0)
            {
                DialogResult res = MessageBox.Show("Da li ste sigurni da želite da obrišete položen predmet?", "Potvrda", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res.Equals(DialogResult.OK))
                {
                    int izabraniIndex = tabelaPolozeniPredmeti.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = tabelaPolozeniPredmeti.Rows[izabraniIndex];
                    UInt32 id_predmeta = Convert.ToUInt32(selectedRow.Cells["predmet_id"].Value);

                    try
                    {
                        string rezultat = Baza.daj_instancu().Izbrisi_polozen_ispit_studentu(this.broj_indeksa, id_predmeta);

                        if (rezultat.Equals(string.Empty))
                        {
                            MessageBox.Show("uspešno izbrisan položen predmet studentu", MenadzerStatusnihKodova.USPEH, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.potrebno_azuriranje = true;
                        }
                        else
                        {
                            MessageBox.Show(string.Format("nismo uspeli da izvršimo operaciju {0}", rezultat), MenadzerStatusnihKodova.GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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
    }
}
