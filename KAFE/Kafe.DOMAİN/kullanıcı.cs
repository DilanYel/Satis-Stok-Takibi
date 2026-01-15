using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAFE.Kafe.DOMAİN
{

    public enum kullanıcıRol
    {
        yönetici,
        satışpersoneli,
        depopersoneli
    }
    public class kullanıcı
    {
        public int kullanıcıId { get; set; }
        public string kullanıcıAdı { get; set; }
        public string kullanıcıŞifre { get; set; }
        public kullanıcıRol Rol { get; set; }
    }
}
