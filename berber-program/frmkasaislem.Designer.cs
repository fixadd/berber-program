namespace berber_program
{
    partial class frmkasaislem
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnaylikrapor = new System.Windows.Forms.Button();
            this.btnzrapor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rpvaylik = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpvzrapor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btngeri = new System.Windows.Forms.Button();
            this.DataTable4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new berber_program.DataSet1();
            this.DataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable3TableAdapter = new berber_program.DataSet1TableAdapters.DataTable3TableAdapter();
            this.DataTable4TableAdapter = new berber_program.DataSet1TableAdapters.DataTable4TableAdapter();
            this.aylikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aylikTableAdapter = new berber_program.DataSet1TableAdapters.aylikTableAdapter();
            this.gunlukBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunlukTableAdapter = new berber_program.DataSet1TableAdapters.gunlukTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aylikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunlukBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaylikrapor
            // 
            this.btnaylikrapor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnaylikrapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnaylikrapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaylikrapor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaylikrapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaylikrapor.Location = new System.Drawing.Point(438, 264);
            this.btnaylikrapor.Name = "btnaylikrapor";
            this.btnaylikrapor.Size = new System.Drawing.Size(228, 115);
            this.btnaylikrapor.TabIndex = 0;
            this.btnaylikrapor.Text = "AYLIK\r\nRAPOR\r\n";
            this.btnaylikrapor.UseVisualStyleBackColor = false;
            this.btnaylikrapor.Click += new System.EventHandler(this.btnaylikrapor_Click);
            // 
            // btnzrapor
            // 
            this.btnzrapor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnzrapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnzrapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnzrapor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnzrapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnzrapor.Location = new System.Drawing.Point(438, 410);
            this.btnzrapor.Name = "btnzrapor";
            this.btnzrapor.Size = new System.Drawing.Size(228, 115);
            this.btnzrapor.TabIndex = 0;
            this.btnzrapor.Text = "Z-RAPORU";
            this.btnzrapor.UseVisualStyleBackColor = false;
            this.btnzrapor.Click += new System.EventHandler(this.btnzrapor_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1041, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "AYLIK RAPOR";
            // 
            // rpvaylik
            // 
            this.rpvaylik.Anchor = System.Windows.Forms.AnchorStyles.None;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.aylikBindingSource;
            this.rpvaylik.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvaylik.LocalReport.ReportEmbeddedResource = "berber_program.Report2.rdlc";
            this.rpvaylik.Location = new System.Drawing.Point(720, 249);
            this.rpvaylik.Name = "rpvaylik";
            this.rpvaylik.Size = new System.Drawing.Size(864, 568);
            this.rpvaylik.TabIndex = 11;
            // 
            // rpvzrapor
            // 
            this.rpvzrapor.Anchor = System.Windows.Forms.AnchorStyles.None;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.gunlukBindingSource;
            this.rpvzrapor.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvzrapor.LocalReport.ReportEmbeddedResource = "berber_program.Report4.rdlc";
            this.rpvzrapor.Location = new System.Drawing.Point(720, 249);
            this.rpvzrapor.Name = "rpvzrapor";
            this.rpvzrapor.Size = new System.Drawing.Size(864, 568);
            this.rpvzrapor.TabIndex = 11;
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
            this.btngeri.Location = new System.Drawing.Point(451, 739);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(69, 65);
            this.btngeri.TabIndex = 9;
            this.btngeri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // DataTable4BindingSource
            // 
            this.DataTable4BindingSource.DataMember = "DataTable4";
            this.DataTable4BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable3BindingSource
            // 
            this.DataTable3BindingSource.DataMember = "DataTable3";
            this.DataTable3BindingSource.DataSource = this.DataSet1;
            // 
            // DataTable3TableAdapter
            // 
            this.DataTable3TableAdapter.ClearBeforeFill = true;
            // 
            // DataTable4TableAdapter
            // 
            this.DataTable4TableAdapter.ClearBeforeFill = true;
            // 
            // aylikBindingSource
            // 
            this.aylikBindingSource.DataMember = "aylik";
            this.aylikBindingSource.DataSource = this.DataSet1;
            // 
            // aylikTableAdapter
            // 
            this.aylikTableAdapter.ClearBeforeFill = true;
            // 
            // gunlukBindingSource
            // 
            this.gunlukBindingSource.DataMember = "gunluk";
            this.gunlukBindingSource.DataSource = this.DataSet1;
            // 
            // gunlukTableAdapter
            // 
            this.gunlukTableAdapter.ClearBeforeFill = true;
            // 
            // frmkasaislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1940, 1000);
            this.Controls.Add(this.rpvzrapor);
            this.Controls.Add(this.rpvaylik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnzrapor);
            this.Controls.Add(this.btnaylikrapor);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmkasaislem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmkasaislemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmkasaislem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aylikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunlukBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaylikrapor;
        private System.Windows.Forms.Button btnzrapor;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvaylik;
        private Microsoft.Reporting.WinForms.ReportViewer rpvzrapor;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource DataTable3BindingSource;
        private DataSet1TableAdapters.DataTable3TableAdapter DataTable3TableAdapter;
        private System.Windows.Forms.BindingSource DataTable4BindingSource;
        private DataSet1TableAdapters.DataTable4TableAdapter DataTable4TableAdapter;
        private System.Windows.Forms.BindingSource aylikBindingSource;
        private DataSet1TableAdapters.aylikTableAdapter aylikTableAdapter;
        private System.Windows.Forms.BindingSource gunlukBindingSource;
        private DataSet1TableAdapters.gunlukTableAdapter gunlukTableAdapter;
    }
}