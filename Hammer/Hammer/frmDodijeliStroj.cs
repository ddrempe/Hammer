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
    public partial class frmDodijeliStroj : Form
    {
        private gradilista gradilisteDodijeli;
        public frmDodijeliStroj(gradilista gradiliste)
        {
            InitializeComponent();
            gradilisteDodijeli = gradiliste;
        }

        private void frmDodijeliStroj_Load(object sender, EventArgs e)
        {
            if (gradilisteDodijeli != null)
            {
                txtGradiliste.Text = gradilisteDodijeli.naziv;
                txtGradiliste.Enabled = false;
            }
            PrikaziStrojeve();
        }

        private void PrikaziStrojeve()
        {
            BindingList<strojevi> listaStrojeva = null;
            List<strojevi> listaPostojecih = new List<strojevi>();

            using (var db = new Entities())
            {
                gradilista gradiliste = db.gradilista.FirstOrDefault(m => m.ID == gradilisteDodijeli.ID);
                foreach (var item in db.gradilista)
                {
                    foreach (var stroj in item.strojevi)
                    {
                        listaPostojecih.Add(stroj);
                    }
                }
                listaStrojeva = new BindingList<strojevi>(db.strojevi.ToList());
            }
            foreach (var stroj in listaPostojecih)
            {
                listaStrojeva.Remove(stroj);
            }
            strojeviBindingSource.DataSource = listaStrojeva;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                if (cmbStroj.SelectedValue != null)
                {
                    BindingList<strojevi> listaStrojeva = null;
                    listaStrojeva = new BindingList<strojevi>(db.strojevi.ToList());
                    var gradiliste = db.gradilista.FirstOrDefault(m => m.ID == gradilisteDodijeli.ID);
                    strojevi stroj = new strojevi();
                    strojevi strojOznacen = new strojevi() { id = int.Parse(cmbStroj.SelectedValue.ToString()) };
                    foreach (var item in db.strojevi)
                    {
                        if (item.id == strojOznacen.id)
                            stroj = item;
                    }
                    stroj.gradilista.Add(gradiliste);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Nema strojeva na raspolaganju!");
                }
            }
            Close();
        }
    }
}
