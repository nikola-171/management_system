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
        private static readonly log4net.ILog loger = Logger.GetLogger();

        private List<Dictionary<string, string>> predmeti_iz_baze = new List<Dictionary<string, string>>();
        private List<Dictionary<string, string>> profesori_iz_baze = new List<Dictionary<string, string>>();
        private Dictionary<string, int> tip_zaposlenja = new Dictionary<string, int>();

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
                listaTip.Items.Clear();
                this.tip_zaposlenja.Clear();
                listaTip.Items.Add("asistent");
                this.tip_zaposlenja.Add("asistent", 1);
                listaTip.Items.Add("profesor");
                this.tip_zaposlenja.Add("profesor", 0);

                this.predmeti_iz_baze.Clear();
                listaPredmet.Items.Clear();

                var predmeti = Baza.daj_instancu().Daj_sve_predmete();
                
                foreach(var elem in predmeti)
                {
                    Dictionary<string, string> red = new Dictionary<string, string>();
                    red.Add("id", elem["id"]);
                    red.Add("naziv", elem["naziv"]);
                    red.Add("espb", elem["espb"]);
                    red.Add("godina", elem["godina"]);
                    red.Add("semestar", elem["semestar"]);
                    red.Add("departman", elem["departman"]);
                    
                    this.predmeti_iz_baze.Add(red);
                    listaPredmet.Items.Add(elem["naziv"]);
                    
                }

                this.profesori_iz_baze.Clear();
                listaProfesor.Items.Clear();

                var profesori = Baza.daj_instancu().Daj_sve_profesore();

                foreach (var elem in profesori)
                {
                    Dictionary<string, string> red = new Dictionary<string, string>();
                    red.Add("id", elem["id"]);
                    red.Add("ime", elem["ime"]);
                    red.Add("prezime", elem["prezime"]);
                    red.Add("email", elem["email"]);
                    red.Add("telefon", elem["telefon"]);
                    red.Add("naziv_iz_liste", elem["ime"] + " " + elem["prezime"]);

                    this.profesori_iz_baze.Add(red);
                    listaProfesor.Items.Add(elem["ime"] + " " + elem["prezime"]);

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

        private void Ocisti_unos_predmet()
        {
            predmetDepartmanUnos.Text = predmetDepartmanUnos.Text.Trim(' ');
            predmetNazivUnos.Text = predmetNazivUnos.Text.Trim(' ');
        }
        private void Ocisti_unos_profesor()
        {
            profesorIdUnos.Text = profesorIdUnos.Text.Trim(' ');
            profesorImeUnos.Text = profesorImeUnos.Text.Trim(' ');
            profesorPrezimeUnos.Text = profesorPrezimeUnos.Text.Trim(' ');
        }

        private void dugmeNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjePredmetima>(this, null, true);
        }

        private void FormaDodavanjeProfesoraPredmetu_Load(object sender, EventArgs e)
        {     
        }

        private bool Validacija()
        {
            return (!listaProfesor.SelectedIndex.Equals(-1) && !listaPredmet.SelectedIndex.Equals(-1) && !listaTip.SelectedIndex.Equals(-1));
        }

        private void dugmePretragaPredmet_Click(object sender, EventArgs e)
        {
            
            listaPredmet.Items.Clear();
            Ocisti_unos_predmet();
            var rezultat = from predmet in this.predmeti_iz_baze
                           where predmet["naziv"].Contains(predmetNazivUnos.Text) &&
                                 predmet["departman"].Contains(predmetDepartmanUnos.Text)
                           select predmet;
            foreach (var elem in rezultat)
            {
                listaPredmet.Items.Add(elem["naziv"]);
            }            
        }

        private void dugmePretragaProfesor_Click(object sender, EventArgs e)
        {
            listaProfesor.Items.Clear();
            Ocisti_unos_profesor();

            IEnumerable<Dictionary<string, string>> rezultat = null;

            if (profesorIdUnos.Text != "")
            {
                rezultat = from profesor in this.profesori_iz_baze
                           where profesor["id"] == profesorIdUnos.Text &&
                                 profesor["ime"].Contains(profesorImeUnos.Text) &&
                                 profesor["prezime"].Contains(profesorPrezimeUnos.Text)
                           select profesor;
            }
            else
            {
                rezultat = from profesor in this.profesori_iz_baze
                           where profesor["ime"].Contains(profesorImeUnos.Text) &&
                                 profesor["prezime"].Contains(profesorPrezimeUnos.Text)
                           select profesor;
            }

            foreach (var elem in rezultat)
            {
                listaProfesor.Items.Add(elem["ime"] + " " + elem["prezime"]);
            }     
        }

        private void dugmeDodajPredmet_Click(object sender, EventArgs e)
        {
            if (!Validacija())
            {
                MessageBox.Show(MenadzerStatusnihKodova.NEPRAVILAN_UNOS_PORUKA, MenadzerStatusnihKodova.NEPRAVILAN_UNOS,
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            try
            {
                UInt32 id_profesora = 0;
                foreach(var elem in this.profesori_iz_baze)
                {
                    if(elem["naziv_iz_liste"] == Convert.ToString(listaProfesor.SelectedItem))
                    {
                        id_profesora = Convert.ToUInt32(elem["id"]);
                        break;
                    }
                }

                UInt32 id_predmeta = 0;
                foreach (var elem in this.predmeti_iz_baze)
                {
                    if (elem["naziv"] == Convert.ToString(listaPredmet.SelectedItem))
                    {
                        id_predmeta = Convert.ToUInt32(elem["id"]);
                        break;
                    }
                }
                sbyte tip = Convert.ToSByte(this.tip_zaposlenja[Convert.ToString(listaTip.SelectedItem)]);



                string status = Baza.daj_instancu().Dodeli_predmet_profesoru(id_profesora, id_predmeta, tip);
                MessageBox.Show(string.Format("{0}", status), MenadzerStatusnihKodova.USPEH,
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
}
