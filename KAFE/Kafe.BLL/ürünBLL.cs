using KAFE.Kafe.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAFE.Kafe.BLL
{
    public class ürünBLL
    {
        public DataTable Listele()
        {
            return (new ürünDAO()).Listele();
        }
        public void kaydet(string gürünadı, string gkategori, int gfiyat, int gstok, int gminstok, decimal gmaliyet)
        {
            (new ürünDAO()).kaydet(gürünadı, gkategori, gfiyat, gstok, gminstok, gmaliyet);
        }
        public void sil(int gürünId)
        {
            if (gürünId <= 0)
                throw new Exception("Geçersiz ürün seçimi.");

            (new ürünDAO()).sil(gürünId);
        }

        public void güncelle(int gürünId, string gürünadı, string gkategori, decimal gfiyat, int gstok, int gminstok, decimal gmaliyet)
        {
            if (gürünId <= 0) throw new Exception("Geçersiz ürün seçimi.");
            if (string.IsNullOrWhiteSpace(gürünadı)) throw new Exception("Ürün adı boş olamaz.");
            if (gfiyat < 0) throw new Exception("Fiyat negatif olamaz.");
            if (gstok < 0) throw new Exception("Stok negatif olamaz.");
            if (gminstok < 0) throw new Exception("Min stok negatif olamaz.");
            (new ürünDAO()).güncelle(gürünId, gürünadı, gkategori, gfiyat, gstok, gminstok , gmaliyet);
        }

    }
}
