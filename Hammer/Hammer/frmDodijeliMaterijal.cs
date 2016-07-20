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
    public partial class frmDodijeliMaterijal : Form
    {
        private skladista skladisteDodijeli;
        public frmDodijeliMaterijal(skladista skladiste)
        {
            InitializeComponent();
            skladisteDodijeli = skladiste;
        }

        private void PrikaziMaterijale()
        {
            BindingList<materijali> listaMaterijala = null;
            List<materijali> listaPostojecih = new List<materijali>();

            using (var db = new Entities())
            {
                skladista skladiste = db.skladista.FirstOrDefault(m => m.id == skladisteDodijeli.id);
                foreach (var item in db.materijali)
                {
                    foreach (var materijal in skladiste.skladiste_materijali)
                    {
                        if (materijal.materijali_id == item.id)
                        {
                            listaPostojecih.Add(item);
                        }
                    }
                }
                listaMaterijala = new BindingList<materijali>(db.materijali.ToList());
            }
            foreach (var materijal in listaPostojecih)
            {
                listaMaterijala.Remove(materijal);
            }
            materijaliBindingSource.DataSource = listaMaterijala;
        }

        private void frmDodijeliMaterijal_Load(object sender, EventArgs e)
        {
            if (skladisteDodijeli != null)
            {
                txtSkladiste.Text = skladisteDodijeli.id.ToString();
                txtSkladiste.Enabled = false;
            }
            PrikaziMaterijale();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                skladiste_materijali SiM = new skladiste_materijali();
                SiM.materijali_id = int.Parse(cmbMaterijal.SelectedValue.ToString());
                SiM.skladiste_id = int.Parse(txtSkladiste.Text);
                SiM.opis = txtOpis.Text;

                int rkolicina;
                if (int.TryParse((txtKolicina.Text), out rkolicina)) SiM.kolicina = rkolicina;
                else MessageBox.Show("Greška kod validacije korisničkog unosa! (Količina)");

                db.skladiste_materijali.Add(SiM);
                db.SaveChanges();
            }
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
