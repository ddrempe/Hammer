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
    public partial class frmDodajSkladiste : Form
    {
        private skladista skladisteIzmjena;
        public frmDodajSkladiste()
        {
            InitializeComponent();
        }
        public frmDodajSkladiste(skladista skladiste)
        {
            InitializeComponent();
            skladisteIzmjena = skladiste;
        }

        private void frmDodajSkladiste_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            if (skladisteIzmjena != null)
            {
                txtID.Text = skladisteIzmjena.id.ToString();
                txtKapacitet.Text = skladisteIzmjena.kapacitet.ToString();
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                if (skladisteIzmjena == null)
                {
                    skladista skladiste = new skladista();
                    {
                        int rkapacitet;
                        if (int.TryParse((txtKapacitet.Text), out rkapacitet)) skladiste.kapacitet = rkapacitet;
                        else MessageBox.Show("Greška kod validacije korisničkog unosa! (Kapacitet)");
                    };
                    db.skladista.Add(skladiste);
                    db.SaveChanges();
                }
                else
                {
                    db.skladista.Attach(skladisteIzmjena);
                    int rkapacitet;
                    if (int.TryParse((txtKapacitet.Text), out rkapacitet)) skladisteIzmjena.kapacitet = rkapacitet;
                    else MessageBox.Show("Greška kod validacije korisničkog unosa! (Kapacitet)");

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
