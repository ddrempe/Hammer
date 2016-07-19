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
    public partial class frmDodajMaterijal : Form
    {
        private materijali materijaliIzmjena;
        public frmDodajMaterijal()
        {
            InitializeComponent();
        }
        public frmDodajMaterijal(materijali materijal)
        {
            InitializeComponent();
            materijaliIzmjena = materijal;
        }

        private void frmDodajMaterijal_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            if (materijaliIzmjena != null)
            {
                txtID.Text = materijaliIzmjena.id.ToString();
                txtNaziv.Text = materijaliIzmjena.naziv;
                txtCijena.Text = materijaliIzmjena.cijena.ToString();
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                if (materijaliIzmjena == null)
                {
                    materijali materijal = new materijali();
                    {
                        materijal.naziv = txtNaziv.Text;

                        decimal rcijena;
                        if (decimal.TryParse((txtCijena.Text), out rcijena)) materijal.cijena = rcijena;
                        else MessageBox.Show("Greška kod validacije korisničkog unosa! (Cijena)");
                    };
                    db.materijali.Add(materijal);
                    db.SaveChanges();
                }
                else
                {
                    db.materijali.Attach(materijaliIzmjena);
                    materijaliIzmjena.naziv = txtNaziv.Text;
                    decimal rcijena;
                    if (decimal.TryParse((txtCijena.Text), out rcijena)) materijaliIzmjena.cijena = rcijena;
                    else MessageBox.Show("Greška kod validacije korisničkog unosa! (Cijena)");

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
