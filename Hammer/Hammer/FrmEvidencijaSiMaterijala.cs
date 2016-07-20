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
    public partial class FrmEvidencijaSiMaterijala : Form
    {
        public FrmEvidencijaSiMaterijala()
        {
            InitializeComponent();
            PrikaziSkladista();
        }
        private void PrikaziSkladista()
        {
            BindingList<skladista> listaSkladista = null;
            using (var db = new Entities())
            {
                listaSkladista = new BindingList<skladista>(db.skladista.ToList());
            }
            skladistaBindingSource.DataSource = listaSkladista;
        }
        private void PrikaziMaterijale(skladista skladiste)
        {
            BindingList<skladiste_materijali> listaSiMaterijala = null;
            using (var db = new Entities())
            {
                var x = db.skladista.FirstOrDefault(m => m.id == skladiste.id);
                listaSiMaterijala = new BindingList<skladiste_materijali>(x.skladiste_materijali.ToList<skladiste_materijali>());
            }
            skladistematerijaliBindingSource.DataSource = listaSiMaterijala;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            skladista trenutnoSkladiste = skladistaBindingSource.Current as skladista;
            if (trenutnoSkladiste != null)
            {
                PrikaziMaterijale(trenutnoSkladiste);
            }
        }

        private void btnDodajSkladiste_Click(object sender, EventArgs e)
        {
            frmDodajSkladiste formaDodajSkladiste = new frmDodajSkladiste();
            formaDodajSkladiste.ShowDialog();
            PrikaziSkladista();
        }

        private void btnUrediSkladiste_Click(object sender, EventArgs e)
        {
            skladista trenutnoSkladiste = skladistaBindingSource.Current as skladista;
            if (trenutnoSkladiste != null)
            {
                frmDodajSkladiste formaUrediSkladiste = new frmDodajSkladiste(trenutnoSkladiste);
                formaUrediSkladiste.ShowDialog();
                PrikaziSkladista();
            }
        }

        private void btnObrisiSkladiste_Click(object sender, EventArgs e)
        {
            skladista trenutnoSkladiste = skladistaBindingSource.Current as skladista;
            if (trenutnoSkladiste != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {

                        db.skladista.Attach(trenutnoSkladiste);

                        if (trenutnoSkladiste.skladiste_materijali.Count == 0)
                        {
                            db.skladista.Remove(trenutnoSkladiste);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati skladište s dodijeljenim materijalom!");
                        }
                    }
                    PrikaziSkladista();
                }
            }
        }

        private void btnDodajMaterijal_Click(object sender, EventArgs e)
        {
            skladista trenutnoSkladiste = skladistaBindingSource.Current as skladista;
            frmDodijeliMaterijal formaDodijeli = new frmDodijeliMaterijal(trenutnoSkladiste);
            formaDodijeli.ShowDialog();
            PrikaziMaterijale(trenutnoSkladiste);
        }

        private void btnObrisiMaterijal_Click(object sender, EventArgs e)
        {
            skladista trenutnoSkladiste = skladistaBindingSource.Current as skladista;
            skladiste_materijali trenutnoSiM = skladistematerijaliBindingSource.Current as skladiste_materijali;
            if (trenutnoSiM != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {
                        db.skladiste_materijali.Attach(trenutnoSiM);
                        db.skladiste_materijali.Remove(trenutnoSiM);
                        db.SaveChanges();
                    }
                }
            }
            PrikaziMaterijale(trenutnoSkladiste);
        }

        private void btnUrediMaterijal_Click(object sender, EventArgs e)
        {
            skladiste_materijali trenutnoSiM = skladistematerijaliBindingSource.Current as skladiste_materijali;
            if (trenutnoSiM != null)
            {
                frmUrediSiM formaUrediSiM = new frmUrediSiM(trenutnoSiM);
                formaUrediSiM.ShowDialog();
                PrikaziSkladista();
            }
        }
    }
}
