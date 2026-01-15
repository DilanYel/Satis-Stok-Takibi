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
    public partial class ProductForm : Form
    {
        ürünBLL bll = new ürünBLL();
        public ProductForm()
        {
            InitializeComponent();
        }
        void ürünleriGetir()
        {
            dgvürünler.DataSource = bll.Listele();
            dgvürünler.Columns["ürünId"].Visible = false;
            Minstoklarırenklendir();
        }
        public void Txbtemizle()
        {
            ürünadıTxb.Clear();
            kategoriTxb.Clear();
            fiyatTxb.Clear();
            stokTxb.Clear();
            minstokTxb.Clear();
            maliyetTxb.Clear();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            ürünleriGetir();
            dgvürünler.EnableHeadersVisualStyles = false;

            dgvürünler.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon;
            dgvürünler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvürünler.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            bll.kaydet(ürünadıTxb.Text, kategoriTxb.Text, int.Parse(fiyatTxb.Text), int.Parse(stokTxb.Text), int.Parse(minstokTxb.Text), int.Parse (maliyetTxb.Text) );
            MessageBox.Show("Ürün eklendi");
            ürünleriGetir();
            Txbtemizle();
        }

        private void çıkarBtn_Click(object sender, EventArgs e)
        {
            if (dgvürünler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen listeden bir ürün seç.");
                return;
            }
            int ürünId = Convert.ToInt32(dgvürünler.CurrentRow.Cells["ürünId"].Value);
            var cevap = MessageBox.Show("Seçili ürünü silmek istiyor musun?", "Onay", MessageBoxButtons.YesNo);
            if (cevap != DialogResult.Yes) return;
            try
            {
                ürünBLL bll = new ürünBLL();
                bll.sil(ürünId);
                MessageBox.Show("Ürün silindi.");
                ürünleriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }
        private void Minstoklarırenklendir()
        {
            foreach (DataGridViewRow row in dgvürünler.Rows)
            {
                if (row.IsNewRow) continue;
                int stok = Convert.ToInt32(row.Cells["stok"].Value);
                int minstok = Convert.ToInt32(row.Cells["minstok"].Value);
                row.DefaultCellStyle.BackColor = (stok < minstok) ? Color.Red : Color.White;
            }
        }

        private void dgvürünler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvürünler.CurrentRow == null) return;
            ürünadıTxb.Text = dgvürünler.CurrentRow.Cells["ürünadı"].Value.ToString();
            kategoriTxb.Text = dgvürünler.CurrentRow.Cells["kategori"].Value.ToString();
            fiyatTxb.Text = dgvürünler.CurrentRow.Cells["fiyat"].Value.ToString();
            stokTxb.Text = dgvürünler.CurrentRow.Cells["stok"].Value.ToString();
            minstokTxb.Text = dgvürünler.CurrentRow.Cells["minstok"].Value.ToString();
            maliyetTxb.Text= dgvürünler.CurrentRow.Cells["maliyet"].Value.ToString() ;
        }

        private void güncelleBtn_Click(object sender, EventArgs e)
        {
            if (dgvürünler.CurrentRow == null) 
            {
                MessageBox.Show("Lütfen listeden bir ürün seçiniz");
                return;
            }
            int ürünId = Convert.ToInt32(dgvürünler.CurrentRow.Cells["ürünId"].Value);
            string ürünad= ürünadıTxb.Text.Trim();
            string kategori = kategoriTxb.Text.Trim();
            decimal fiyat;
            int stok;
            int minstok;
            decimal maliyet;
            try
            {
                string fiyatMetin = fiyatTxb.Text.Trim().Replace('.', ',');
                fiyat = decimal.Parse(fiyatMetin);
                stok = int.Parse(stokTxb.Text.Trim());
                minstok = int.Parse(minstokTxb.Text.Trim());
                maliyet = decimal.Parse(maliyetTxb.Text.Trim());

                ürünBLL bll = new ürünBLL();
                bll.güncelle(ürünId, ürünad, kategori, fiyat, stok, minstok, maliyet);
                MessageBox.Show("Ürün güncellendi.");
                ürünleriGetir();
                Txbtemizle();
            }
            catch (FormatException)
            {
                MessageBox.Show("Fiyat/ stok/ min stok sayısal olamlı.");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Hata: " + ex.Message);    
            }

        }
    }
}
