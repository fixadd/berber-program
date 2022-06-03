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
    public partial class frmurunler : Form
    {
        public frmurunler()
        {
            InitializeComponent();
        }

        private void frmurunler_Load(object sender, EventArgs e)
        {
            curuncesitleri anakategori = new curuncesitleri();
            anakategori.uruncesitlerinigetircb(cbkategoriler);
            cbkategoriler.Items.Insert(0, "Tüm Kategoriler");
            cbkategoriler.SelectedIndex = 0;

            label4.Visible = false;
            txtarama.Visible = false;

            curunler c = new curunler();
            c.urunlerilistele(lvurunlistesi);
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            frmmenu frm = new frmmenu();
            this.Close();
            frm.Show();
        }

        private void temizle()
        {
            txturunadi.Clear();
            txtfiyat.Clear();
            txtfiyat.Text = string.Format("{0:#.##}", 0);
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (txturunadi.Text.Trim() == "" || txtfiyat.Text.Trim() == "" || cbkategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
            {
                MessageBox.Show("Ürün adı,fiyatı ve kategori seçilmemiştir.", "Dikkat,Bilgiler Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                curunler c = new curunler();
                c.Fiyat = Convert.ToDecimal(txtfiyat.Text);
                c.Urunad = txturunadi.Text;
                c.Aciklama = "Ürün Eklendi.";
                c.Kategoriid = urunturno;
                int sonuc = c.urunekle(c);
                if (sonuc != 0)
                {
                    MessageBox.Show("Ürün Eklenmiştir");
                    yenile();
                    temizle();
                }
            }
        }
        int urunturno = 0;
        private void btndegistir_Click(object sender, EventArgs e)
        {
            if (txturunadi.Text.Trim() == "" || txtfiyat.Text.Trim() == "" || cbkategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
            {
                MessageBox.Show("Ürün adı,fiyatı ve kategori seçilmemiştir.", "Dikkat,Bilgiler Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                curunler c = new curunler();
                c.Fiyat = Convert.ToDecimal(txtfiyat.Text);
                c.Urunad = txturunadi.Text;
                c.Urunid = Convert.ToInt32(txturunid.Text);
                c.Kategoriid = urunturno;
                c.Aciklama = "Ürün Güncellendi.";
                int sonuc = c.urunguncelle(c);
                if (sonuc != 0)
                {
                    MessageBox.Show("Ürün Güncellenmiştir.");
                    yenile();
                    temizle();
                }
            }
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            txtarama.Visible = true;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (lvurunlistesi.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Ürün Silmekte Emin Misiniz ?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    curunler c = new curunler();

                    c.Urunid = Convert.ToInt32(txturunid.Text);
                    c.Aciklama = "Ürün Silinmiştir.";
                    int sonuc = c.urunsil(c);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Ürün Silinmiştir.");
                        cbkategoriler_SelectedIndexChanged(sender, e);
                        yenile();
                        temizle();
                    }
                }
            }
            else
            {
                MessageBox.Show("Silmek İçin Ürün Seçiniz.", "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            curunler u = new curunler();
            u.urunlerilistelebyurunadi(lvurunlistesi, txtarama.Text);
        }
        private void yenile()
        {
            curuncesitleri uc = new curuncesitleri();
            uc.uruncesitlerinigetircb(cbkategoriler);
            curunler c = new curunler();
            c.urunlerilistele(lvurunlistesi);
        }

        private void cbkategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            curunler u = new curunler();
            if (cbkategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
            {
                u.urunlerilistele(lvurunlistesi);
            }
            else
            {
                curuncesitleri cesit = (curuncesitleri)cbkategoriler.SelectedItem;
                urunturno = cesit.Id;
                u.urunlerilistelebyurunid(lvurunlistesi, urunturno);
            }
        }

        private void lvurunlistesi_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvurunlistesi.SelectedItems.Count > 0)
            {
                txturunadi.Text = lvurunlistesi.SelectedItems[0].SubItems[3].Text;
                txtfiyat.Text = lvurunlistesi.SelectedItems[0].SubItems[4].Text;
                txturunid.Text = lvurunlistesi.SelectedItems[0].SubItems[0].Text;
            }
        }



    }
}
