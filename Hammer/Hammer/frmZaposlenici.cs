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
    public partial class frmZaposlenici : Form
    {
        public frmZaposlenici()
        {
            InitializeComponent();
            PrikaziZaposlenike();
        }
        private void PrikaziZaposlenike()
        {
            BindingList<zaposlenici> listaZaposlenika = null;
            using (var db = new Entities())
            {
                listaZaposlenika = new BindingList<zaposlenici>(db.zaposlenici.ToList());
            }
            zaposleniciBindingSource.DataSource = listaZaposlenika;
        }
        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            frmDodajZaposlenik formaDodajZaposlenika = new frmDodajZaposlenik( );
            formaDodajZaposlenika.ShowDialog();
            PrikaziZaposlenike();
        }

        private void btnUrediZaposlenika_Click(object sender, EventArgs e)
        {
            zaposlenici odabraniZaposlenik = zaposleniciBindingSource.Current as zaposlenici;
            if (odabraniZaposlenik != null)
            {
                frmDodajZaposlenik formaUrediZaposlenika = new frmDodajZaposlenik(odabraniZaposlenik);
                formaUrediZaposlenika.ShowDialog();
                PrikaziZaposlenike();
            }
        }

        private void btnObrisiZaposlenika_Click(object sender, EventArgs e)
        {
            zaposlenici odabraniZaposlenik = zaposleniciBindingSource.Current as zaposlenici;
            if (odabraniZaposlenik != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {

                        db.zaposlenici.Attach(odabraniZaposlenik);

                        if (odabraniZaposlenik.gradilista.Count == 0)
                        {
                            db.zaposlenici.Remove(odabraniZaposlenik);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati zaposlenika koji radi na gradilištu!");
                        }
                    }

                    PrikaziZaposlenike();
                }
            }
        }
    }
}
