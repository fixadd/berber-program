using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace berber_program
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Çıkmak istediğinize eminmisiniz", "hata", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (secenek == DialogResult.No)
            {

            }
        }  
                        
        private void btncalisan_Click_1(object sender, EventArgs e)
        {
            frmcalisan frm = new frmcalisan();
            this.Close();
            frm.Show();
        }

        private void btnurunler_Click_1(object sender, EventArgs e)
        {
            frmurunler frm = new frmurunler();
            this.Close();
            frm.Show();
        }

        private void btnlock_Click(object sender, EventArgs e)
        {
            frmgiris frm = new frmgiris();
            this.Close();
            frm.Show();
        }
        private void btnkasa_Click(object sender, EventArgs e)
        {
            frmkasaislem frm = new frmkasaislem();
            this.Close();
            frm.Show();
        }
        private void btnraporlar_Click_1(object sender, EventArgs e)
        {
            frmraporlar frm = new frmraporlar();
            this.Close();
            frm.Show();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
