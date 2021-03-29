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
    public partial class FormaPrikazPredmetaStudenta : Form, DodavanjeParametara
    {
        private static readonly log4net.ILog loger = Logger.GetLogger();
        Dictionary<string, UInt32> mapa_predmet_id = new Dictionary<string, uint>();
        UInt32 broj_indeksa = 0;


        public FormaPrikazPredmetaStudenta()
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
            tabelaPrikazPredmeta.Rows.Clear();
            this.mapa_predmet_id.Clear();
            try
            {
                var rezultat = Baza.daj_instancu().Daj_slistu_predmeta_koje_student_slusa(this.broj_indeksa);

                foreach(var elem in rezultat)
                {
                    tabelaPrikazPredmeta.Rows.Add(elem["predmet"], elem["smer"], elem["id"], elem["fakultetska_godina"], "obriši");

                    if (!this.mapa_predmet_id.ContainsKey(elem["predmet"]))
                    {
                        this.mapa_predmet_id.Add(elem["predmet"], Convert.ToUInt32(elem["id"]));
                    }   

                }

            }catch (Exception exception)
            {
                loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                  
        }

        public void Postavi_parametre(List<Tuple<string, string>> parametri)
        {
            var broj_indeksa = 
                 from indeks in parametri
                 where indeks.Item1.Equals("broj_indeksa")
                 select indeks.Item2;

            var naziv = from ime in parametri
                        where ime.Item1.Equals("ime")
                        select ime.Item2;

            this.broj_indeksa = Convert.ToUInt32(broj_indeksa.ToList()[0]);
            labelaUnosStudent.Text = naziv.ToList()[0];
        }

        private void FormaPrikazPredmetaStudenta_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void dugmeNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaUpravljanjeStudentima>(this, null, false);
        }

        private void tabelaPrikazPredmeta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tabelaPrikazPredmeta.Columns["akcija"].Index && e.RowIndex >= 0)
            {
                DialogResult res = MessageBox.Show("Da li ste sigurni da želite da obrišete predmet?", "Potvrda", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res.Equals(DialogResult.OK))
                {
                    int izabraniIndex = tabelaPrikazPredmeta.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = tabelaPrikazPredmeta.Rows[izabraniIndex];
                    UInt32 id_predmeta = Convert.ToUInt32(selectedRow.Cells["id_predmeta"].Value);

                    try
                    {
                        Baza.daj_instancu().Brisanje_predmeta_koji_student_slusa(this.broj_indeksa, id_predmeta);
                        MessageBox.Show("uspešno obrisan predmet studentu", MenadzerStatusnihKodova.USPEH, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Osvezi_sadrzaj();

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
