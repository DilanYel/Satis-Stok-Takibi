using KAFE.Kafe.DOMAİN;
using KAFE.Kafe.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KAFE.Kafe.BLL
{
    public class satışlarBLL
    {
        ürünDAO üründao = new ürünDAO();
        satışlarDAO dao = new satışlarDAO();

        public DataTable satışlarıGetir()
        {
            return dao.satışlarıGetir();
        }

        public void satışEkle(siparişkalem k)
        {
            if (k == null) throw new Exception("Satış kalemi boş.");

            dao.satışEkle(
                k.müşteriId,
                k.müşteriAdı,
                k.ürünId,
                k.ürünadı,
                k.adet,
                k.fiyat,
                k.tutar
            );
        }
        public void SiparişTamamla(List<siparişkalem> kalemler)
        {
            if (kalemler == null || kalemler.Count == 0)
                throw new Exception("Sepet boş.");

            foreach (var k in kalemler)
            {
                if (k.adet <= 0)
                    throw new Exception($"Adet hatalı: {k.ürünadı}");

                int stok = üründao.stokGetir(k.ürünId);

                if (stok < k.adet)
                    throw new Exception($"Stok yetersiz: {k.ürünadı} (Stok: {stok}, İstenen: {k.adet})");
            }
            foreach (var k in kalemler)
            {
              
                dao.satışEkle(
                    k.müşteriId,
                    k.müşteriAdı,
                    k.ürünId,
                    k.ürünadı,
                    k.adet,
                    k.fiyat,
                    k.tutar
                );
                üründao.stokDüş(k.ürünId, k.adet);
            }
        }

    }
}
