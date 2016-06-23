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
    public partial class frmDodijeliZaposlenika : Form
    {
        private gradilista gradilisteDodijeli;
        public frmDodijeliZaposlenika(gradilista gradiliste)
        {
            InitializeComponent();
            gradilisteDodijeli = gradiliste;
        }
        private void PrikaziZaposlenike()
        {
            BindingList<zaposlenici> listaZaposlenika = null;
            zaposleniciBindingSource.DataSource = listaZaposlenika;
            using (var db = new Entities())
            {
                listaZaposlenika = new BindingList<zaposlenici>(db.zaposlenici.ToList());
            }
            zaposleniciBindingSource.DataSource = listaZaposlenika;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                BindingList<zaposlenici> listaZaposlenika = null;
                listaZaposlenika = new BindingList<zaposlenici>(db.zaposlenici.ToList());
                var gradiliste = db.gradilista.FirstOrDefault(m=>m.ID == gradilisteDodijeli.ID);
                zaposlenici zaposlenik = new zaposlenici();
                zaposlenici zaposlenikOznacen = new zaposlenici() { oib = comboBox1.SelectedValue.ToString() };
                foreach (var item in db.zaposlenici)
                {
                    if (item.oib == zaposlenikOznacen.oib)
                        zaposlenik = item;
                }
                zaposlenik.gradilista.Add(gradiliste);
                db.SaveChanges();
            }
            Close();
        }

        private void frmDodijeliZaposlenika_Load(object sender, EventArgs e)
        {
            if (gradilisteDodijeli != null)
            {
                txtGradiliste.Text = gradilisteDodijeli.naziv;
                txtGradiliste.Enabled = false;
            }
            PrikaziZaposlenike();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
