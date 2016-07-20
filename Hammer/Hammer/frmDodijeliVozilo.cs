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
            using (var db = new Entities())
            {
                if (cmbVozilo.SelectedValue != null) {
                    int sumaVozila = 1;
                    int idOdabranogVozila = int.Parse(cmbVozilo.SelectedValue.ToString());

                    foreach (var item in db.zaposlenici) {
                        foreach (var redak in item.vozni_park) {
                            if (redak.id == int.Parse(cmbVozilo.SelectedValue.ToString())) {
                                sumaVozila++;
                            }
                        }
                    }

                    var odabranoVozilo = db.vozni_park.FirstOrDefault(m => m.id == idOdabranogVozila);

                    if (sumaVozila > odabranoVozilo.kolicina)
                    {
                        MessageBox.Show("Sva vozila odabranog modela su već dodijeljena!");
                    }

                    else
                    {
                        BindingList<vozni_park> listaVozila = null;
                        listaVozila = new BindingList<vozni_park>(db.vozni_park.ToList());
                        var zaposlenik = db.zaposlenici.FirstOrDefault(m => m.oib == zaposlenikDodijeli.oib);
                        vozni_park vozilo = new vozni_park();
                        vozni_park voziloOznaceno = new vozni_park() { id = int.Parse(cmbVozilo.SelectedValue.ToString()) };
                        foreach (var item in db.vozni_park)
                        {
                            if (item.id == voziloOznaceno.id)
                                vozilo = item;
                        }
                        vozilo.zaposlenici.Add(zaposlenik);
                        db.SaveChanges();
                    }
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
