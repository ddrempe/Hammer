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
    public partial class frmUrediSiM : Form
    {
        private skladiste_materijali SiMIzmjena;
        public frmUrediSiM(skladiste_materijali SiM)
        {
            InitializeComponent();
            SiMIzmjena = SiM;
        }

        private void frmUrediSiM_Load(object sender, EventArgs e)
        {
            txtIDs.Enabled = false;
            txtIDm.Enabled = false;
            if (SiMIzmjena != null)
            {
                txtIDs.Text = SiMIzmjena.skladiste_id.ToString();
                txtIDm.Text = SiMIzmjena.materijali_id.ToString();
                txtKolicina.Text = SiMIzmjena.kolicina.ToString();
                txtOpis.Text = SiMIzmjena.opis;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                if (SiMIzmjena != null)
                {
                    db.skladiste_materijali.Attach(SiMIzmjena);
                    int rkolicina;
                    if (int.TryParse((txtKolicina.Text), out rkolicina)) SiMIzmjena.kolicina = rkolicina;
                    else MessageBox.Show("Greška kod validacije korisničkog unosa! (Količina)");

                    SiMIzmjena.opis = txtOpis.Text;

                    db.SaveChanges();
                }
                Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
