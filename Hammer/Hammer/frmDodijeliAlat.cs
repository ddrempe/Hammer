using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DodijeliSpremi;

namespace Hammer
{
    public partial class frmDodijeliAlat : Form
    {
        private gradilista gradilisteDodijeli;
        public frmDodijeliAlat(gradilista gradiliste)
        {
            InitializeComponent();
            gradilisteDodijeli = gradiliste;
        }

        private void PrikaziAlate()
        {
            BindingList<alati> listaAlata = null;
            List<alati> listaPostojecih = new List<alati>();

            using (var db = new Entities())
            {
                gradilista gradiliste = db.gradilista.FirstOrDefault(m => m.ID == gradilisteDodijeli.ID);
                foreach (var item in db.alati)
                {
                    foreach (var alat in gradiliste.alati)
                    {
                        if (alat == item)
                        {
                            listaPostojecih.Add(alat);
                        }
                    }
                }
                listaAlata = new BindingList<alati>(db.alati.ToList());
            }
            foreach (var alat in listaPostojecih)
            {
                listaAlata.Remove(alat);
            }
            alatiBindingSource.DataSource = listaAlata;
        }

        private void frmDodijeliAlat_Load(object sender, EventArgs e)
        {
            if (gradilisteDodijeli != null)
            {
                txtGradiliste.Text = gradilisteDodijeli.naziv;
                txtGradiliste.Enabled = false;
            }
            PrikaziAlate();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (cmbAlat.SelectedValue != null){
                int idOdabranogAlata = int.Parse(cmbAlat.SelectedValue.ToString());

                if (DodijeliAlat.Provjeri(idOdabranogAlata)==false)
                {
                    MessageBox.Show("Sve jedinice odabranog alata su već dodijeljena gradilištima!");
                }
                else
                {
                    DodijeliAlat.Spremi(idOdabranogAlata, gradilisteDodijeli);
                }
            }
            Close();
        }
    }
}
