using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace berber_program
{
    public partial class frmcalisan : Form
    {
        public frmcalisan()
        {
            InitializeComponent();
        }
        cgenel gnl = new cgenel();
        private void frmcalisan_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select durum,id from calisanlar", con);
            SqlDataReader dr = null;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        if (item.Name == "btncalisan" + dr["id"].ToString() && dr["durum"].ToString() == "1")
                        {
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.sinFoto_kopya);
                        }
                        else if (item.Name == "btncalisan" + dr["id"].ToString() && dr["durum"].ToString() == "2")
                        {
                          
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.dolu);

                        }
                    }
                }

            }

        }
        
        private void btngeri_Click(object sender, EventArgs e)
        {
            frmmenu frm = new frmmenu();
            this.Close();
            frm.Show();
        }

        private void btncalisan1_Click_1(object sender, EventArgs e)
        {
            frmsiparis frm = new frmsiparis();
            int uzunluk = btncalisan1.Text.Length;
            cgenel._ButtonValue = btncalisan1.Text.Substring(uzunluk - 8, 8);
            cgenel._ButtonName = btncalisan1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btncalisan2_Click_1(object sender, EventArgs e)
        {
            frmsiparis frm = new frmsiparis();
            int uzunluk = btncalisan2.Text.Length;
            cgenel._ButtonValue = btncalisan2.Text.Substring(uzunluk - 8, 8);
            cgenel._ButtonName = btncalisan2.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btncalisan3_Click_1(object sender, EventArgs e)
        {
            frmsiparis frm = new frmsiparis();
            int uzunluk = btncalisan3.Text.Length;
            cgenel._ButtonValue = btncalisan3.Text.Substring(uzunluk - 8, 8);
            cgenel._ButtonName = btncalisan3.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btncalisan4_Click_1(object sender, EventArgs e)
        {
            frmsiparis frm = new frmsiparis();
            int uzunluk = btncalisan4.Text.Length;
            cgenel._ButtonValue = btncalisan4.Text.Substring(uzunluk - 8, 8);
            cgenel._ButtonName = btncalisan4.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btncalisan5_Click_1(object sender, EventArgs e)
        {
            frmsiparis frm = new frmsiparis();
            int uzunluk = btncalisan5.Text.Length;
            cgenel._ButtonValue = btncalisan5.Text.Substring(uzunluk - 8, 8);
            cgenel._ButtonName = btncalisan5.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btncalisan6_Click_1(object sender, EventArgs e)
        {
            frmsiparis frm = new frmsiparis();
            int uzunluk = btncalisan6.Text.Length;
            cgenel._ButtonValue = btncalisan6.Text.Substring(uzunluk - 8, 8);
            cgenel._ButtonName = btncalisan6.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btncalisan7_Click_1(object sender, EventArgs e)
        {
            frmsiparis frm = new frmsiparis();
            int uzunluk = btncalisan7.Text.Length;
            cgenel._ButtonValue = btncalisan7.Text.Substring(uzunluk - 8, 8);
            cgenel._ButtonName = btncalisan7.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btncalisan8_Click_1(object sender, EventArgs e)
        {
            frmsiparis frm = new frmsiparis();
            int uzunluk = btncalisan8.Text.Length;
            cgenel._ButtonValue = btncalisan8.Text.Substring(uzunluk - 8, 8);
            cgenel._ButtonName = btncalisan8.Name;
            this.Close();
            frm.ShowDialog();
        }
    }
}
