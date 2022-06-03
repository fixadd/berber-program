namespace berber_program
{
    partial class frmraporlar
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtbasla = new System.Windows.Forms.DateTimePicker();
            this.dtbitis = new System.Windows.Forms.DateTimePicker();
            this.grpmenubaslik = new System.Windows.Forms.GroupBox();
            this.btnicecek3 = new System.Windows.Forms.Button();
            this.btnkadin2 = new System.Windows.Forms.Button();
            this.btnerkek1 = new System.Windows.Forms.Button();
            this.gbistatistik = new System.Windows.Forms.GroupBox();
            this.lvistatistik = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chrapor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btngeri = new System.Windows.Forms.Button();
            this.grpmenubaslik.SuspendLayout();
            this.gbistatistik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrapor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(791, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarihi  =";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(848, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bitiş Tarihi  =";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtbasla
            // 
            this.dtbasla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtbasla.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtbasla.CalendarForeColor = System.Drawing.Color.White;
            this.dtbasla.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtbasla.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtbasla.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dtbasla.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dtbasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtbasla.Location = new System.Drawing.Point(1040, 191);
            this.dtbasla.Margin = new System.Windows.Forms.Padding(4);
            this.dtbasla.Name = "dtbasla";
            this.dtbasla.Size = new System.Drawing.Size(283, 31);
            this.dtbasla.TabIndex = 1;
            // 
            // dtbitis
            // 
            this.dtbitis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtbitis.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtbitis.CalendarForeColor = System.Drawing.Color.White;
            this.dtbitis.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtbitis.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtbitis.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dtbitis.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dtbitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtbitis.Location = new System.Drawing.Point(1040, 240);
            this.dtbitis.Margin = new System.Windows.Forms.Padding(4);
            this.dtbitis.Name = "dtbitis";
            this.dtbitis.Size = new System.Drawing.Size(283, 31);
            this.dtbitis.TabIndex = 1;
            this.dtbitis.Value = new System.DateTime(2019, 3, 22, 23, 34, 39, 0);
            this.dtbitis.ValueChanged += new System.EventHandler(this.dtbitis_ValueChanged);
            // 
            // grpmenubaslik
            // 
            this.grpmenubaslik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpmenubaslik.BackColor = System.Drawing.Color.Transparent;
            this.grpmenubaslik.Controls.Add(this.btnicecek3);
            this.grpmenubaslik.Controls.Add(this.btnkadin2);
            this.grpmenubaslik.Controls.Add(this.btnerkek1);
            this.grpmenubaslik.ForeColor = System.Drawing.Color.White;
            this.grpmenubaslik.Location = new System.Drawing.Point(329, 311);
            this.grpmenubaslik.Margin = new System.Windows.Forms.Padding(4);
            this.grpmenubaslik.Name = "grpmenubaslik";
            this.grpmenubaslik.Padding = new System.Windows.Forms.Padding(4);
            this.grpmenubaslik.Size = new System.Drawing.Size(271, 352);
            this.grpmenubaslik.TabIndex = 3;
            this.grpmenubaslik.TabStop = false;
            this.grpmenubaslik.Text = "MENÜ";
            // 
            // btnicecek3
            // 
            this.btnicecek3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnicecek3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnicecek3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnicecek3.ForeColor = System.Drawing.Color.White;
            this.btnicecek3.Location = new System.Drawing.Point(14, 248);
            this.btnicecek3.Margin = new System.Windows.Forms.Padding(4);
            this.btnicecek3.Name = "btnicecek3";
            this.btnicecek3.Size = new System.Drawing.Size(248, 97);
            this.btnicecek3.TabIndex = 0;
            this.btnicecek3.Text = "İÇECEK";
            this.btnicecek3.UseVisualStyleBackColor = false;
            this.btnicecek3.Click += new System.EventHandler(this.btnicecek3_Click);
            // 
            // btnkadin2
            // 
            this.btnkadin2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnkadin2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkadin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkadin2.ForeColor = System.Drawing.Color.White;
            this.btnkadin2.Location = new System.Drawing.Point(14, 136);
            this.btnkadin2.Margin = new System.Windows.Forms.Padding(4);
            this.btnkadin2.Name = "btnkadin2";
            this.btnkadin2.Size = new System.Drawing.Size(248, 104);
            this.btnkadin2.TabIndex = 0;
            this.btnkadin2.Text = "KADIN";
            this.btnkadin2.UseVisualStyleBackColor = false;
            this.btnkadin2.Click += new System.EventHandler(this.btnkadin2_Click);
            // 
            // btnerkek1
            // 
            this.btnerkek1.BackColor = System.Drawing.Color.Blue;
            this.btnerkek1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnerkek1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnerkek1.ForeColor = System.Drawing.Color.White;
            this.btnerkek1.Location = new System.Drawing.Point(14, 24);
            this.btnerkek1.Margin = new System.Windows.Forms.Padding(4);
            this.btnerkek1.Name = "btnerkek1";
            this.btnerkek1.Size = new System.Drawing.Size(248, 106);
            this.btnerkek1.TabIndex = 0;
            this.btnerkek1.Text = "ERKEK";
            this.btnerkek1.UseVisualStyleBackColor = false;
            this.btnerkek1.Click += new System.EventHandler(this.btnerkek1_Click);
            // 
            // gbistatistik
            // 
            this.gbistatistik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbistatistik.BackColor = System.Drawing.Color.Transparent;
            this.gbistatistik.Controls.Add(this.lvistatistik);
            this.gbistatistik.Controls.Add(this.chrapor);
            this.gbistatistik.ForeColor = System.Drawing.Color.White;
            this.gbistatistik.Location = new System.Drawing.Point(670, 311);
            this.gbistatistik.Margin = new System.Windows.Forms.Padding(4);
            this.gbistatistik.Name = "gbistatistik";
            this.gbistatistik.Padding = new System.Windows.Forms.Padding(4);
            this.gbistatistik.Size = new System.Drawing.Size(919, 506);
            this.gbistatistik.TabIndex = 3;
            this.gbistatistik.TabStop = false;
            // 
            // lvistatistik
            // 
            this.lvistatistik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvistatistik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvistatistik.Location = new System.Drawing.Point(774, 43);
            this.lvistatistik.Name = "lvistatistik";
            this.lvistatistik.Size = new System.Drawing.Size(30, 25);
            this.lvistatistik.TabIndex = 4;
            this.lvistatistik.UseCompatibleStateImageBehavior = false;
            this.lvistatistik.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "urunadı";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "adedi";
            // 
            // chrapor
            // 
            this.chrapor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chrapor.BackColor = System.Drawing.Color.Transparent;
            this.chrapor.BorderlineColor = System.Drawing.Color.Transparent;
            this.chrapor.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chrapor.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chrapor.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrapor.Legends.Add(legend1);
            this.chrapor.Location = new System.Drawing.Point(7, 88);
            this.chrapor.Name = "chrapor";
            series1.ChartArea = "ChartArea1";
            series1.Label = "Satislar";
            series1.Legend = "Legend1";
            series1.Name = "satislar";
            this.chrapor.Series.Add(series1);
            this.chrapor.Size = new System.Drawing.Size(905, 411);
            this.chrapor.TabIndex = 0;
            this.chrapor.Text = "chart1";
            this.chrapor.Click += new System.EventHandler(this.chrapor_Click);
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
            this.btngeri.Location = new System.Drawing.Point(210, 763);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(69, 65);
            this.btngeri.TabIndex = 10;
            this.btngeri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // frmraporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1000);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.gbistatistik);
            this.Controls.Add(this.grpmenubaslik);
            this.Controls.Add(this.dtbitis);
            this.Controls.Add(this.dtbasla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmraporlar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmraporlar_Load);
            this.grpmenubaslik.ResumeLayout(false);
            this.gbistatistik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtbasla;
        private System.Windows.Forms.DateTimePicker dtbitis;
        private System.Windows.Forms.GroupBox grpmenubaslik;
        private System.Windows.Forms.Button btnicecek3;
        private System.Windows.Forms.Button btnkadin2;
        private System.Windows.Forms.Button btnerkek1;
        private System.Windows.Forms.GroupBox gbistatistik;
        private System.Windows.Forms.ListView lvistatistik;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrapor;
        private System.Windows.Forms.Button btngeri;
    }
}