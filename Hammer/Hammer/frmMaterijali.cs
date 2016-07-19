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
    public partial class frmMaterijali : Form
    {
        public frmMaterijali()
        {
            InitializeComponent();
            PrikaziMaterijale();
        }
        private void PrikaziMaterijale()
        {
            BindingList<materijali> listaMaterijala = null;
            using (var db = new Entities())
            {
                listaMaterijala = new BindingList<materijali>(db.materijali.ToList());
            }
            materijaliBindingSource.DataSource = listaMaterijala;
        }

        private void btnDodajMaterijal_Click(object sender, EventArgs e)
        {
            frmDodajMaterijal formaDodajMaterijal = new frmDodajMaterijal();
            formaDodajMaterijal.ShowDialog();
            PrikaziMaterijale();
        }

        private void btnUrediMaterijal_Click(object sender, EventArgs e)
        {
            materijali odabraniMaterijal = materijaliBindingSource.Current as materijali;
            if (odabraniMaterijal != null)
            {
                frmDodajMaterijal formaUrediMaterijal = new frmDodajMaterijal(odabraniMaterijal);
                formaUrediMaterijal.ShowDialog();
                PrikaziMaterijale();
            }
        }

        private void btnObrisiMaterijal_Click(object sender, EventArgs e)
        {
            materijali odabraniMaterijal = materijaliBindingSource.Current as materijali;
            if (odabraniMaterijal != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {

                        db.materijali.Attach(odabraniMaterijal);

                        if (odabraniMaterijal.skladiste_materijali.Count == 0)
                        {
                            db.materijali.Remove(odabraniMaterijal);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati materijal koji je u skladištu!");
                        }
                    }

                    PrikaziMaterijale();
                }
            }
        }
    }
}
