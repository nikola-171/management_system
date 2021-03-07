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
    public partial class FormaUpravljanjeStudentima : Form, DodavanjeParametara
    {
        private int id_studenta_za_brisanje = -1;
        public FormaUpravljanjeStudentima()
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
            brojIndeksaUnos.Text = "";
            panelPrikazRezultata.Visible = false;
            studentImePrikaz.Text = "";
            brojIndeksaPrikaz.Text = "";
            prosekPrikaz.Text = "";
            espbPrikaz.Text = "";
            fakultetPrikaz.Text = "";
            smerPrikaz.Text = "";
            diplomiraoPrikaz.Text = "";
            statusPrikaz.Text = "";
            dugmeUkloniStudenta.Enabled = false;
            this.id_studenta_za_brisanje = -1;
        }

        public void Postavi_parametre(List<Tuple<string, string>> parametri)
        {
            
            throw new NotImplementedException();
        }

        private void dugmeNazad_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaPocetnaStrana>(this);
        }

        private void dugmePretraga_Click(object sender, EventArgs e)
        {
            //pretraga sudenta
            try
            {
                panelPrikazRezultata.Visible = false;

                Dictionary<string, string> rezultat = Baza.daj_instancu().Daj_informacije_o_studentu(Convert.ToInt32(brojIndeksaUnos.Text));

                if (rezultat.Count.Equals(0))
                {
                    MessageBox.Show("student sa datim brojem indeksa nije pronađen", "nije pronađen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    studentImePrikaz.Text = rezultat["ime"] + " " + rezultat["prezime"];
                    brojIndeksaPrikaz.Text = rezultat["broj_indeksa"];
                    this.id_studenta_za_brisanje = Convert.ToInt32(rezultat["broj_indeksa"]);
                    prosekPrikaz.Text = rezultat["prosek"];
                    espbPrikaz.Text = rezultat["espb"];
                    fakultetPrikaz.Text = rezultat["fakultet"];
                    smerPrikaz.Text = rezultat["smer"];

                    if (Convert.ToInt32(rezultat["diplomirao"]).Equals(MenadzerStatusnihKodova.STUDENT_NIJE_DIPLOMIRAO))
                    {
                        diplomiraoPrikaz.Text = MenadzerStatusnihKodova.STUDENT_NIJE_DIPLOMIRAO_PORUKA;
                    }
                    else
                    {
                        diplomiraoPrikaz.Text = MenadzerStatusnihKodova.STUDENT_DIPLOMIRAO_PORUKA;
                    }

                    if (Convert.ToInt32(rezultat["status_studenta"]).Equals(MenadzerStatusnihKodova.STUDENT_STATUS_BUDZET))
                    {
                        statusPrikaz.Text = MenadzerStatusnihKodova.STUDENT_BUDZET_PORUKA;
                    }
                    else
                    {
                        statusPrikaz.Text = MenadzerStatusnihKodova.STUDENT_SAMOFINANSIRANJE_PORUKA;
                    }

                    dugmeUkloniStudenta.Enabled = true;
                    panelPrikazRezultata.Visible = true;

                }


            }
            catch (Exception excpetion)
            {
                MessageBox.Show("došlo je do greške " + excpetion.ToString());
            }
        }

        private void dugmeUkloniStudenta_Click(object sender, EventArgs e)
        {
            //brisanje studenta
            try
            {
                Baza.daj_instancu().Izbrisi_studenta(this.id_studenta_za_brisanje);
                MessageBox.Show("student uspešno obrisan", "uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception exception)
            {
                MessageBox.Show("došlo je do greške " + exception.ToString(), "greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Osvezi_sadrzaj();
            }
        }
    }
}
