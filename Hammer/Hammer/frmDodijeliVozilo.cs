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
    public partial class frmDodijeliVozilo : Form
    {
        private zaposlenici zaposlenikDodijeli;
        public frmDodijeliVozilo(zaposlenici zaposlenik)
        {
            InitializeComponent();
            zaposlenikDodijeli = zaposlenik;
        }

        private void PrikaziVozila()
        {
            BindingList<vozni_park> listaVozila = null;
            List<vozni_park> listaPostojecih = new List<vozni_park>();

            using (var db = new Entities())
            {
                zaposlenici zaposlenik = db.zaposlenici.FirstOrDefault(m => m.oib == zaposlenikDodijeli.oib);
                foreach (var item in db.vozni_park)
                {
                    foreach (var vozilo in zaposlenik.vozni_park)
                    {
                        if (vozilo == item)
                        {
                            listaPostojecih.Add(vozilo);
                        }
                    }
                }
                listaVozila = new BindingList<vozni_park>(db.vozni_park.ToList());
            }
            foreach (var vozilo in listaPostojecih)
            {
                listaVozila.Remove(vozilo);
            }
            vozniparkBindingSource.DataSource = listaVozila;
        }

        private void frmDodijeliVozilo_Load(object sender, EventArgs e)
        {
            if (zaposlenikDodijeli != null)
            {
                txtZaposlenik.Text = zaposlenikDodijeli.prezime;
                txtZaposlenik.Enabled = false;
            }
            PrikaziVozila();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (cmbVozilo.SelectedValue != null) {
                int idOdabranogVozila = int.Parse(cmbVozilo.SelectedValue.ToString());

                if (DodijeliVozilo.Provjeri(idOdabranogVozila)==false)
                {
                    MessageBox.Show("Sva vozila odabranog modela su već dodijeljena!");
                }
                else
                {
                    DodijeliVozilo.Spremi(idOdabranogVozila, zaposlenikDodijeli);
                }
            }
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
