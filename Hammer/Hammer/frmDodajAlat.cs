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
    public partial class frmDodajAlat : Form
    {
        private alati alatiIzmjena;
        public frmDodajAlat()
        {
            InitializeComponent();
        }
        public frmDodajAlat(alati alat)
        {
            InitializeComponent();
            alatiIzmjena = alat;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                if (alatiIzmjena == null)
                {
                    alati alat = new alati();
                    {
                        alat.naziv = txtNaziv.Text;
                        decimal rcijena;
                        if (decimal.TryParse((txtCijena.Text), out rcijena))
                        {
                            alat.cijena = rcijena;
                        }
                        else
                        {
                            MessageBox.Show("Greška kod validacije korisničkog unosa! (Cijena)");
                        }
                        int rkolicina;
                        if (int.TryParse((txtKolicina.Text), out rkolicina))
                        {
                            alat.kolicina = rkolicina;
                        }
                        else
                        {
                            MessageBox.Show("Greška kod validacije korisničkog unosa! (Količina)");
                        }
                        alat.servis= dtpServis.Value;
                    };
                    db.alati.Add(alat);
                    db.SaveChanges();
                }
                else
                {
                    db.alati.Attach(alatiIzmjena);
                    alatiIzmjena.naziv = txtNaziv.Text;
                    decimal rcijena;
                    if (decimal.TryParse((txtCijena.Text), out rcijena)){
                        alatiIzmjena.cijena = rcijena;
                    }
                    else {
                        MessageBox.Show("Greška kod validacije korisničkog unosa! (Cijena)");
                    }

                    int rkolicina;
                    if (int.TryParse((txtKolicina.Text), out rkolicina))
                    {
                        alatiIzmjena.kolicina = rkolicina;
                    }
                    else {
                        MessageBox.Show("Greška kod validacije korisničkog unosa! (Količina)");
                    }

                    alatiIzmjena.servis = dtpServis.Value;
                    db.SaveChanges();
                }
            }
            Close();

        }

        private void frmDodajAlat_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            if (alatiIzmjena != null)
            {
                txtID.Text = alatiIzmjena.id.ToString();
                txtNaziv.Text = alatiIzmjena.naziv;
                txtCijena.Text = alatiIzmjena.cijena.ToString();
                txtKolicina.Text = alatiIzmjena.kolicina.ToString();
                dtpServis.Text = alatiIzmjena.servis.ToString();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
