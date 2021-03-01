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
    public partial class FormaRegistracija : Form
    {
        public FormaRegistracija()
        {
            InitializeComponent();
        }

        private void dugme_nazad_Click(object sender, EventArgs e)
        {
            FormaLogovanje logovanje = new FormaLogovanje();
            this.Hide();
            logovanje.ShowDialog();
            this.Close();
        }

        private void dugme_registracija_Click(object sender, EventArgs e)
        {
            if(ime_unos.Text.Trim().Equals("") || prezime_unos.Text.Trim().Equals("") ||
               korisnicko_ime_unos.Text.Trim().Equals("") || lozinka_unos.Text.Trim().Equals("") ||
               lozinka_ponovo_unos.Text.Trim().Equals("") || email_unos.Text.Trim().Equals("") ||
               telefon_unos.Text.Trim().Equals(""))
            {
                MessageBox.Show("prazna polja nisu dozvoljena", "Prazno polje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
