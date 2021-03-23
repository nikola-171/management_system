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
    public partial class FormaUpravljanjeDepartmana : Form, DodavanjeParametara
    {
        private static readonly log4net.ILog loger = Logger.GetLogger();

        private Dictionary<string, int> mapa_id_departmana = new Dictionary<string, int>();

        public FormaUpravljanjeDepartmana()
        {
            InitializeComponent();
        }

        public void Osvezi_sadrzaj()
        {
            try
            {
                tabelaPrikazDepartmana.Rows.Clear();
                this.mapa_id_departmana.Clear();
                var dd = Baza.daj_instancu().Daj_sve_departmane();


                foreach (var elem in dd)
                {

                   
                    tabelaPrikazDepartmana.Rows.Add(elem["id"], elem["univerzitet"], elem["fakultet"], elem["smer"], elem["nivo_studija"], "izbriši");

                    this.mapa_id_departmana.Add(elem["smer"], Convert.ToInt32(elem["id"]));
                }


            }
            catch (Exception ee)
            {
                MessageBox.Show("doslo je do greske " + ee.ToString());
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
            //staroo
            MenadzerFormi.dajFormu<FormaPocetnaStrana>(this);
        }

        private void dugmeNazad_Click_1(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaPocetnaStrana>(this);
        }

        private void FormaUpravljanjeDepartmana_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            Osvezi_sadrzaj();
        }

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaDodavanjeDepartmana>(this, null, true);
        }

        private void tabelaPrikazDepartmana_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ///brisanje departmana
            if (e.ColumnIndex == tabelaPrikazDepartmana.Columns["akcija"].Index && e.RowIndex >= 0)
            {
                DialogResult res = MessageBox.Show("Da li ste sigurni da želite da obrišete departman?", "Potvrda", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res.Equals(DialogResult.OK))
                {
                    int izabraniIndex = tabelaPrikazDepartmana.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = tabelaPrikazDepartmana.Rows[izabraniIndex];
                    string polje = Convert.ToString(selectedRow.Cells["departman"].Value);

                    int id = this.mapa_id_departmana[polje];

                    try
                    {
                        Baza.daj_instancu().Izbriši_departman(id);
                        MessageBox.Show("uspešno izbrisan departman", MenadzerStatusnihKodova.USPEH, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
