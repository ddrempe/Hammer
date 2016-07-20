using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hammer
{
    public partial class frmGlavniIzbornik : Form
    {
        public frmGlavniIzbornik()
        {
            InitializeComponent();
        }
        FrmEvidencijaGiZ forma1;
        frmZaposlenici forma2;
        private void evidencijaZaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma2 == null)
            {
                forma2 = new frmZaposlenici();
                forma2.MdiParent = this;
                forma2.FormClosed += new FormClosedEventHandler(Forma2_FormClosed);
                forma2.Show();
            }
            else
            {
                forma2.Activate();
            }
        }

        private void Forma2_FormClosed(object sender, FormClosedEventArgs e)
        {
            forma2 = null;
        }

        private void Forma1_FormClosed(object sender, FormClosedEventArgs e)
        {
            forma1 = null;
        }

        private void gradilištaIDodjeljivanjeZaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma1 == null)
            {
                forma1 = new FrmEvidencijaGiZ();
                forma1.MdiParent = this;
                forma1.FormClosed += new FormClosedEventHandler(Forma1_FormClosed);
                forma1.Show();
            }
            else
            {
                forma1.Activate();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showMyHelp();
        }
        private void showMyHelp()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            path = "file://" + Path.Combine(path, "..\\..\\help.chm");
            Help.ShowHelp(this, path);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                showMyHelp();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Pokretanje forme za pregled alata
        frmAlati forma3;
        private void evidencijaAlataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma3 == null)
            {
                forma3 = new frmAlati();
                forma3.MdiParent = this;
                forma3.FormClosed += new FormClosedEventHandler(Forma3_FormClosed);
                forma3.Show();
            }
            else
            {
                forma3.Activate();
            }
        }
        private void Forma3_FormClosed(object sender, FormClosedEventArgs e)
        {
            forma3 = null;
        }

        //Pokretanje forme za dodjeljivanje alata gradilištima
        FrmEvidencijaGiAlati forma4;
        private void gradilištaIDodjeljivanjeAlataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma4 == null)
            {
                forma4 = new FrmEvidencijaGiAlati();
                forma4.MdiParent = this;
                forma4.FormClosed += new FormClosedEventHandler(Forma4_FormClosed);
                forma4.Show();
            }
            else
            {
                forma4.Activate();
            }
        }
        private void Forma4_FormClosed(object sender, FormClosedEventArgs e)
        {
            forma4 = null;
        }

        //Pokretanje forme za pregled strojeva
        frmStrojevi forma5;
        private void evidencijaStrojevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma5 == null)
            {
                forma5 = new frmStrojevi();
                forma5.MdiParent = this;
                forma5.FormClosed += new FormClosedEventHandler(Forma5_FormClosed);
                forma5.Show();
            }
            else
            {
                forma5.Activate();
            }
        }
        private void Forma5_FormClosed(object sender, FormClosedEventArgs e)
        {
            forma5 = null;
        }

        //Pokretanje forme za dodjeljivanje strojeva gradilištima
        FrmEvidencijaGiStrojevi forma6;
        private void gradilištaIDodjeljivanjeStrojevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma6 == null)
            {
                forma6 = new FrmEvidencijaGiStrojevi();
                forma6.MdiParent = this;
                forma6.FormClosed += new FormClosedEventHandler(Forma6_FormClosed);
                forma6.Show();
            }
            else
            {
                forma6.Activate();
            }
        }
        private void Forma6_FormClosed(object sender, FormClosedEventArgs e)
        {
            forma6 = null;
        }

        //Pokretanje forme za pregled voznog parka
        frmVozniPark forma7;
        private void evidencijaVoznogParkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma7 == null)
            {
                forma7 = new frmVozniPark();
                forma7.MdiParent = this;
                forma7.FormClosed += new FormClosedEventHandler(Forma7_FormClosed);
                forma7.Show();
            }
            else
            {
                forma7.Activate();
            }
        }
        private void Forma7_FormClosed(object sender, FormClosedEventArgs e)
        {
            forma7 = null;
        }

        //Pokretanje forme za dodjeljivanje vozila zaposlenicima
        FrmEvidencijaZiVozila forma8;
        private void zaposleniciIDodjeljivanjeVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma8 == null)
            {
                forma8 = new FrmEvidencijaZiVozila();
                forma8.MdiParent = this;
                forma8.FormClosed += new FormClosedEventHandler(Forma8_FormClosed);
                forma8.Show();
            }
            else
            {
                forma8.Activate();
            }
        }
        private void Forma8_FormClosed(object sender, FormClosedEventArgs e)
        {
            forma8 = null;
        }

        //Pokretanje forme za pregled materijala
        frmMaterijali forma9;
        private void evidencijaMaterijalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma9 == null)
            {
                forma9 = new frmMaterijali();
                forma9.MdiParent = this;
                forma9.FormClosed += new FormClosedEventHandler(Forma9_FormClosed);
                forma9.Show();
            }
            else
            {
                forma9.Activate();
            }
        }
        private void Forma9_FormClosed(object sender, FormClosedEventArgs e)
        {
            forma9 = null;
        }

        //Pokretanje forme za dodjeljivanje materijala skladištima
        FrmEvidencijaSiMaterijala forma10;
        private void skladištaIDodjeljivanjeMaterijalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma10 == null)
            {
                forma10 = new FrmEvidencijaSiMaterijala();
                forma10.MdiParent = this;
                forma10.FormClosed += new FormClosedEventHandler(Forma10_FormClosed);
                forma10.Show();
            }
            else
            {
                forma10.Activate();
            }
        }
        private void Forma10_FormClosed(object sender, FormClosedEventArgs e)
        {
            forma10 = null;
        }
    }
}
