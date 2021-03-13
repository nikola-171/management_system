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
    public partial class FormaUpravljanjeFakultetom : Form, DodavanjeParametara
    {
        public FormaUpravljanjeFakultetom()
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
                tabelaPrikazFakulteta.Rows.Clear();
                var dd = Baza.daj_instancu().Daj_sve_fakultete();


                foreach (var elem in dd)
                {
                    

                    tabelaPrikazFakulteta.Rows.Add(elem["id"], elem["naziv"], elem["mesto"],elem["univerzitet"], "izmeni");
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

       
       

        private void FormaUpravljanjeFakultetom_Load(object sender, EventArgs e)
        {
            tabelaPrikazFakulteta.Columns[0].Width = 60;
            tabelaPrikazFakulteta.Columns[4].Width = 100;   
        }



        private void tabelaPrikazFakulteta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == tabelaPrikazFakulteta.Columns["akcija"].Index && e.RowIndex >= 0)
            {
                List<Tuple<string, string>> parametri = new List<Tuple<string, string>>();
                parametri.Add(new Tuple<string, string>("ID", tabelaPrikazFakulteta.Rows[e.RowIndex].Cells[0].Value.ToString()));
                parametri.Add(new Tuple<string, string>("naziv", tabelaPrikazFakulteta.Rows[e.RowIndex].Cells[1].Value.ToString()));
                parametri.Add(new Tuple<string, string>("mesto", tabelaPrikazFakulteta.Rows[e.RowIndex].Cells[2].Value.ToString()));

                MenadzerFormi.dajFormu<FormaIzmenaFakultet>(this, parametri);


            }
        }

        private void dugmeZaNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaPocetnaStrana>(this);
        }

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaDodavanjeFakultet>(this, null, true);
            //dodvanje fakulteta
        }
    }
}
