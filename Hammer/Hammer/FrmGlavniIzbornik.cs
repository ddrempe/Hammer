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
    }
}
