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
    public partial class frmAlati : Form
    {
        public frmAlati()
        {
            InitializeComponent();
            PrikaziAlate();
        }
        private void PrikaziAlate()
        {
            BindingList<alati> listaAlata = null;
            using (var db = new Entities())
            {
                listaAlata = new BindingList<alati>(db.alati.ToList());
            }
            alatiBindingSource.DataSource = listaAlata;
        }

        private void btnDodajAlat_Click(object sender, EventArgs e)
        {
            frmDodajAlat formaDodajAlat = new frmDodajAlat();
            formaDodajAlat.ShowDialog();
            PrikaziAlate();
        }

        private void btnUrediAlat_Click(object sender, EventArgs e)
        {
            alati odabraniAlat = alatiBindingSource.Current as alati;
            if (odabraniAlat != null)
            {
                frmDodajAlat formaUrediAlat = new frmDodajAlat(odabraniAlat);
                formaUrediAlat.ShowDialog();
                PrikaziAlate();
            }
        }

        private void btnObrisiAlat_Click(object sender, EventArgs e)
        {
            alati odabraniAlat = alatiBindingSource.Current as alati;
            if (odabraniAlat != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {

                        db.alati.Attach(odabraniAlat);

                        if (odabraniAlat.gradilista.Count == 0)
                        {
                            db.alati.Remove(odabraniAlat);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati alat koji je dodijeljen gradilištu!");
                        }
                    }

                    PrikaziAlate();
                }
            }
        }
    }
}
