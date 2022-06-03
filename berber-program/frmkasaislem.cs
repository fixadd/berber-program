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
    public partial class frmkasaislem : Form
    {
        public frmkasaislem()
        {
            InitializeComponent();
        }

        private void frmkasaislem_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'DataSet1.gunluk' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.gunlukTableAdapter.Fill(this.DataSet1.gunluk);
            // TODO: Bu kod satırı 'DataSet1.aylik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.aylikTableAdapter.Fill(this.DataSet1.aylik);
            // TODO: Bu kod satırı 'DataSet1.DataTable4' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.DataTable4TableAdapter.Fill(this.DataSet1.DataTable4);
            // TODO: Bu kod satırı 'DataSet1.DataTable3' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.DataTable3TableAdapter.Fill(this.DataSet1.DataTable3);


            this.rpvaylik.RefreshReport();
            this.rpvzrapor.RefreshReport();
             rpvzrapor.Visible = false;
            label1.Text = "AYLIK RAPOR";
            this.rpvaylik.RefreshReport();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            frmmenu frm = new frmmenu();
            this.Close();
            frm.Show();
        }

        private void btnaylikrapor_Click(object sender, EventArgs e)
        {
            label1.Text = "AYLIK RAPOR";
            rpvaylik.Visible = true;
            rpvzrapor.Visible = false;

        }

        private void btnzrapor_Click(object sender, EventArgs e)
        {
            label1.Text = "GÜNLÜK RAPOR";
            rpvaylik.Visible = false;
            rpvzrapor.Visible = true;
        }
    }
}
