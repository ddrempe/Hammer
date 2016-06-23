using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hammer
{
    public partial class frmDodajZaposlenik : Form
    {
        private zaposlenici zaposlenikIzmjena;
        public frmDodajZaposlenik()
        {
            InitializeComponent();

        }
        public frmDodajZaposlenik(zaposlenici zaposlenik)
        {
            InitializeComponent();
            zaposlenikIzmjena = zaposlenik;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (txtOIB.Text == "" || txtIme.Text == "" || txtPrezime.Text == "" || txtStrucna.Text == "" || txtSatnica.Text == "")
            {
                MessageBox.Show("Sva polja moraju biti unesena!");
                return;
            }else
            {
                string oib = txtOIB.Text;
                Match provjera = Regex.Match(oib, @"^\d{11}$");
                using (var db = new Entities())
                {
                    if (zaposlenikIzmjena == null)
                    {
                        zaposlenici zaposlenik = new zaposlenici();
                        {
                            if (provjera.Success)
                            {
                                zaposlenik.oib = txtOIB.Text;
                                zaposlenik.ime = txtIme.Text;
                                zaposlenik.prezime = txtPrezime.Text;
                                zaposlenik.strucna_sprema = txtStrucna.Text;
                                zaposlenik.satnica = txtSatnica.Text;

                                foreach (var item in db.zaposlenici)
                                {
                                    if (txtOIB.Text == item.oib)
                                    {
                                        MessageBox.Show("Uneseni OIB već postoji!");
                                        return;
                                    }
                                }
                                db.zaposlenici.Add(zaposlenik);
                                db.SaveChanges();
                            }else{
                                MessageBox.Show("Polje OIB se sastoji od 11 brojeva!");
                                return;
                            }  
                        };
                    }
                    else
                    {
                        db.zaposlenici.Attach(zaposlenikIzmjena);
                        zaposlenikIzmjena.oib = txtOIB.Text;
                        zaposlenikIzmjena.ime = txtIme.Text;
                        zaposlenikIzmjena.prezime = txtPrezime.Text;
                        zaposlenikIzmjena.strucna_sprema = txtStrucna.Text;
                        zaposlenikIzmjena.satnica = txtSatnica.Text;
                        db.SaveChanges();
                    }

                }
            }
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDodajZaposlenik_Load(object sender, EventArgs e)
        {
            if (zaposlenikIzmjena != null)
            {
                txtOIB.Enabled = false;
                txtOIB.Text = zaposlenikIzmjena.oib;
                txtIme.Text = zaposlenikIzmjena.ime;
                txtPrezime.Text = zaposlenikIzmjena.prezime;
                txtStrucna.Text = zaposlenikIzmjena.strucna_sprema;
                txtSatnica.Text = zaposlenikIzmjena.satnica;
            }
        }
    }
}
