using KAFE.Kafe.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KAFE
{
    public partial class CustomerForm : Form
    {
        int seçilenId = 0;
        müşteriBLL bll = new müşteriBLL();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void dgvmüşteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            var row = dgvmüşteriler.Rows[e.RowIndex];


            seçilenId = Convert.ToInt32(row.Cells["müşteriId"].Value);


            müşteriadıTxb.Text = row.Cells["müşteriAdı"].Value?.ToString() ?? "";
            türCb.Text = row.Cells["Tür"].Value?.ToString();
        }

        private void Btnekle_Click(object sender, EventArgs e)
        {
            string ad = müşteriadıTxb.Text;
            string tür = türCb.Text;
            bool sonuç = bll.MüşteriEkle(ad, tür);
            if (sonuç == true)
            {
                MessageBox.Show("Müşteri eklendi.");
            }
            else
            {
                MessageBox.Show("Müşteri adı ve türü boş olamaz.");
            }
            Doldur();
            Temizle();
        }
        public void Doldur()
        {
            dgvmüşteriler.DataSource = bll.MüşteriListele();
            dgvmüşteriler.Columns["müşteriId"].Visible = false;
            dgvmüşteriler.Refresh();
            dgvmüşteriler.Columns["müşteriId"].HeaderText = "Id";
            dgvmüşteriler.Columns["müşteriAdı"].HeaderText = "Müşteri Adı";
            dgvmüşteriler.Columns["Tür"].HeaderText = "Tür";
            dgvmüşteriler.EnableHeadersVisualStyles = false;

            dgvmüşteriler.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon;
            dgvmüşteriler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvmüşteriler.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);


            dgvmüşteriler.DefaultCellStyle.SelectionBackColor = Color.
                Green;
            dgvmüşteriler.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvmüşteriler.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dgvmüşteriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvmüşteriler.MultiSelect = false;
            Doldur();
            Temizle();
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = null;

            if (dgvmüşteriler.SelectedRows.Count > 0)
                row = dgvmüşteriler.SelectedRows[0];
            else if (dgvmüşteriler.CurrentCell != null)
                row = dgvmüşteriler.CurrentCell.OwningRow;

            if (row == null)
            {
                MessageBox.Show("Lütfen tablodan bir müşteri seç.");
                return;
            }
            int Id = Convert.ToInt32(row.Cells["müşteriId"].Value);
            bool sonuc = bll.MüşteriSil(Id);

            if (sonuc)
            {
                MessageBox.Show("Müşteri silindi.");
                Doldur();
                Temizle();
            }
            else
            {
                MessageBox.Show("Silinemedi.");
                dgvmüşteriler.Rows.Remove(row);
                Doldur();
            }
        }
             public void Temizle()
        {
            müşteriadıTxb.Text = "";
            türCb.SelectedIndex = -1;
            türCb.Text = "";
        }

    }
}

