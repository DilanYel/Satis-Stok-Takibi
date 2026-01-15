using KAFE.Kafe.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAFE.Kafe.BLL
{
    public class müşteriBLL
    {
        müşteriDAO dao = new müşteriDAO();
        public bool MüşteriEkle(string müşteriAdı, string tür)
        {

            if (müşteriAdı == "")
            {
                return false;
            }

            if (tür == "")
            {
                return false;
            }

            dao.MüşteriEkle(müşteriAdı, tür);
            return true;
        }
        public DataTable MüşteriListele()
        {
            return dao.MüşteriListele();
        }

        public bool MüşteriSil(int Id)
        {
            if (Id == 0)
                return false;

            dao.MüşteriSil(Id);
            return true;
        }

    }
}

