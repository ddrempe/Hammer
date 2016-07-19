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
    public partial class FrmEvidencijaZiVozila : Form
    {
        public FrmEvidencijaZiVozila()
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
        private void PrikaziVozila(zaposlenici zaposlenik)
        {
            BindingList<vozni_park> listaVozila = null;
            using (var db = new Entities())
            {
                var x = db.zaposlenici.FirstOrDefault(m => m.oib == zaposlenik.oib);
                listaVozila = new BindingList<vozni_park>(x.vozni_park.ToList<vozni_park>());
            }
            vozniparkBindingSource.DataSource = listaVozila;
        }

        private void dgvZaposlenici_SelectionChanged(object sender, EventArgs e)
        {
            zaposlenici trenutniZaposlenik = zaposleniciBindingSource.Current as zaposlenici;
            if (trenutniZaposlenik != null)
            {
                PrikaziVozila(trenutniZaposlenik);
            }
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            zaposlenici trenutniZaposlenik = zaposleniciBindingSource.Current as zaposlenici;
            frmDodijeliVozilo formaDodijeli = new frmDodijeliVozilo(trenutniZaposlenik);
            formaDodijeli.ShowDialog();
            PrikaziVozila(trenutniZaposlenik);
        }

        private void btnObrisiVozilo_Click(object sender, EventArgs e)
        {
            vozni_park odabranoVozilo = vozniparkBindingSource.Current as vozni_park;
            zaposlenici trenutniZaposlenik = zaposleniciBindingSource.Current as zaposlenici;
            if (odabranoVozilo != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {
                        BindingList<vozni_park> listaVozila = null;
                        listaVozila = new BindingList<vozni_park>(db.vozni_park.ToList());
                        var zaposlenik = db.zaposlenici.FirstOrDefault(m => m.oib == trenutniZaposlenik.oib);
                        vozni_park vozilo = new vozni_park();

                        foreach (var item in db.vozni_park)
                        {
                            if (item.id == odabranoVozilo.id)
                                vozilo = item;
                        }
                        vozilo.zaposlenici.Remove(zaposlenik);
                        db.SaveChanges();
                    }
                }
            }
            PrikaziVozila(trenutniZaposlenik);
        }
    }
}
