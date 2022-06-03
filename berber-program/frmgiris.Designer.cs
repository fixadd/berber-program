namespace berber_program
{
    partial class frmgiris
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
            this.cbkullanici = new System.Windows.Forms.ComboBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btncikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btngiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbkullanici
            // 
            this.cbkullanici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbkullanici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkullanici.FormattingEnabled = true;
            this.cbkullanici.Location = new System.Drawing.Point(872, 329);
            this.cbkullanici.Margin = new System.Windows.Forms.Padding(5);
            this.cbkullanici.Name = "cbkullanici";
            this.cbkullanici.Size = new System.Drawing.Size(199, 28);
            this.cbkullanici.TabIndex = 0;
            this.cbkullanici.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtsifre
            // 
            this.txtsifre.AcceptsReturn = true;
            this.txtsifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsifre.Location = new System.Drawing.Point(872, 390);
            this.txtsifre.Margin = new System.Windows.Forms.Padding(5);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(180, 19);
            this.txtsifre.TabIndex = 1;
            this.txtsifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsifre.Click += new System.EventHandler(this.btngiris_Enter);
            this.txtsifre.TextChanged += new System.EventHandler(this.txtsifre_TextChanged);
            this.txtsifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsifre_KeyDown);
            // 
            // btncikis
            // 
            this.btncikis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncikis.BackColor = System.Drawing.Color.Transparent;
            this.btncikis.BackgroundImage = global::berber_program.Properties.Resources._1087051;
            this.btncikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncikis.Location = new System.Drawing.Point(974, 595);
            this.btncikis.Margin = new System.Windows.Forms.Padding(5);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(125, 44);
            this.btncikis.TabIndex = 2;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(729, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı adı=";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(800, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre=";
            // 
            // btngiris
            // 
            this.btngiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngiris.BackColor = System.Drawing.Color.Transparent;
            this.btngiris.BackgroundImage = global::berber_program.Properties.Resources._1087051;
            this.btngiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngiris.Location = new System.Drawing.Point(839, 599);
            this.btngiris.Margin = new System.Windows.Forms.Padding(5);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(125, 40);
            this.btngiris.TabIndex = 2;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            this.btngiris.Enter += new System.EventHandler(this.btngiris_Enter);
            // 
            // frmgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::berber_program.Properties.Resources.krboga2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1000);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.cbkullanici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmgiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbkullanici;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngiris;
    }
}

