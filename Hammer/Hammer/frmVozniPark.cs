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
    public partial class frmVozniPark : Form
    {
        public frmVozniPark()
        {
            InitializeComponent();
            PrikaziVozila();
        }
        private void PrikaziVozila()
        {
            BindingList<vozni_park> listaVozila = null;
            using (var db = new Entities())
            {
                listaVozila = new BindingList<vozni_park>(db.vozni_park.ToList());
            }
            vozniparkBindingSource.DataSource = listaVozila;
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            frmDodajVozilo formaDodajVozilo = new frmDodajVozilo();
            formaDodajVozilo.ShowDialog();
            PrikaziVozila();
        }

        private void btnUrediVozilo_Click(object sender, EventArgs e)
        {
            vozni_park odabranoVozilo = vozniparkBindingSource.Current as vozni_park;
            if (odabranoVozilo != null)
            {
                frmDodajVozilo formaUrediVozilo = new frmDodajVozilo(odabranoVozilo);
                formaUrediVozilo.ShowDialog();
                PrikaziVozila();
            }
        }

        private void btnObrisiVozilo_Click(object sender, EventArgs e)
        {
            vozni_park odabranoVozilo = vozniparkBindingSource.Current as vozni_park;
            if (odabranoVozilo != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {

                        db.vozni_park.Attach(odabranoVozilo);

                        if (odabranoVozilo.zaposlenici.Count == 0)
                        {
                            db.vozni_park.Remove(odabranoVozilo);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati vozilo koje je dodijeljeno radniku!");
                        }
                    }
                    PrikaziVozila();
                }
            }
        }
    }
}
