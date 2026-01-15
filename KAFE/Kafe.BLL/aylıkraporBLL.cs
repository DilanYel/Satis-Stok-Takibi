using KAFE.Kafe.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAFE.Kafe.BLL
{
  
    public class aylıkraporBLL
    {
        aylıkraporDAO dao = new aylıkraporDAO();
        public (decimal toplamCiro, int satışSayısı) AylikÖzetGetir(DateTime seçilenTarih)
        {
            DateTime başlangıç = new DateTime(seçilenTarih.Year, seçilenTarih.Month, 1);
            DateTime bitis = başlangıç.AddMonths(1);
            return dao.AylikÖzetGetir(başlangıç, bitis);
        }

        public DataTable aylıkençoksatılanlar(DateTime seçilenTarih)
        {
            DateTime başlangıç = new DateTime(seçilenTarih.Year, seçilenTarih.Month, 1);
            DateTime bitiş = başlangıç.AddMonths(1);
            return dao.aylıkençoksatılanlar(başlangıç, bitiş);
        }
        public (decimal toplamMaliyet, decimal karZarar) AylıkMaliyetVeKarZararGetir(DateTime ay)
        {
            DateTime başlangıç = new DateTime(ay.Year, ay.Month, 1);
            DateTime bitiş = başlangıç.AddMonths(1);
            return dao.AylıkMaliyetVeKarZararGetir(başlangıç, bitiş);
        }
    }
}
