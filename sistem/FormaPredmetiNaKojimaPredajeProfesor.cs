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
    public partial class FormaPredmetiNaKojimaPredajeProfesor : Form, DodavanjeParametara
    {
        private UInt32 id_profesora = 0;
        private string naslov_profesor_prim = string.Empty;
        private static readonly log4net.ILog loger = Logger.GetLogger();


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Sesija.dajSessiju().Logout_korisnika();
            MenadzerFormi.Zatvori();
        }

        public FormaPredmetiNaKojimaPredajeProfesor()
        {
            InitializeComponent();
        }

        public void Osvezi_sadrzaj()
        {
            labelaProfesorUnos.Text = this.naslov_profesor_prim;
        
            tabelaPrikazPredmeta.Rows.Clear();

            try
            {
                var rezultat = Baza.daj_instancu().Daj_predmete_na_kojima_predaje_profesor(this.id_profesora);

                foreach(var elem in rezultat)
                {
                    tabelaPrikazPredmeta.Rows.Add(elem["email"], elem["naziv"], Convert.ToInt32(elem["tip"]) == 1 ? "profesor" : "asistent");
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
            var id_prim =
                from id in parametri
                where id.Item1.Equals("id")
                select id.Item2;
            this.id_profesora = Convert.ToUInt32(id_prim.ToList()[0]);

            var naslov_prim =
                from naslov in parametri
                where naslov.Item1.Equals("naslov")
                select naslov.Item2;
            this.naslov_profesor_prim = naslov_prim.ToList()[0];

        }

        private void dugmeNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeProfesorima>(this, null, false);
        }

        private void FormaPredmetiNaKojimaPredajeProfesor_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
