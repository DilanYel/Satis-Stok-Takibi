using KAFE.Kafe.BLL;
using KAFE.Kafe.UI;
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
    public partial class RaportForm : Form
    {
        raporBLL raporbll = new raporBLL();
        public RaportForm()
        {
            InitializeComponent();
        }

        private void raporgetirBtn_Click(object sender, EventArgs e)
        {

            DateTime seçilenTarih = dtptarih.Value.Date;
            dgvminstok.DataSource = raporbll.minimumStokListele();
            dgvgünlükdetay.DataSource = raporbll.günlükSatışListele(seçilenTarih);
            toplamCiroyükle(seçilenTarih);
            toplamürünadediYükle(seçilenTarih);
            siparişsayısıYükle(seçilenTarih);
            dgvmüşreriCiro.DataSource = raporbll.müşteriBazlıCiroListele(seçilenTarih);
            DataTable dt3 = raporbll.günlükençoksatılanürünGetir(seçilenTarih);
            grafikÇiz(dt3);
        }
        private void toplamCiroyükle(DateTime seçilenTarih)
        {
            decimal ciro = raporbll.günlüktoplamcirogetir(seçilenTarih);
            ciroLbl.Text = ciro.ToString("0.00") + " ₺";
        }
        private void toplamürünadediYükle(DateTime seçilenTarih)
        {
            int adet = raporbll.toplamürünadediGetir(seçilenTarih);
            ürünLbl.Text = adet.ToString();
        }
        private void siparişsayısıYükle(DateTime seçilenTarih)
        {
            int sayı = raporbll.günlüksiparişsayısıGetir(seçilenTarih);
            siparişLbl.Text = sayı.ToString();
        }
        private void grafikÇiz(DataTable dt)
        {
            formsPlot1.Plot.Clear();
            if (dt == null || dt.Rows.Count == 0)
            {
                formsPlot1.Plot.Title("Seçilen günde satış yok");
                formsPlot1.Refresh();
                return;
            }
            int satırSayısı = dt.Rows.Count;
            string[] ürünİsimleri = new string[satırSayısı];
            double[] ürünAdetleri = new double[satırSayısı];
            double[] xKonumlari = new double[satırSayısı];

            for (int i = 0; i < satırSayısı; i++)
            {
                ürünİsimleri[i] = dt.Rows[i]["Ürün"].ToString();
                ürünAdetleri[i] = Convert.ToDouble(dt.Rows[i]["Toplam Adet"]);
                xKonumlari[i] = i;
            }
            var bars = formsPlot1.Plot.Add.Bars(ürünAdetleri);
            var limits = formsPlot1.Plot.Axes.GetLimits();
            formsPlot1.Plot.Axes.SetLimits(limits.Left, limits.Right, 0, limits.Top);
            formsPlot1.Plot.Axes.Bottom.SetTicks(xKonumlari, ürünİsimleri);
            formsPlot1.Plot.Axes.Bottom.TickLabelStyle.Rotation = 90;
            formsPlot1.Plot.Title("Günlük En Çok Satılan 3 Ürün");
            formsPlot1.Plot.YLabel("Adet");

            formsPlot1.Refresh();

        }

        private void aylıkRaporBtn_Click(object sender, EventArgs e)
        {
            aylıkrapor aylıkrapor = new aylıkrapor();
            aylıkrapor.Show();
        }
    }
}
