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
    public partial class FrmEvidencijaGiZ : Form
    {
        public FrmEvidencijaGiZ()
        {
            InitializeComponent();
            PrikaziGradilista();
        }
        private void PrikaziTimove()
        {
            BindingList<zaposlenici> listazapolenika = null;
            using (var db = new Entities())
            {
                listazapolenika = new BindingList<zaposlenici>(db.zaposlenici.ToList());
            }
            zaposleniciBindingSource.DataSource = listazapolenika;
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
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var formaDodajZaposlenik = new frmDodajZaposlenik();
            formaDodajZaposlenik.ShowDialog();
        }

        private void btnDodajGradilista_Click(object sender, EventArgs e)
        {
            frmDodajGradilista formaDodajGradilista = new frmDodajGradilista();
            formaDodajGradilista.ShowDialog();
            PrikaziGradilista();
        }

        private void btnIzmijeniGradilista_Click(object sender, EventArgs e)
        {
            gradilista trenutnoGradiliste = gradilistaBindingSource.Current as gradilista;
            if(trenutnoGradiliste != null)
            {
                frmDodajGradilista forma = new frmDodajGradilista(trenutnoGradiliste);
                forma.ShowDialog();
                PrikaziGradilista();
            }
        }

        private void btnObrisiGradilista_Click(object sender, EventArgs e)
        {
            gradilista trenutnoGradiliste = gradilistaBindingSource.Current as gradilista;
            if(trenutnoGradiliste !=null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {
                       
                        db.gradilista.Attach(trenutnoGradiliste);
                        
                        if (trenutnoGradiliste.zaposlenici.Count == 0)
                        {
                            db.gradilista.Remove(trenutnoGradiliste);  
                            db.SaveChanges();   
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati tim koji sadrži studente!");
                        }
                    }

                    PrikaziGradilista();   
                }
            }
        }
    }
}
