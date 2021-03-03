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
    public partial class FormaPocetnaStrana : Form
    {
        public FormaPocetnaStrana()
        {

            InitializeComponent();
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            MenadzerFormi.Zatvori();
        }

        private void FormaPocetnaStrana_Load(object sender, EventArgs e)
        {
            /*ucitavanje sadrzaja*/
           

            
        }

      

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            /*logout*/
            MenadzerFormi.dajFormu<FormaLogovanje>(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MenadzerFormi.dajFormu<FormaLogovanje>(this);

        }
    }
}
