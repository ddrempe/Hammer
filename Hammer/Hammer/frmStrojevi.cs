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
    public partial class frmStrojevi : Form
    {
        public frmStrojevi()
        {
            InitializeComponent();
            PrikaziStrojeve();
        }
        private void PrikaziStrojeve()
        {
            BindingList<strojevi> listaStrojeva = null;
            using (var db = new Entities())
            {
                listaStrojeva = new BindingList<strojevi>(db.strojevi.ToList());
            }
            strojeviBindingSource.DataSource = listaStrojeva;
        }

        private void btnDodajStroj_Click(object sender, EventArgs e)
        {
            frmDodajStroj formaDodajStroj = new frmDodajStroj();
            formaDodajStroj.ShowDialog();
            PrikaziStrojeve();
        }

        private void btnUrediStroj_Click(object sender, EventArgs e)
        {
            strojevi odabraniStroj = strojeviBindingSource.Current as strojevi;
            if (odabraniStroj != null)
            {
                frmDodajStroj formaUrediStroj = new frmDodajStroj(odabraniStroj);
                formaUrediStroj.ShowDialog();
                PrikaziStrojeve();
            }
        }

        private void btnObrisiStroj_Click(object sender, EventArgs e)
        {
            strojevi odabraniStroj = strojeviBindingSource.Current as strojevi;
            if (odabraniStroj != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {

                        db.strojevi.Attach(odabraniStroj);

                        if (odabraniStroj.gradilista.Count == 0)
                        {
                            db.strojevi.Remove(odabraniStroj);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati stroj koji je dodijeljen gradilištu!");
                        }
                    }
                    PrikaziStrojeve();
                }
            }
        }
    }
}
