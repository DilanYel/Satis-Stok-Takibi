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

namespace KAFE.Kafe.UI
{
    public partial class aylıkrapor : Form
    {
        aylıkraporBLL bLL = new aylıkraporBLL();
        public aylıkrapor()
        {
            InitializeComponent();
        }

        private void AylıkraporBtn_Click(object sender, EventArgs e)
        {
            var sonuç = bLL.AylikÖzetGetir(dateTimePicker1.Value);
            var mz = bLL.AylıkMaliyetVeKarZararGetir(dateTimePicker1.Value);
            if (sonuç.toplamCiro == 0 && sonuç.satışSayısı == 0)
            {
                aylıkMaliyet.Text = "0₺";
                aylıkCiro.Text = "0₺";
                aylıksatışsayısı.Text = "0";
                karzarar.Text = "0₺";
                MessageBox.Show("Seçilen ayda satış bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            aylıkCiro.Text = sonuç.toplamCiro.ToString("N2") + " ₺";
            aylıksatışsayısı.Text = sonuç.satışSayısı.ToString();
            aylıkMaliyet.Text = mz.toplamMaliyet.ToString("N2") + " ₺";
            karzarar.Text = mz.karZarar.ToString("N2") + " ₺";
            var dt = bLL.aylıkençoksatılanlar(dateTimePicker1.Value);
            Aylıkrapordgv.DataSource = dt;

        }
    }
}
