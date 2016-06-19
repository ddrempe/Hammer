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
    public partial class frmDodajZaposlenik : Form
    {
        public frmDodajZaposlenik()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                zaposlenici zaposlenik = new zaposlenici();
                {
                    zaposlenik.oib = txtOIB.Text;
                    zaposlenik.ime = txtIme.Text;
                    zaposlenik.prezime = txtPrezime.Text;
                    zaposlenik.gradilista_id = comboBox1.SelectedIndex;
                    zaposlenik.strucna_sprema = txtStrucnaSprema.Text;
                    zaposlenik.od = dtpOd.Value;
                };
                db.zaposlenici.Add(zaposlenik);
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
