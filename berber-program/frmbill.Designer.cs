namespace berber_program
{
    partial class frmbill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbill));
            this.lbadisyonid = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblodenecek = new System.Windows.Forms.Label();
            this.lbltoplamtutar = new System.Windows.Forms.Label();
            this.lblkdv = new System.Windows.Forms.Label();
            this.lblindirim = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbkredikarti = new System.Windows.Forms.RadioButton();
            this.rbnakit = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkindirim = new System.Windows.Forms.CheckBox();
            this.gbindirim = new System.Windows.Forms.GroupBox();
            this.txtindirimtutari = new System.Windows.Forms.TextBox();
            this.lvurunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btngeri = new System.Windows.Forms.Button();
            this.hesapozetbtn = new System.Windows.Forms.Button();
            this.hesapkapatbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbindirim.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbadisyonid
            // 
            this.lbadisyonid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbadisyonid.AutoSize = true;
            this.lbadisyonid.BackColor = System.Drawing.Color.Transparent;
            this.lbadisyonid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbadisyonid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbadisyonid.ForeColor = System.Drawing.Color.White;
            this.lbadisyonid.Location = new System.Drawing.Point(576, 224);
            this.lbadisyonid.Name = "lbadisyonid";
            this.lbadisyonid.Size = new System.Drawing.Size(31, 25);
            this.lbadisyonid.TabIndex = 1;
            this.lbadisyonid.Text = "id";
            this.lbadisyonid.Click += new System.EventHandler(this.lbadisyonid_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblodenecek);
            this.groupBox1.Controls.Add(this.lbltoplamtutar);
            this.groupBox1.Controls.Add(this.lblkdv);
            this.groupBox1.Controls.Add(this.lblindirim);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(466, 531);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 183);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme bilgileri";
            // 
            // lblodenecek
            // 
            this.lblodenecek.AutoSize = true;
            this.lblodenecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblodenecek.Location = new System.Drawing.Point(164, 128);
            this.lblodenecek.Name = "lblodenecek";
            this.lblodenecek.Size = new System.Drawing.Size(21, 24);
            this.lblodenecek.TabIndex = 0;
            this.lblodenecek.Text = "0";
            // 
            // lbltoplamtutar
            // 
            this.lbltoplamtutar.AutoSize = true;
            this.lbltoplamtutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltoplamtutar.Location = new System.Drawing.Point(164, 94);
            this.lbltoplamtutar.Name = "lbltoplamtutar";
            this.lbltoplamtutar.Size = new System.Drawing.Size(21, 24);
            this.lbltoplamtutar.TabIndex = 0;
            this.lbltoplamtutar.Text = "0";
            // 
            // lblkdv
            // 
            this.lblkdv.AutoSize = true;
            this.lblkdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkdv.Location = new System.Drawing.Point(164, 61);
            this.lblkdv.Name = "lblkdv";
            this.lblkdv.Size = new System.Drawing.Size(21, 24);
            this.lblkdv.TabIndex = 0;
            this.lblkdv.Text = "0";
            // 
            // lblindirim
            // 
            this.lblindirim.AutoSize = true;
            this.lblindirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblindirim.Location = new System.Drawing.Point(164, 31);
            this.lblindirim.Name = "lblindirim";
            this.lblindirim.Size = new System.Drawing.Size(21, 24);
            this.lblindirim.TabIndex = 0;
            this.lblindirim.Text = "0";
            this.lblindirim.TextChanged += new System.EventHandler(this.lblindirim_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(231, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "TL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(231, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "TL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(231, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(231, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "TL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ara Toplam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "KDV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "İndirim";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbkredikarti);
            this.groupBox2.Controls.Add(this.rbnakit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(805, 541);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 173);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödeme Türü";
            // 
            // rbkredikarti
            // 
            this.rbkredikarti.AutoSize = true;
            this.rbkredikarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbkredikarti.Location = new System.Drawing.Point(24, 100);
            this.rbkredikarti.Name = "rbkredikarti";
            this.rbkredikarti.Size = new System.Drawing.Size(155, 33);
            this.rbkredikarti.TabIndex = 0;
            this.rbkredikarti.TabStop = true;
            this.rbkredikarti.Text = "Kredi Kartı";
            this.rbkredikarti.UseVisualStyleBackColor = true;
            // 
            // rbnakit
            // 
            this.rbnakit.AutoSize = true;
            this.rbnakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbnakit.Location = new System.Drawing.Point(24, 51);
            this.rbnakit.Name = "rbnakit";
            this.rbnakit.Size = new System.Drawing.Size(91, 33);
            this.rbnakit.TabIndex = 0;
            this.rbnakit.TabStop = true;
            this.rbnakit.Text = "Nakit";
            this.rbnakit.UseVisualStyleBackColor = true;
            this.rbnakit.CheckedChanged += new System.EventHandler(this.rbnakit_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.chkindirim);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(1055, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 109);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Özel indirim";
            // 
            // chkindirim
            // 
            this.chkindirim.AutoSize = true;
            this.chkindirim.BackColor = System.Drawing.Color.Transparent;
            this.chkindirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkindirim.ForeColor = System.Drawing.Color.White;
            this.chkindirim.Location = new System.Drawing.Point(14, 49);
            this.chkindirim.Name = "chkindirim";
            this.chkindirim.Size = new System.Drawing.Size(162, 28);
            this.chkindirim.TabIndex = 3;
            this.chkindirim.Text = "İndirim Uygula";
            this.chkindirim.UseVisualStyleBackColor = false;
            this.chkindirim.CheckedChanged += new System.EventHandler(this.chkindirim_CheckedChanged);
            // 
            // gbindirim
            // 
            this.gbindirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbindirim.BackColor = System.Drawing.Color.Transparent;
            this.gbindirim.Controls.Add(this.txtindirimtutari);
            this.gbindirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbindirim.ForeColor = System.Drawing.Color.White;
            this.gbindirim.Location = new System.Drawing.Point(1297, 265);
            this.gbindirim.Name = "gbindirim";
            this.gbindirim.Size = new System.Drawing.Size(200, 109);
            this.gbindirim.TabIndex = 2;
            this.gbindirim.TabStop = false;
            this.gbindirim.Text = "Özel Aktivite";
            this.gbindirim.Visible = false;
            // 
            // txtindirimtutari
            // 
            this.txtindirimtutari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtindirimtutari.Location = new System.Drawing.Point(23, 49);
            this.txtindirimtutari.Name = "txtindirimtutari";
            this.txtindirimtutari.Size = new System.Drawing.Size(151, 35);
            this.txtindirimtutari.TabIndex = 5;
            this.txtindirimtutari.TextChanged += new System.EventHandler(this.txtindirimtutari_TextChanged);
            // 
            // lvurunler
            // 
            this.lvurunler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvurunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvurunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvurunler.FullRowSelect = true;
            this.lvurunler.GridLines = true;
            this.lvurunler.Location = new System.Drawing.Point(466, 265);
            this.lvurunler.Name = "lvurunler";
            this.lvurunler.Size = new System.Drawing.Size(583, 260);
            this.lvurunler.TabIndex = 3;
            this.lvurunler.UseCompatibleStateImageBehavior = false;
            this.lvurunler.View = System.Windows.Forms.View.Details;
            this.lvurunler.SelectedIndexChanged += new System.EventHandler(this.lvurunler_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Urun Adı";
            this.columnHeader1.Width = 221;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adet";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Urunid";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            this.columnHeader4.Width = 248;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Satisid";
            this.columnHeader5.Width = 1;
            // 
            // btngeri
            // 
            this.btngeri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngeri.BackColor = System.Drawing.Color.Transparent;
            this.btngeri.BackgroundImage = global::berber_program.Properties.Resources.left_arrow;
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngeri.ForeColor = System.Drawing.Color.White;
            this.btngeri.Location = new System.Drawing.Point(443, 769);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(80, 80);
            this.btngeri.TabIndex = 4;
            this.btngeri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click_1);
            // 
            // hesapozetbtn
            // 
            this.hesapozetbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hesapozetbtn.BackColor = System.Drawing.Color.Green;
            this.hesapozetbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hesapozetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hesapozetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapozetbtn.ForeColor = System.Drawing.Color.White;
            this.hesapozetbtn.Location = new System.Drawing.Point(1168, 442);
            this.hesapozetbtn.Name = "hesapozetbtn";
            this.hesapozetbtn.Size = new System.Drawing.Size(161, 83);
            this.hesapozetbtn.TabIndex = 5;
            this.hesapozetbtn.Text = "HESAP\r\nÖZETİ";
            this.hesapozetbtn.UseVisualStyleBackColor = false;
            this.hesapozetbtn.Click += new System.EventHandler(this.hesapozetbtn_Click);
            // 
            // hesapkapatbtn
            // 
            this.hesapkapatbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hesapkapatbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hesapkapatbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hesapkapatbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hesapkapatbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapkapatbtn.ForeColor = System.Drawing.Color.White;
            this.hesapkapatbtn.Location = new System.Drawing.Point(1168, 567);
            this.hesapkapatbtn.Name = "hesapkapatbtn";
            this.hesapkapatbtn.Size = new System.Drawing.Size(161, 83);
            this.hesapkapatbtn.TabIndex = 5;
            this.hesapkapatbtn.Text = "HESAP\r\nKAPAT\r\n";
            this.hesapkapatbtn.UseVisualStyleBackColor = false;
            this.hesapkapatbtn.Click += new System.EventHandler(this.hesapkapatbtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(444, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adisyon İd =";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.ShowIcon = false;
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::berber_program.Properties.Resources.krboga2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1940, 1000);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hesapkapatbtn);
            this.Controls.Add(this.hesapozetbtn);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.lvurunler);
            this.Controls.Add(this.gbindirim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbadisyonid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmbill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmbill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmbill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbindirim.ResumeLayout(false);
            this.gbindirim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbadisyonid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbindirim;
        private System.Windows.Forms.CheckBox chkindirim;
        private System.Windows.Forms.RadioButton rbkredikarti;
        private System.Windows.Forms.RadioButton rbnakit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblodenecek;
        private System.Windows.Forms.Label lbltoplamtutar;
        private System.Windows.Forms.Label lblkdv;
        private System.Windows.Forms.Label lblindirim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.TextBox txtindirimtutari;
        private System.Windows.Forms.Button hesapozetbtn;
        private System.Windows.Forms.Button hesapkapatbtn;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        protected System.Windows.Forms.ListView lvurunler;
    }
}