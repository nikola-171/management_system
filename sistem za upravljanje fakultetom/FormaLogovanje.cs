using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace sistem
{
    public partial class FormaLogovanje : Form
    {
        public FormaLogovanje()
        {
            InitializeComponent();
        }

        private void dugme_logovanje_Click(object sender, EventArgs e)
        {
            if (korisnicko_ime_unos.Text.Trim().Equals("") || lozinka_unos.Text.Trim().Equals(""))
            {
                MessageBox.Show("Prazna polja nisu dozvoljena", "Prazno polje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                korisnicko_ime_unos.Text = "";
                lozinka_unos.Text = "";
            }
            else
            {
                try
                {
                    //MessageBox.Show(r.Field<string>("ime"));
                    Baza b = Baza.daj_instancu();
                    b.Provera_autentifikacije_korisnika("zz", "hh");
                }
                catch (Exception excpetion)
                {
                    MessageBox.Show("Could not connect to server, please try again later.");
                }
              
           
            }
        }

        private void dugme_registracija_Click(object sender, EventArgs e)
        {
            FormaRegistracija registracija = new FormaRegistracija();
            this.Hide();
            
            registracija.ShowDialog();
            this.Close();
        }

        
    }
}
