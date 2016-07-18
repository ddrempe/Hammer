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
    public partial class FrmEvidencijaGiAlati : Form
    {
        public FrmEvidencijaGiAlati()
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
        private void PrikaziAlate(gradilista gradiliste)
        {
            BindingList<alati> listaAlata = null;
            using (var db = new Entities())
            {
                var x = db.gradilista.FirstOrDefault(m => m.ID == gradiliste.ID);
                listaAlata = new BindingList<alati>(x.alati.ToList<alati>());
            }
            alatiBindingSource.DataSource = listaAlata;
        }

        private void dgvGradilista_SelectionChanged(object sender, EventArgs e)
        {
            gradilista trenutnoGradiliste = gradilistaBindingSource.Current as gradilista;
            if (trenutnoGradiliste != null)
            {
                PrikaziAlate(trenutnoGradiliste);
            }
        }

        private void btnDodajAlat_Click(object sender, EventArgs e)
        {
            gradilista trenutnoGradiliste = gradilistaBindingSource.Current as gradilista;
            frmDodijeliAlat formaDodijeli = new frmDodijeliAlat(trenutnoGradiliste);
            formaDodijeli.ShowDialog();
            PrikaziAlate(trenutnoGradiliste);
        }

        private void btnObrisiAlat_Click(object sender, EventArgs e)
        {
            alati odabraniAlat = alatiBindingSource.Current as alati;
            gradilista trenutnoGradiliste = gradilistaBindingSource.Current as gradilista;
            if (odabraniAlat != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {
                        BindingList<alati> listaAlata = null;
                        listaAlata = new BindingList<alati>(db.alati.ToList());
                        var gradiliste = db.gradilista.FirstOrDefault(m => m.ID == trenutnoGradiliste.ID);
                        alati alat = new alati();

                        foreach (var item in db.alati)
                        {
                            if (item.id == odabraniAlat.id)
                                alat = item;
                        }
                        alat.gradilista.Remove(gradiliste);
                        db.SaveChanges();
                    }
                }
            }
            PrikaziAlate(trenutnoGradiliste);
        }
    }
}
