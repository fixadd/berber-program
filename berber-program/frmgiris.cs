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
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }
        cgenel gnl = new cgenel();
        private void Form1_Load(object sender, EventArgs e)
        {
            cpersonel p = new cpersonel();
            p.personelGetbyInformation(cbkullanici);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cpersonel p = (cpersonel)cbkullanici.SelectedItem;
            cgenel._personelid = p.Personelid;
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            cpersonel p = new cpersonel();
            bool result = p.personelEntryControl(txtsifre.Text, cgenel._personelid);

            if (result)
            {
                this.Hide();
                frmmenu menu = new frmmenu();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Şifre yanlış !!!", "hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btngiris_Enter(object sender, EventArgs e)
        {

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




        private void txtsifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cpersonel p = new cpersonel();
                bool result = p.personelEntryControl(txtsifre.Text, cgenel._personelid);

                if (result)
                {
                    this.Hide();
                    frmmenu menu = new frmmenu();
                    menu.Show();

                }
                else
                {
                    MessageBox.Show("Şifre yanlış !!!", "hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            

        }

        private void txtsifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
