using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAFE.Kafe.DOMAİN
{
    internal class adisyon
    {
        public int Id { get; set; }
        public int adisyonId { get; set; }
        public string ürün { get; set; }
        public int adet { get; set; }
        public decimal fiyat { get; set; }

    }
}
