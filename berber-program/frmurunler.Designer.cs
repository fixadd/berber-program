namespace berber_program
{
    partial class frmurunler
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
            this.lvurunlistesi = new System.Windows.Forms.ListView();
            this.btngeri = new System.Windows.Forms.Button();
            this.cbkategoriler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txturunadi = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.btndegistir = new System.Windows.Forms.Button();
            this.btnbul = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.txtarama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txturunid = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvurunlistesi
            // 
            this.lvurunlistesi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvurunlistesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvurunlistesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvurunlistesi.FullRowSelect = true;
            this.lvurunlistesi.GridLines = true;
            this.lvurunlistesi.Location = new System.Drawing.Point(632, 482);
            this.lvurunlistesi.Name = "lvurunlistesi";
            this.lvurunlistesi.Size = new System.Drawing.Size(528, 312);
            this.lvurunlistesi.TabIndex = 0;
            this.lvurunlistesi.UseCompatibleStateImageBehavior = false;
            this.lvurunlistesi.View = System.Windows.Forms.View.Details;
            this.lvurunlistesi.SelectedIndexChanged += new System.EventHandler(this.lvurunlistesi_SelectedIndexChanged);
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
            this.btngeri.Location = new System.Drawing.Point(104, 847);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(80, 80);
            this.btngeri.TabIndex = 5;
            this.btngeri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // cbkategoriler
            // 
            this.cbkategoriler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbkategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkategoriler.FormattingEnabled = true;
            this.cbkategoriler.Location = new System.Drawing.Point(882, 138);
            this.cbkategoriler.Name = "cbkategoriler";
            this.cbkategoriler.Size = new System.Drawing.Size(133, 21);
            this.cbkategoriler.TabIndex = 6;
            this.cbkategoriler.SelectedIndexChanged += new System.EventHandler(this.cbkategoriler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(705, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ürün Kategorisi =";
            // 
            // txturunadi
            // 
            this.txturunadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txturunadi.Location = new System.Drawing.Point(882, 178);
            this.txturunadi.Name = "txturunadi";
            this.txturunadi.Size = new System.Drawing.Size(133, 20);
            this.txturunadi.TabIndex = 8;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfiyat.Location = new System.Drawing.Point(882, 218);
            this.txtfiyat.Multiline = true;
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(133, 20);
            this.txtfiyat.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(766, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ürün Adı =";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(748, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ürün Fiyatı =";
            // 
            // btnekle
            // 
            this.btnekle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.Color.White;
            this.btnekle.Location = new System.Drawing.Point(623, 360);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(161, 105);
            this.btnekle.TabIndex = 9;
            this.btnekle.Text = "ÜRÜN\r\nEKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btndegistir
            // 
            this.btndegistir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btndegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndegistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndegistir.ForeColor = System.Drawing.Color.White;
            this.btndegistir.Location = new System.Drawing.Point(815, 360);
            this.btndegistir.Name = "btndegistir";
            this.btndegistir.Size = new System.Drawing.Size(161, 105);
            this.btndegistir.TabIndex = 9;
            this.btndegistir.Text = "DEĞİŞTİR\r\n";
            this.btndegistir.UseVisualStyleBackColor = false;
            this.btndegistir.Click += new System.EventHandler(this.btndegistir_Click);
            // 
            // btnbul
            // 
            this.btnbul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnbul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnbul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbul.ForeColor = System.Drawing.Color.White;
            this.btnbul.Location = new System.Drawing.Point(1021, 290);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(40, 33);
            this.btnbul.TabIndex = 9;
            this.btnbul.Text = "ÜRÜN\r\nBUL";
            this.btnbul.UseVisualStyleBackColor = false;
            this.btnbul.Visible = false;
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // btnsil
            // 
            this.btnsil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.White;
            this.btnsil.Location = new System.Drawing.Point(999, 360);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(161, 105);
            this.btnsil.TabIndex = 9;
            this.btnsil.Text = "ÜRÜN\r\nSİL\r\n";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // txtarama
            // 
            this.txtarama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtarama.Location = new System.Drawing.Point(873, 299);
            this.txtarama.Multiline = true;
            this.txtarama.Name = "txtarama";
            this.txtarama.Size = new System.Drawing.Size(142, 24);
            this.txtarama.TabIndex = 8;
            this.txtarama.Visible = false;
            this.txtarama.TextChanged += new System.EventHandler(this.txtarama_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(705, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ürün Arama  =";
            this.label4.Visible = false;
            // 
            // txturunid
            // 
            this.txturunid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txturunid.Location = new System.Drawing.Point(1034, 174);
            this.txturunid.Multiline = true;
            this.txturunid.Name = "txturunid";
            this.txturunid.Size = new System.Drawing.Size(113, 41);
            this.txturunid.TabIndex = 8;
            this.txturunid.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "urunid";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "urunturno";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kategori";
            this.columnHeader3.Width = 146;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ürün Adı";
            this.columnHeader4.Width = 189;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fiyat";
            this.columnHeader5.Width = 189;
            // 
            // frmurunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1924, 961);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnbul);
            this.Controls.Add(this.btndegistir);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtarama);
            this.Controls.Add(this.txturunid);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.txturunadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbkategoriler);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.lvurunlistesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmurunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmurunler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmurunler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvurunlistesi;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.ComboBox cbkategoriler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txturunadi;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btndegistir;
        private System.Windows.Forms.Button btnbul;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.TextBox txtarama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txturunid;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}