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
        private static readonly log4net.ILog loger = Logger.GetLogger();

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

        private bool Validacija()
        {
            return int.TryParse(brojIndeksaUnos.Text, out _);
        }

        public void Osvezi_sadrzaj()
        {
            brojIndeksaUnos.Clear();
            panelPrikazRezultata.Visible = false;
            studentImePrikaz.Text = string.Empty;
            brojIndeksaPrikaz.Text = string.Empty;
            prosekPrikaz.Text = string.Empty;
            espbPrikaz.Text = string.Empty;
            fakultetPrikaz.Text = string.Empty;
            smerPrikaz.Text = string.Empty;
            diplomiraoPrikaz.Text = string.Empty;
            statusPrikaz.Text = string.Empty;
            dugmeUkloniProfesora.Enabled = false;
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
            if (!Validacija())
            {
                MessageBox.Show(MenadzerStatusnihKodova.NEPRAVILAN_UNOS_PORUKA, MenadzerStatusnihKodova.NEPRAVILAN_UNOS,
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
                return;
            }

            try
            {
                panelPrikazRezultata.Visible = false;

                Dictionary<string, string> rezultat = Baza.daj_instancu().Daj_informacije_o_studentu(Convert.ToInt32(brojIndeksaUnos.Text));

                if (rezultat.Count.Equals(0))
                {
                    MessageBox.Show(MenadzerStatusnihKodova.STUDENT_NIJE_PRONADJEN, MenadzerStatusnihKodova.ZAPIS_NIJE_PRONADJEN,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    dugmeUkloniProfesora.Enabled = true;
                    panelPrikazRezultata.Visible = true;

                }


            }
            catch (Exception exception)
            {
                loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                brojIndeksaUnos.Clear();
            }
        }

        private void dugmeUkloniStudenta_Click(object sender, EventArgs e)
        {
            //brisanje studenta
            try
            {
                MessageBox.Show(this.id_studenta_za_brisanje.ToString());
                Baza.daj_instancu().Izbrisi_studenta(this.id_studenta_za_brisanje);
                MessageBox.Show(MenadzerStatusnihKodova.STUDENT_OBRISAN, MenadzerStatusnihKodova.USPEH,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception exception)
            {
                loger.Error(MenadzerStatusnihKodova.GRESKA, exception);

                MessageBox.Show(MenadzerStatusnihKodova.GRESKA_TEKST, MenadzerStatusnihKodova.GRESKA,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Osvezi_sadrzaj();
            }
        }

        private void dugmeDodajStudenta_Click(object sender, EventArgs e)
        {
            MenadzerFormi.dajFormu<FormaDodavanjeStudenata>(this, null, true);
        }
    }
}
