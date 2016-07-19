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
    public partial class frmDodajVozilo : Form
    {
        private vozni_park voziloIzmjena;
        public frmDodajVozilo()
        {
            InitializeComponent();
        }
        public frmDodajVozilo(vozni_park vozilo)
        {
            InitializeComponent();
            voziloIzmjena = vozilo;
        }

        private void frmDodajVozilo_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            if (voziloIzmjena != null)
            {
                txtID.Text = voziloIzmjena.id.ToString();
                txtNaziv.Text = voziloIzmjena.naziv;
                txtCijena.Text = voziloIzmjena.cijena.ToString();
                txtKolicina.Text = voziloIzmjena.kolicina.ToString();
                dtpServis.Text = voziloIzmjena.servis.ToString();
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                if (voziloIzmjena == null)
                {
                    vozni_park vozilo = new vozni_park();
                    {
                        vozilo.naziv = txtNaziv.Text;

                        decimal rcijena;
                        if (decimal.TryParse((txtCijena.Text), out rcijena)) vozilo.cijena = rcijena;
                        else MessageBox.Show("Greška kod validacije korisničkog unosa! (Cijena)");

                        int rkolicina;
                        if (int.TryParse((txtKolicina.Text), out rkolicina)) vozilo.kolicina = rkolicina;
                        else MessageBox.Show("Greška kod validacije korisničkog unosa! (Količina)");

                        vozilo.servis = dtpServis.Value;
                    };
                    db.vozni_park.Add(vozilo);
                    db.SaveChanges();
                }
                else
                {
                    db.vozni_park.Attach(voziloIzmjena);
                    voziloIzmjena.naziv = txtNaziv.Text;

                    decimal rcijena;
                    if (decimal.TryParse((txtCijena.Text), out rcijena)) voziloIzmjena.cijena = rcijena;
                    else MessageBox.Show("Greška kod validacije korisničkog unosa! (Cijena)");

                    int rkolicina;
                    if (int.TryParse((txtKolicina.Text), out rkolicina)) voziloIzmjena.kolicina = rkolicina;
                    else MessageBox.Show("Greška kod validacije korisničkog unosa! (Količina)");

                    voziloIzmjena.servis = dtpServis.Value;
                    db.SaveChanges();
                }
            }
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
