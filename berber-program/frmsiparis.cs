using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;

namespace berber_program
{
    public partial class frmsiparis : Form
    {
        public frmsiparis()
        {
            InitializeComponent();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            frmmenu frm = new frmmenu();
            this.Close();
            frm.Show();
        }
        int tabelid; int additionid;
        //hesapişlem
        void islem(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btn1":
                    txtadet.Text += (1).ToString();
                    break;
                case "btn2":
                    txtadet.Text += (2).ToString();
                    break;
                case "btn3":
                    txtadet.Text += (3).ToString();
                    break;
                case "btn4":
                    txtadet.Text += (4).ToString();
                    break;
                case "btn5":
                    txtadet.Text += (5).ToString();
                    break;
                case "btn6":
                    txtadet.Text += (6).ToString();
                    break;
                case "btn7":
                    txtadet.Text += (7).ToString();
                    break;
                case "btn8":
                    txtadet.Text += (8).ToString();
                    break;
                case "btn9":
                    txtadet.Text += (9).ToString();
                    break;
                case "btn":
                    txtadet.Text += (0).ToString();
                    break;

                default:
                    break;

            }

        }

        private void frmsiparis_Load(object sender, EventArgs e)
        {
            lbcalisanadi.Text = cgenel._ButtonValue;
            ccalisanlar ms = new ccalisanlar();
            tabelid = ms.TableGetbyNumber(cgenel._ButtonName);
            if (ms.TableGetbyState(tabelid, 2) == true || ms.TableGetbyState(tabelid, 4) == true)
            {
                cadisyon ad = new cadisyon();
                additionid= ad.getByAddition(tabelid);
                csiparis orders = new csiparis();
                orders.getbyorder(lvsiparisler, additionid);
            }
            btn1.Click += new EventHandler(islem);
            btn2.Click += new EventHandler(islem);
            btn3.Click += new EventHandler(islem);
            btn4.Click += new EventHandler(islem);
            btn5.Click += new EventHandler(islem);
            btn6.Click += new EventHandler(islem);
            btn7.Click += new EventHandler(islem);
            btn8.Click += new EventHandler(islem);
            btn9.Click += new EventHandler(islem);
            btn0.Click += new EventHandler(islem);
        }
        curuncesitleri uc = new curuncesitleri();

       
       
        private void btnerkek1_Click(object sender, EventArgs e)
        {
            uc.getbyproducttypes(lvmenu, btnerkek1);
        }

        private void btnkadin2_Click(object sender, EventArgs e)
        {
            uc.getbyproducttypes(lvmenu, btnkadin2);
        }

        private void btnicecek3_Click(object sender, EventArgs e)
        {
            uc.getbyproducttypes(lvmenu, btnicecek3);
        }
        int sayac = 0; int sayac2 = 0;
        private void lvmenu_DoubleClick(object sender, EventArgs e)
        {
            if (txtadet.Text == "")
            {
                txtadet.Text = "1";
            }
            if(lvmenu.Items.Count>0)
            {
                sayac = lvsiparisler.Items.Count;
                lvsiparisler.Items.Add(lvmenu.SelectedItems[0].Text);
                lvsiparisler.Items[sayac].SubItems.Add(txtadet.Text);
                lvsiparisler.Items[sayac].SubItems.Add(lvmenu.SelectedItems[0].SubItems[2].Text);
                lvsiparisler.Items[sayac].SubItems.Add((Convert.ToDecimal(lvmenu.SelectedItems[0].SubItems[1].Text) * Convert.ToDecimal( txtadet.Text)).ToString());
                lvsiparisler.Items[sayac].SubItems.Add("0");
                sayac2 = lvyenieklenenler.Items.Count;
                lvsiparisler.Items[sayac].SubItems.Add(sayac2.ToString());

                lvyenieklenenler.Items.Add(additionid.ToString());
                lvyenieklenenler.Items[sayac2].SubItems.Add(lvmenu.SelectedItems[0].SubItems[2].Text);
                lvyenieklenenler.Items[sayac2].SubItems.Add(txtadet.Text);
                lvyenieklenenler.Items[sayac2].SubItems.Add(tabelid.ToString());
                lvyenieklenenler.Items[sayac2].SubItems.Add(sayac2.ToString());

                sayac2++;
                txtadet.Text = "";
            }
        }
        
        ArrayList silinler = new ArrayList();
        
        private void btnsiparis_Click(object sender, EventArgs e)
        {
            /*1-masaboş
             * 2-masadolu
             */
           
            frmcalisan ms = new frmcalisan();
            ccalisanlar calisan = new ccalisanlar();
            cadisyon newaddition = new cadisyon();
            csiparis saveorder = new csiparis();
            bool sonuc = false;
            if (calisan.TableGetbyState(tabelid, 1) == true)
            {
                
                newaddition.Calisanid = tabelid;
                newaddition.Tarih = DateTime.Now;
                sonuc = newaddition.setbyadditionnew(newaddition);
                calisan.setchangetablestate(cgenel._ButtonName, 2);

                if (lvsiparisler.Items.Count > 0)
                {
                    for (int i = 0; i < lvsiparisler.Items.Count; i++)
                    {
                        saveorder.Calisanid = tabelid;
                        saveorder.Urunid = Convert.ToInt32(lvsiparisler.Items[i].SubItems[2].Text);
                        saveorder.Adisyonid = newaddition.getByAddition(tabelid);
                        saveorder.Adet = Convert.ToInt32(lvsiparisler.Items[i].SubItems[1].Text);
                        saveorder.setsaveorder(saveorder);
                    }
                    this.Close();
                    ms.Show();
                }

            }
            else if (calisan.TableGetbyState(tabelid, 2) == true)
            {
                if (lvyenieklenenler.Items.Count > 0)
                {
                    for (int i = 0; i < lvyenieklenenler.Items.Count; i++)
                    {
                        saveorder.Calisanid = tabelid;
                        saveorder.Urunid = Convert.ToInt32(lvsiparisler.Items[i].SubItems[1].Text);
                        saveorder.Adisyonid = newaddition.getByAddition(tabelid);
                        saveorder.Adet = Convert.ToInt32(lvsiparisler.Items[i].SubItems[2].Text);
                        saveorder.setsaveorder(saveorder);

                    }
                    
                }
                if (silinler.Count > 0)
                {
                    foreach (string item in silinler)
                    {
                        saveorder.setdeleteorder(Convert.ToInt32(item));
                    }
                }
                this.Close();
                ms.Show();
            }
            
            

        }     
        private void lvsiparisler_DoubleClick(object sender, EventArgs e)
        {
            if (lvsiparisler.Items.Count > 0)
            {
                if (lvsiparisler.SelectedItems[0].SubItems[4].Text !="0")
                {
                    csiparis saveorder = new csiparis();
                    saveorder.setdeleteorder(Convert.ToInt32(lvsiparisler.SelectedItems[0].SubItems[4].Text));
                }
                else
                {
                    for (int i =0;i<lvyenieklenenler.Items.Count;i++)
                    {
                        if (lvyenieklenenler.Items[i].SubItems[4].Text==lvsiparisler.SelectedItems[0].SubItems[5].Text)
                        {
                            lvyenieklenenler.Items.RemoveAt(i);
                        }
                    }
                }
                lvsiparisler.Items.RemoveAt(lvsiparisler.SelectedItems[0].Index);
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtadet.Clear();
        }

        private void lvmenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnodeme_Click(object sender, EventArgs e)
        {
            if (lvyenieklenenler.Items.Count == 0 && lvsiparisler.Items.Count > 0)
            {
                cgenel._adisyonid = additionid.ToString();
                frmbill frm = new frmbill();
                this.Close();
                frm.Show();
            }
            else if ( lvyenieklenenler.Items[0].Index == 0)
            {
                
                MessageBox.Show("Önce Yapılana Tıklayınız!!!", "hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lbcalisanadi_Click(object sender, EventArgs e)
        {

        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            frmcalisan frm = new frmcalisan();
            this.Close();
            frm.Show();
        }

        private void lvyenieklenenler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
