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
    public partial class FormaUpravljanjeUniverzitetom : Form
    {
        
        public FormaUpravljanjeUniverzitetom()
        {
            InitializeComponent();
            Stilizovanje_tabele();
        }

        public void Stilizovanje_tabele()
        {
       
            tabelaPrikazUniverziteta.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 20);

            
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
            try
            {
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

        

        private void meniNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaPocetnaStrana>(this);
        }

        private void tabelaPrikazUniverziteta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tabelaPrikazUniverziteta.Columns["akcija"].Index && e.RowIndex >= 0)
            {
                
                MenadzerFormi.dajFormu<FormaIzmenaUniverziteta>(this);
               // MessageBox.Show(tabelaPrikazUniverziteta.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
        }
    }
}
