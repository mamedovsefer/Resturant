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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Isciler i = new Isciler();
            i.isciGetInfo(comboBox1);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Connection c = new Connection();
            Isciler i = new Isciler();
            bool result = i.personelEntryControl(textBox1.Text,Connection._isciId);
            if (result)
            {
                IsciHereketleri ih = new IsciHereketleri();
                ih.PersonelId = Connection._isciId;
                ih.Islem = "Giris yapti";
                ih.Tarix = DateTime.Now;
                ih.IsciAutoSave(ih);

                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Sifre sehvdi", "Uyari !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Isciler i = (Isciler)comboBox1.SelectedItem;
            Connection._isciId = i.IsciId;
           Connection._gorevId = i.IsciGorevId;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cixmaq istediyinizden eminmisiniz?","Uyari !!!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
