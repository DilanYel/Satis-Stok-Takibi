using KAFE.Kafe.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAFE.Kafe.BLL
{
    public class raporBLL
    {
        raporDAO rapordao = new raporDAO();

        public DataTable minimumStokListele()
        {
            return rapordao.minimumStokGetir();
        }

        public DataTable günlükSatışListele(DateTime tarih)
        {
            return rapordao.günlükSatışGetir(tarih);
        }
        public decimal günlüktoplamcirogetir(DateTime tarih)
        {
            return rapordao.günlükToplamCiroGetir(tarih);
        }
        public int toplamürünadediGetir(DateTime tarih)
        {
            return rapordao.toplamÜrünadediGetir(tarih);
        }
        public int günlüksiparişsayısıGetir(DateTime tarih)
        {
            return rapordao.günlüksiparişsayısıGetir(tarih);
        }
        public DataTable müşteriBazlıCiroListele(DateTime tarih)
        {
            return rapordao.müşteribazlıraporlarıListele(tarih);
        }

        public DataTable günlükençoksatılanürünGetir(DateTime tarih)
        {
            return rapordao.ençoksatılanürünGetir(tarih);
        }
    }
}
