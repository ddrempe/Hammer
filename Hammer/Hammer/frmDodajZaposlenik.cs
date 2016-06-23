using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hammer
{
    public partial class frmDodajZaposlenik : Form
    {
<<<<<<< HEAD
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
            using (var db = new Entities())
            {
                if (zaposlenikIzmjena == null)
                {
                    zaposlenici zaposlenik = new zaposlenici();
                    {
                        zaposlenik.oib = txtOIB.Text;
                        zaposlenik.ime = txtIme.Text;
                        zaposlenik.prezime = txtPrezime.Text;
                        zaposlenik.strucna_sprema = txtStrucna.Text;
                        zaposlenik.satnica = txtSatnica.Text;
                    
                    };
                    db.zaposlenici.Add(zaposlenik);
                    db.SaveChanges();
                }
                else
                {
                    txtOIB.Enabled = false;
                    db.zaposlenici.Attach(zaposlenikIzmjena);
                    zaposlenikIzmjena.ime = txtIme.Text;
                    zaposlenikIzmjena.prezime = txtPrezime.Text;
                    zaposlenikIzmjena.strucna_sprema = txtStrucna.Text;
                    zaposlenikIzmjena.satnica = txtSatnica.Text;
                    db.SaveChanges();
                }

=======
        public frmDodajZaposlenik()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                zaposlenici zaposlenik = new zaposlenici();
                {
                    zaposlenik.oib = txtOIB.Text;
                    zaposlenik.ime = txtIme.Text;
                    zaposlenik.prezime = txtPrezime.Text;
                    zaposlenik.gradilista_id = comboBox1.SelectedIndex;
                    zaposlenik.strucna_sprema = txtStrucnaSprema.Text;
                    zaposlenik.od = dtpOd.Value;
                };
                db.zaposlenici.Add(zaposlenik);
                db.SaveChanges();
>>>>>>> origin/master
            }
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
<<<<<<< HEAD

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
=======
>>>>>>> origin/master
    }
}
