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
    public partial class frmbill : Form
    {
        public frmbill()
        {
            InitializeComponent();
        }

        

        private void rbnakit_CheckedChanged(object sender, EventArgs e)
        {

        }

       

       
        private void btngeri_Click_1(object sender, EventArgs e)
        {
            frmmenu frm = new frmmenu();
            this.Close();
            frm.Show();
        }
        csiparis cs = new csiparis();
        private void frmbill_Load(object sender, EventArgs e)
        {
            lbadisyonid.Text = cgenel._adisyonid;
            txtindirimtutari.TextChanged += new EventHandler(txtindirimtutari_TextChanged);
            cs.getbyorder(lvurunler, Convert.ToInt32(lbadisyonid.Text));
            if (lvurunler.Items.Count>0)
            {
                decimal toplam = 0;
                for (int i = 0; i < lvurunler.Items.Count; i++)
                {
                    toplam +=  Convert.ToDecimal(lvurunler.Items[i].SubItems[3].Text);
                }
                lbltoplamtutar.Text =string.Format("{0:#.##}", toplam);
                lblodenecek.Text = string.Format("{0:#.##}", toplam);
                decimal kdv = Convert.ToDecimal(lblodenecek.Text) * 18 / 100;
                lblkdv.Text = string.Format("{0:#.##}", kdv);
            }
            gbindirim.Visible = false;
            txtindirimtutari.Clear();
            
        }

        private void txtindirimtutari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtindirimtutari.Text) < Convert.ToDecimal(lbltoplamtutar.Text))
                {
                    try
                    {
                        lblindirim.Text = string.Format("{0:0.00}", Convert.ToDecimal(txtindirimtutari.Text));
                    }
                    catch (Exception)
                    {
                        lblindirim.Text = string.Format("{0:0.00}", 0);
                    }
                }
                else
                {
                    MessageBox.Show("İndirim tutarı toplam tutardan fazla olamaz !!");
                }
            }
            catch (Exception)
            {
                lblindirim.Text = string.Format("{0:0.00}", 0);
            }
        }

        private void chkindirim_CheckedChanged(object sender, EventArgs e)
        {
            if(chkindirim.Checked)
            {
                gbindirim.Visible = true;
                txtindirimtutari.Clear();
            }
            else
            {
                gbindirim.Visible = false;
                txtindirimtutari.Clear();
            }
        }

        private void lblindirim_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lblindirim.Text) > 0)
            {
                decimal odenecek = 0;
                lblodenecek.Text = lbltoplamtutar.Text;
                odenecek = Convert.ToDecimal(lblodenecek.Text) - Convert.ToDecimal(lblindirim.Text);
               lblodenecek.Text = string.Format("{0:0.00}", odenecek);
            }
            decimal kdv = Convert.ToDecimal(lblodenecek.Text)*18/100;
            lblkdv.Text= string.Format("{0:0.00}",kdv);
        }

        private void lbadisyonid_Click(object sender, EventArgs e)
        {

        }

        ccalisanlar calisanlar = new ccalisanlar();
        private void hesapkapatbtn_Click(object sender, EventArgs e)
        {
            int calisanid = calisanlar.TableGetbyNumber(cgenel._ButtonName);
            int odemeturid = 0;
            if (rbnakit.Checked)
            {
                odemeturid = 1;
            }
            if (rbkredikarti.Checked)
            {
                odemeturid = 2;
            }
            codeme odeme = new codeme();
            // adisyonid,odemeturuid,aratoplam,kdvtutari,toplamtutar,indirim
            odeme.Adisyonid= Convert.ToInt32(lbadisyonid.Text);
            odeme.Odemeturuid = odemeturid;
            odeme.Aratoplam =Convert.ToDecimal(lblodenecek.Text);
            odeme.Kdvtutari = Convert.ToDecimal(lblkdv.Text);
            odeme.Toplamtutar = Convert.ToDecimal(lbltoplamtutar.Text);
            odeme.Indirim = Convert.ToDecimal(lblindirim.Text);


            bool result = odeme.billclose(odeme);
            if (result)
            {
                MessageBox.Show("Hesap Kapatılmıştır.");
                calisanlar.setchangetablestate(Convert.ToString(calisanid), 1);

                cadisyon a = new cadisyon();
                a.adisyonclose(Convert.ToInt32(lbadisyonid.Text), 0);

                this.Close();
                frmcalisan frm = new frmcalisan();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hesap kapatırken hata oluştu..!!!");
            }



        }

        private void hesapozetbtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        Font baslik = new Font("verdana", 15, FontStyle.Bold);
        Font altbaslik = new Font("verdana", 12, FontStyle.Regular);
        Font icerik = new Font("verdana", 10);
        SolidBrush sb = new SolidBrush(Color.Black);

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Kırboğa Berber", baslik, sb, 350, 100, st);

            e.Graphics.DrawString("--------------", altbaslik, sb, 350, 120, st);
            e.Graphics.DrawString("ÜrünAdı                   Adet                 Fiyat", altbaslik, sb, 150, 250, st);
            e.Graphics.DrawString("-----------------------------------------------------", altbaslik, sb, 150, 280, st);
            for (int i = 0; i < lvurunler.Items.Count; i++)
            {
                e.Graphics.DrawString(lvurunler.Items[i].SubItems[0].Text, icerik, sb, 150, 300 + i * 30, st);
                e.Graphics.DrawString(lvurunler.Items[i].SubItems[1].Text, icerik, sb, 350, 300 + i * 30, st);
                e.Graphics.DrawString( lvurunler.Items[i].SubItems[3].Text, icerik, sb, 420, 300 + i * 30, st);
            }
            e.Graphics.DrawString("---------------------------------------------------------", altbaslik, sb, 150, 300 + 30 * lvurunler.Items.Count, st);
            e.Graphics.DrawString("İndirim Tutarı     :---------------" + lblindirim.Text + "TL", altbaslik, sb, 250, 300 + 30 * (lvurunler.Items.Count + 1), st);
            e.Graphics.DrawString("KDV Tutarı         :---------------" + lblkdv.Text + "TL", altbaslik, sb, 250, 300 + 30 * (lvurunler.Items.Count + 2), st);
            e.Graphics.DrawString("Toplam Tutar       :---------------" + lbltoplamtutar.Text + "TL", altbaslik, sb, 250, 300 + 30 * (lvurunler.Items.Count + 3), st);
            e.Graphics.DrawString("Ödeneceği Tutar    :---------------"+ lblodenecek.Text + "TL", altbaslik, sb, 250, 300 + 30 * (lvurunler.Items.Count + 4), st);
        

    }

        private void lvurunler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
