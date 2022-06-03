using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace berber_program
{
    public partial class frmraporlar : Form
    {
        public frmraporlar()
        {
            InitializeComponent();
        }

        private void frmraporlar_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            frmmenu frm = new frmmenu();
            this.Close();
            frm.Show();
        }

        private void btnerkek1_Click(object sender, EventArgs e)
        {
            istatistik(1, Color.Blue);
        }

        private void btnkadin2_Click(object sender, EventArgs e)
        {
            istatistik(2, Color.Pink);
        }

        private void btnicecek3_Click(object sender, EventArgs e)
        {
            istatistik(3, Color.DarkGray);
        }
        private void istatistik(int katid,Color renk)
        {
            chrapor.Palette = ChartColorPalette.None;
            chrapor.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chrapor.Series[0].Color =renk;
            curunler u = new curunler();
            lvistatistik.Items.Clear();
            u.urunlerilisteleistatistikleregoreurunid(lvistatistik, dtbasla, dtbitis, katid);

            if (lvistatistik.Items.Count > 0)
            {
                chrapor.Series["satislar"].Points.Clear();
                for (int i = 0; i < lvistatistik.Items.Count; i++)
                {
                    chrapor.Series["satislar"].Points.AddXY(lvistatistik.Items[i].SubItems[0].Text, lvistatistik.Items[i].SubItems[1].Text);
                }

            }
        }

      
        private void chrapor_Click(object sender, EventArgs e)
        {

        }

        private void dtbitis_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
