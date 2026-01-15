using KAFE.Kafe.DAL;
using KAFE.Kafe.DOMAİN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAFE.Kafe.BLL
{
    public class kullanıcıgirişBLL
    {
        public bool girişyap(string gkullAdı, string gkullŞifre)
        {
            return (new kullanıcıDAO())
                .girişkontrol(gkullAdı, gkullŞifre);
        }
        public kullanıcı girişYapankullanıcı(string gkullAdı, string gkullŞifre)
        {
            if (gkullAdı.Trim() == "" || gkullŞifre.Trim() == "")
            {
                throw new Exception("Kullanıcı adı ve şifre boş olamaz.");
            }

            var dao = new kullanıcıDAO();
            var kullanıcı = dao.kullanıcıGetir(gkullAdı, gkullŞifre);

            if (kullanıcı == null)
            {
                throw new Exception("Kullanıcı adı veya şifre hatalı.");
            }

            return kullanıcı;
        }
    }
}
