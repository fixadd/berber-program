namespace berber_program
{
    partial class frmmenu
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
            this.components = new System.ComponentModel.Container();
            this.btncikis = new System.Windows.Forms.Button();
            this.btncalisan = new System.Windows.Forms.Button();
            this.btnkasa = new System.Windows.Forms.Button();
            this.btnurunler = new System.Windows.Forms.Button();
            this.btnraporlar = new System.Windows.Forms.Button();
            this.btnlock = new System.Windows.Forms.Button();
            this.calisanlar = new System.Windows.Forms.ToolTip(this.components);
            this.gunlukaylik = new System.Windows.Forms.ToolTip(this.components);
            this.raporlar = new System.Windows.Forms.ToolTip(this.components);
            this.urunayarlari = new System.Windows.Forms.ToolTip(this.components);
            this.kilit = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btncikis
            // 
            this.btncikis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncikis.BackColor = System.Drawing.Color.Transparent;
            this.btncikis.BackgroundImage = global::berber_program.Properties.Resources.girirs___Kopya;
            this.btncikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncikis.Location = new System.Drawing.Point(895, 686);
            this.btncikis.Margin = new System.Windows.Forms.Padding(5);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(155, 115);
            this.btncikis.TabIndex = 3;
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btncalisan
            // 
            this.btncalisan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncalisan.BackColor = System.Drawing.Color.Transparent;
            this.btncalisan.BackgroundImage = global::berber_program.Properties.Resources.App_login_manager_icon;
            this.btncalisan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncalisan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncalisan.Location = new System.Drawing.Point(671, 274);
            this.btncalisan.Name = "btncalisan";
            this.btncalisan.Size = new System.Drawing.Size(262, 159);
            this.btncalisan.TabIndex = 4;
            this.calisanlar.SetToolTip(this.btncalisan, "Çalışanlar.");
            this.btncalisan.UseVisualStyleBackColor = false;
            this.btncalisan.Click += new System.EventHandler(this.btncalisan_Click_1);
            // 
            // btnkasa
            // 
            this.btnkasa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnkasa.BackColor = System.Drawing.Color.Transparent;
            this.btnkasa.BackgroundImage = global::berber_program.Properties.Resources.devils_lake_t0u5orz;
            this.btnkasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkasa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkasa.Location = new System.Drawing.Point(939, 274);
            this.btnkasa.Name = "btnkasa";
            this.btnkasa.Size = new System.Drawing.Size(155, 159);
            this.btnkasa.TabIndex = 4;
            this.gunlukaylik.SetToolTip(this.btnkasa, "Günlük ve Aylık Raporlar.");
            this.btnkasa.UseVisualStyleBackColor = false;
            this.btnkasa.Click += new System.EventHandler(this.btnkasa_Click);
            // 
            // btnurunler
            // 
            this.btnurunler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnurunler.BackColor = System.Drawing.Color.Transparent;
            this.btnurunler.BackgroundImage = global::berber_program.Properties.Resources.Apps_preferences_icon;
            this.btnurunler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnurunler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnurunler.Location = new System.Drawing.Point(939, 439);
            this.btnurunler.Name = "btnurunler";
            this.btnurunler.Size = new System.Drawing.Size(155, 118);
            this.btnurunler.TabIndex = 4;
            this.urunayarlari.SetToolTip(this.btnurunler, "Ürün ekle,çıkar ve değiştirme.");
            this.btnurunler.UseVisualStyleBackColor = false;
            this.btnurunler.Click += new System.EventHandler(this.btnurunler_Click_1);
            // 
            // btnraporlar
            // 
            this.btnraporlar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnraporlar.BackColor = System.Drawing.Color.Transparent;
            this.btnraporlar.BackgroundImage = global::berber_program.Properties.Resources.SEO_icon;
            this.btnraporlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnraporlar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnraporlar.Location = new System.Drawing.Point(671, 442);
            this.btnraporlar.Name = "btnraporlar";
            this.btnraporlar.Size = new System.Drawing.Size(262, 115);
            this.btnraporlar.TabIndex = 4;
            this.raporlar.SetToolTip(this.btnraporlar, "Satis Grafikleri.");
            this.btnraporlar.UseVisualStyleBackColor = false;
            this.btnraporlar.Click += new System.EventHandler(this.btnraporlar_Click_1);
            // 
            // btnlock
            // 
            this.btnlock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlock.BackColor = System.Drawing.Color.Transparent;
            this.btnlock.BackgroundImage = global::berber_program.Properties.Resources._010_keyhole_1___Kopya;
            this.btnlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlock.Location = new System.Drawing.Point(714, 686);
            this.btnlock.Name = "btnlock";
            this.btnlock.Size = new System.Drawing.Size(155, 115);
            this.btnlock.TabIndex = 4;
            this.kilit.SetToolTip(this.btnlock, "Ekran Kilitleme.");
            this.btnlock.UseVisualStyleBackColor = false;
            this.btnlock.Click += new System.EventHandler(this.btnlock_Click);
            // 
            // calisanlar
            // 
            this.calisanlar.AutoPopDelay = 5000;
            this.calisanlar.InitialDelay = 5;
            this.calisanlar.ReshowDelay = 50;
            this.calisanlar.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.calisanlar.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // gunlukaylik
            // 
            this.gunlukaylik.AutoPopDelay = 5000;
            this.gunlukaylik.InitialDelay = 5;
            this.gunlukaylik.ReshowDelay = 50;
            this.gunlukaylik.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.gunlukaylik.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // raporlar
            // 
            this.raporlar.AutoPopDelay = 5000;
            this.raporlar.InitialDelay = 5;
            this.raporlar.ReshowDelay = 50;
            this.raporlar.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.raporlar.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // urunayarlari
            // 
            this.urunayarlari.AutoPopDelay = 5000;
            this.urunayarlari.InitialDelay = 5;
            this.urunayarlari.ReshowDelay = 50;
            this.urunayarlari.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.urunayarlari.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // kilit
            // 
            this.kilit.AutoPopDelay = 5000;
            this.kilit.InitialDelay = 5;
            this.kilit.ReshowDelay = 50;
            this.kilit.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.kilit.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::berber_program.Properties.Resources.krboga2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1940, 1000);
            this.Controls.Add(this.btnlock);
            this.Controls.Add(this.btnraporlar);
            this.Controls.Add(this.btnurunler);
            this.Controls.Add(this.btnkasa);
            this.Controls.Add(this.btncalisan);
            this.Controls.Add(this.btncikis);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmmenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btncalisan;
        private System.Windows.Forms.Button btnkasa;
        private System.Windows.Forms.Button btnurunler;
        private System.Windows.Forms.Button btnraporlar;
        private System.Windows.Forms.Button btnlock;
        private System.Windows.Forms.ToolTip calisanlar;
        private System.Windows.Forms.ToolTip gunlukaylik;
        private System.Windows.Forms.ToolTip raporlar;
        private System.Windows.Forms.ToolTip urunayarlari;
        private System.Windows.Forms.ToolTip kilit;
    }
}