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

namespace Villa
{
    public partial class frmStollar : Form
    {
        public frmStollar()
        {
            InitializeComponent();
        }

        private void btnCixis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cixmaq istediyinizden eminmisiniz?", "Uyari !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGeridon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnStol1_Click(object sender, EventArgs e)
        {
            frmSifaris frm = new frmSifaris();
            int uzunluq = btnStol1.Text.Length;

            Connection._ButtonValue = btnStol1.Text.Substring(uzunluq - 5, 5);
            Connection._ButtonName = btnStol1.Name;
            this.Close();
            frm.ShowDialog();
        }
        Connection c = new Connection();
        private void frmStollar_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connection.GetConnectionString());
            SqlCommand cmd = new SqlCommand("Select DURUM,ID from Stollar", con);
            SqlDataReader dr = null;

            while (dr.Read())
            {
                if (true)
                {

                }

            }
        }
    }
}
