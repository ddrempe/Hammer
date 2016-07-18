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
    public partial class frmDodajStroj : Form
    {
        private strojevi strojeviIzmjena;
        public frmDodajStroj()
        {
            InitializeComponent();
        }
        public frmDodajStroj(strojevi stroj)
        {
            InitializeComponent();
            strojeviIzmjena = stroj;
        }

        private void frmDodajStroj_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            if (strojeviIzmjena != null)
            {
                txtID.Text = strojeviIzmjena.id.ToString();
                txtNaziv.Text = strojeviIzmjena.naziv;
                txtCijena.Text = strojeviIzmjena.cijena.ToString();
                dtpServis.Text = strojeviIzmjena.servis.ToString();
                txtGodina.Text = strojeviIzmjena.god_proizvodnje.ToString();
                dtpRegistracija.Text = strojeviIzmjena.datum_registracije.ToString();
                txtSnaga.Text = strojeviIzmjena.snaga.ToString();
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                if (strojeviIzmjena == null)
                {
                    strojevi stroj = new strojevi();
                    {
                        stroj.naziv = txtNaziv.Text;

                        decimal rcijena;
                        if (decimal.TryParse((txtCijena.Text), out rcijena)) stroj.cijena = rcijena;
                        else MessageBox.Show("Greška kod validacije korisničkog unosa! (Cijena)");

                        stroj.servis = dtpServis.Value;
                        stroj.datum_registracije = dtpRegistracija.Value;

                        int rgodina;
                        if (int.TryParse((txtGodina.Text), out rgodina)) stroj.god_proizvodnje = rgodina;
                        else MessageBox.Show("Greška kod validacije korisničkog unosa! (Godina)");

                        int rsnaga;
                        if (int.TryParse((txtSnaga.Text), out rsnaga)) stroj.snaga = rsnaga;
                        else MessageBox.Show("Greška kod validacije korisničkog unosa! (Snaga)");
                    };
                    db.strojevi.Add(stroj);
                    db.SaveChanges();
                }
                else
                {
                    db.strojevi.Attach(strojeviIzmjena);
                    strojeviIzmjena.naziv = txtNaziv.Text;

                    decimal rcijena;
                    if (decimal.TryParse((txtCijena.Text), out rcijena)) strojeviIzmjena.cijena = rcijena;
                    else MessageBox.Show("Greška kod validacije korisničkog unosa! (Cijena)");

                    strojeviIzmjena.servis = dtpServis.Value;
                    strojeviIzmjena.datum_registracije = dtpRegistracija.Value;

                    int rgodina;
                    if (int.TryParse((txtGodina.Text), out rgodina)) strojeviIzmjena.god_proizvodnje = rgodina;
                    else MessageBox.Show("Greška kod validacije korisničkog unosa! (Godina)");

                    int rsnaga;
                    if (int.TryParse((txtSnaga.Text), out rsnaga)) strojeviIzmjena.snaga = rsnaga;
                    else MessageBox.Show("Greška kod validacije korisničkog unosa! (Snaga)");

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
