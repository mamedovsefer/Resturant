using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Villa
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnStollar_Click(object sender, EventArgs e)
        {
            frmStollar frm = new frmStollar();
            this.Close();
            frm.Show();
        }

        private void btnRezerv_Click(object sender, EventArgs e)
        {
            frmRezerv frm = new frmRezerv();
            this.Close();
            frm.Show();
        }

        private void btnPaketServis_Click(object sender, EventArgs e)
        {
            frmSifaris frm = new frmSifaris();
            this.Close();
            frm.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            frmMusteriler frm = new frmMusteriler();
            this.Close();
            frm.Show();
        }

        private void btnKasaIslem_Click(object sender, EventArgs e)
        {
            frmKassaIslem frm = new frmKassaIslem();
            this.Close();
            frm.Show();
        }

        private void btnKuxna_Click(object sender, EventArgs e)
        {
            frmKuxna frm = new frmKuxna();
            this.Close();
            frm.Show();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            frmRaporlar frm = new frmRaporlar();
            this.Close();
            frm.Show();

        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            frmAyarlar frm = new frmAyarlar();
            this.Close();
            frm.Show();
        }

        private void btnKilit_Click(object sender, EventArgs e)
        {
            frmKilit frm = new frmKilit();
            this.Close();
            frm.Show();
        }

        private void btnCixis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cixmaq istediyinizden eminmisiniz?", "Uyari !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
