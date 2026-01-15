using KAFE.Kafe.BLL;
using KAFE.Kafe.DAL;
using KAFE.Kafe.DOMAİN;
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
    public partial class SalesForm : Form
    {
        satışlarDAO satışdao = new satışlarDAO();
        müşteriBLL müşteribll = new müşteriBLL();
        ürünBLL ürünbll = new ürünBLL();
        satışlarBLL satışbll = new satışlarBLL();
        private BindingList<siparişkalem> sepet = new BindingList<siparişkalem>();
        private decimal fiyat;

        public SalesForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            müşteriDoldur();
            ürünDoldur();
            fiyatTxb.Text = "";
            adetTxb.Text = "";
            dgvsatış.AutoGenerateColumns = true;
            dgvsatış.DataSource = sepet;
            try { dgvsatış.Columns["müşteriId"].Visible = false; } catch { }
            try { dgvsatış.Columns["ürünId"].Visible = false; } catch { }
        }
        private void müşteriDoldur()
        {

            DataTable dt = müşteribll.MüşteriListele();

            müşteriCb.DataSource = dt;
            müşteriCb.DisplayMember = "müşteriAdı";
            müşteriCb.ValueMember = "müşteriId";
            müşteriCb.SelectedIndex = -1;
            return;
        }
        private void ürünDoldur()
        {
            DataTable dt = ürünbll.Listele();

            ürünCb.DataSource = dt;
            ürünCb.DisplayMember = "ürünAdı";
            ürünCb.ValueMember = "ürünId";
            ürünCb.SelectedIndex = -1;
        }

        private void ürünCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ürünCb.SelectedIndex == -1) return;

            DataRowView row = ürünCb.SelectedItem as DataRowView;
            if (row == null) return;

            fiyatTxb.Text = row["fiyat"].ToString();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {

            if (müşteriCb.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen müşteri seçiniz.");
                return;
            }

            if (ürünCb.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen ürün seçiniz.");
                return;
            }

            if (string.IsNullOrEmpty(fiyatTxb.Text))
            {
                MessageBox.Show("Ürün fiyatı boş olamaz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(adetTxb.Text))
            {
                MessageBox.Show("Lütfen adet giriniz.");
                return;
            }
            if (!int.TryParse(adetTxb.Text, out int adet) || adet <= 0)
            {
                MessageBox.Show("Adet 0'dan büyük bir sayı olmalıdır.");
                return;
            }
            int müşteriId = Convert.ToInt32(müşteriCb.SelectedValue);
            string müşteriAdı = müşteriCb.Text;


            DataRowView ürünRow = ürünCb.SelectedItem as DataRowView;
            if (ürünRow == null)
            {
                MessageBox.Show("Ürün seçimi hatalı.");
                return;
            }
            int ürünId = Convert.ToInt32(ürünRow["ürünId"]);
            string ürünAdı = ürünRow["ürünAdı"].ToString();
            decimal fiyat = Convert.ToDecimal(ürünRow["fiyat"]);

            var mevcut = sepet.FirstOrDefault(x => x.ürünId == ürünId);

            if (mevcut != null)
            {
                mevcut.adet += adet;             
                mevcut.fiyat = fiyat;
                mevcut.tutar = mevcut.adet * mevcut.fiyat;
                dgvsatış.Refresh();
            }
            else
            {
                sepet.Add(new siparişkalem
                {
                    müşteriId = müşteriId,
                    müşteriAdı = müşteriAdı,
                    ürünId = ürünId,
                    ürünadı = ürünAdı,
                    adet = adet,
                    fiyat = fiyat,
                    tutar = adet * fiyat
                });

            }
            ToplamHesapla();


            ürünCb.SelectedIndex = -1;
            fiyatTxb.Text = "";
            adetTxb.Text = "";


        }
        private void ToplamHesapla()
        {
            decimal toplam = sepet.Sum(x => x.tutar);

            foreach (DataGridViewRow row in dgvsatış.Rows)
            {
                toplam += Convert.ToDecimal(row.Cells["Tutar"].Value);
            }
        }
        private void sipariştamamBtn_Click(object sender, EventArgs e)
        {

            if (sepet.Count == 0)
            {
                MessageBox.Show("Sepet boş.");
                return;
            }
            satışbll.SiparişTamamla(sepet.ToList());

            MessageBox.Show("Sipariş tamamlandı, stok düşüldü.");

         
            sepet.Clear();
            ToplamHesapla();
        }
    }
}

    