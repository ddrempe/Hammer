using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hammer
{
    public partial class FrmPrijava : Form
    {
public FrmPrijava()
        {
            InitializeComponent();
        }
        private void FrmPrijava_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlConnection con;
            connectionString = "Data Source=31.147.204.119\\PISERVER,1433;Initial Catalog=16033_DB;User ID=16033_User;Password=2GQEdQrM";
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veza nije ostvarena!" + ex.Message);
            }


            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Unesite korisničko ime i lozinku!");
                return;
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM korisnik WHERE username='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    this.Hide();
                    frmGlavniIzbornik glavniIzbornik = new frmGlavniIzbornik();
                    glavniIzbornik.Closed += (s, args) => this.Close();
                    glavniIzbornik.Show();
                }
                else
                {
                    MessageBox.Show("Prijava nije ispravna!");
                } 
              
               
            }
        }
    }
}
