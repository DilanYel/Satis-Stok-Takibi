using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAFE.Kafe.DOMAİN
{
   public class siparişkalem
    {
        public int müşteriId { get; set; }
        public string müşteriAdı { get; set; }
        public int ürünId { get; set; }
        public string ürünadı { get; set; }
        public int adet { get; set; }
        public decimal fiyat { get; set; }
        public decimal tutar { get; set; }
    }



}
