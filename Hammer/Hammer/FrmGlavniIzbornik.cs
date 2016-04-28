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
    public partial class FrmGlavniIzbornik : Form
    {
        public FrmGlavniIzbornik()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var prijava = new FrmPrijava();
            prijava.Closed += (s, args) => this.Close();
            prijava.Show();
        }

        private void FrmGlavniIzbornik_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var evidencijaGiZ = new FrmEvidencijaGiZ();
            evidencijaGiZ.Closed += (s, args) => this.Close();
            evidencijaGiZ.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var evidencijaASiV = new FrmEvidencijaASiV();
            evidencijaASiV.Closed += (s, args) => this.Close();
            evidencijaASiV.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var evidencijaSiM= new FrmEvidencijaSiM();
            evidencijaSiM.Closed += (s, args) => this.Close();
            evidencijaSiM.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var evidencijaDiK = new FrmEvidencijaDiK();
            evidencijaDiK.Closed += (s, args) => this.Close();
            evidencijaDiK.Show();
        }
    }
}
