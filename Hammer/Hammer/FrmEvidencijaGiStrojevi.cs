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
    public partial class FrmEvidencijaGiStrojevi : Form
    {
        public FrmEvidencijaGiStrojevi()
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
        private void PrikaziStrojeve(gradilista gradiliste)
        {
            BindingList<strojevi> listaStrojeva = null;
            using (var db = new Entities())
            {
                var x = db.gradilista.FirstOrDefault(m => m.ID == gradiliste.ID);
                listaStrojeva = new BindingList<strojevi>(x.strojevi.ToList<strojevi>());
            }
            strojeviBindingSource.DataSource = listaStrojeva;
        }

        private void dgvGradilista_SelectionChanged(object sender, EventArgs e)
        {
            gradilista trenutnoGradiliste = gradilistaBindingSource.Current as gradilista;
            if (trenutnoGradiliste != null)
            {
                PrikaziStrojeve(trenutnoGradiliste);
            }
        }

        private void btnDodajStroj_Click(object sender, EventArgs e)
        {
            gradilista trenutnoGradiliste = gradilistaBindingSource.Current as gradilista;
            frmDodijeliStroj formaDodijeli = new frmDodijeliStroj(trenutnoGradiliste);
            formaDodijeli.ShowDialog();
            PrikaziStrojeve(trenutnoGradiliste);
        }

        private void btnObrisiStroj_Click(object sender, EventArgs e)
        {
            strojevi odabraniStroj = strojeviBindingSource.Current as strojevi;
            gradilista trenutnoGradiliste = gradilistaBindingSource.Current as gradilista;
            if (odabraniStroj != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {
                        BindingList<strojevi> listaStrojeva = null;
                        listaStrojeva = new BindingList<strojevi>(db.strojevi.ToList());
                        var gradiliste = db.gradilista.FirstOrDefault(m => m.ID == trenutnoGradiliste.ID);
                        strojevi stroj = new strojevi();

                        foreach (var item in db.strojevi)
                        {
                            if (item.id == odabraniStroj.id)
                                stroj = item;
                        }
                        stroj.gradilista.Remove(gradiliste);
                        db.SaveChanges();
                    }
                }
            }
            PrikaziStrojeve(trenutnoGradiliste);
        }
    }
}
