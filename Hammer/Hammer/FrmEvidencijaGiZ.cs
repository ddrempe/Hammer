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
    public partial class FrmEvidencijaGiZ : Form
    {
        public FrmEvidencijaGiZ()
        {
            InitializeComponent();
            PrikaziGradilista();
        }
        private void PrikaziGradilista()
        {
            BindingList<gradilista> listaGradilista = null;
            using (var db = new Entities())
            {
                listaGradilista = new BindingList<gradilista>(db.gradilista.ToList());
            }
            gradilistaBindingSource.DataSource = listaGradilista;
        }
        private void PrikaziZaposlenike(gradilista gradiliste)
        {
            BindingList<zaposlenici> listaZaposlenika = null;
            using (var db = new Entities())
            {
                var x = db.gradilista.FirstOrDefault(m => m.ID == gradiliste.ID);
                listaZaposlenika = new BindingList<zaposlenici>(x.zaposlenici.ToList<zaposlenici>());
            }
            zaposleniciBindingSource.DataSource = listaZaposlenika;
        }
        private void btnDodajGradiliste_Click(object sender, EventArgs e)
        {
            frmDodajGradiliste formaDodajGradiliste = new frmDodajGradiliste();
            formaDodajGradiliste.ShowDialog();
            PrikaziGradilista();
        }

        private void btnUrediGradiliste_Click(object sender, EventArgs e)
        {
            gradilista trenutnoGradiliste = gradilistaBindingSource.Current as gradilista;
            if (trenutnoGradiliste != null)
            {
                frmDodajGradiliste formaUrediGradiliste = new frmDodajGradiliste(trenutnoGradiliste);
                formaUrediGradiliste.ShowDialog();
                PrikaziGradilista();
            }
        }

        private void btnObrisiGradiliste_Click(object sender, EventArgs e)
        {
            gradilista trenutnoGradiliste = gradilistaBindingSource.Current as gradilista;
            if (trenutnoGradiliste != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {

                        db.gradilista.Attach(trenutnoGradiliste);

                        if (trenutnoGradiliste.zaposlenici.Count == 0)
                        {
                            db.gradilista.Remove(trenutnoGradiliste);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati gradilište koje sadrže zaposlenike!");
                        }
                    }

                    PrikaziGradilista();
                }
            }
        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            gradilista trenutnoGradiliste = gradilistaBindingSource.Current as gradilista;
            frmDodijeliZaposlenika formaDodijeli = new frmDodijeliZaposlenika(trenutnoGradiliste);
            formaDodijeli.ShowDialog();
            PrikaziZaposlenike(trenutnoGradiliste);
        }

        private void btnObrisiZaposlenika_Click(object sender, EventArgs e)
        {
            zaposlenici odabraniZaposlenik = zaposleniciBindingSource.Current as zaposlenici;
            gradilista trenutnoGradiliste = gradilistaBindingSource.Current as gradilista;
            if (odabraniZaposlenik != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {
                        BindingList<zaposlenici> listaZaposlenika = null;
                        listaZaposlenika = new BindingList<zaposlenici>(db.zaposlenici.ToList());
                        var gradiliste = db.gradilista.FirstOrDefault(m => m.ID == trenutnoGradiliste.ID);
                        zaposlenici zaposlenik = new zaposlenici();
                       
                        foreach (var item in db.zaposlenici)
                        {
                            if (item.oib == odabraniZaposlenik.oib)
                                zaposlenik = item;
                        }
                        zaposlenik.gradilista.Remove(gradiliste);
                        db.SaveChanges();
                    }
                }
            }
            PrikaziZaposlenike(trenutnoGradiliste);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            gradilista trenutnoGradiliste = gradilistaBindingSource.Current as gradilista;
            if (trenutnoGradiliste != null)
            {
                PrikaziZaposlenike(trenutnoGradiliste);
            }
        }
    }
}
