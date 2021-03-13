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
    public partial class FormaUpravljanjeUniverzitetom : Form, DodavanjeParametara
    {
        
        public FormaUpravljanjeUniverzitetom()
        {
            InitializeComponent();
            
        }

        public void Osvezi_sadrzaj()
        {
            try
            {
                tabelaPrikazUniverziteta.Rows.Clear();
                var dd = Baza.daj_instancu().Daj_sve_univerzitete();


                foreach (var elem in dd)
                {

                    tabelaPrikazUniverziteta.Rows.Add(elem["id"], elem["naziv"], elem["grad"], elem["drzava"], "izmeni");
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

        public void Stilizovanje_tabele()
        {
       
            tabelaPrikazUniverziteta.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 20);
            tabelaPrikazUniverziteta.Columns[4].Width = 100;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Sesija.dajSessiju().Logout_korisnika();
            MenadzerFormi.Zatvori();
        }

        

        private void FormaUpravljanjeUniverzitetom_Load(object sender, EventArgs e)
        {
            // Osvezi_sadrzaj();
            Stilizovanje_tabele();
        }

       

       

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaDodavanjeUniverziteta>(this);
        }

        private void dugmeNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaPocetnaStrana>(this);
        }

        private void tabelaPrikazUniverziteta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tabelaPrikazUniverziteta.Columns["akcija"].Index && e.RowIndex >= 0)
            {
                List<Tuple<string, string>> parametri = new List<Tuple<string, string>>();
                parametri.Add(new Tuple<string, string>("ID", tabelaPrikazUniverziteta.Rows[e.RowIndex].Cells[0].Value.ToString()));
                parametri.Add(new Tuple<string, string>("naziv", tabelaPrikazUniverziteta.Rows[e.RowIndex].Cells[1].Value.ToString()));
                parametri.Add(new Tuple<string, string>("grad", tabelaPrikazUniverziteta.Rows[e.RowIndex].Cells[2].Value.ToString()));
                parametri.Add(new Tuple<string, string>("drzava", tabelaPrikazUniverziteta.Rows[e.RowIndex].Cells[3].Value.ToString()));

                MenadzerFormi.dajFormu<FormaIzmenaUniverziteta>(this, parametri);


            }
        }
    }
}
