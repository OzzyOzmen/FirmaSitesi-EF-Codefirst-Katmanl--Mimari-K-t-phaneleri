using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSitesi.DTO
{
   public class SayfalarDTO
    {
        public int SayfaID { get; set; }
        public string SayfaBaslik { get; set; }
        public string SayfaIcerik { get; set; }
        public string KucukResim { get; set; }
        public string BuyukResim { get; set; }
        public string SayfaUrl { get; set; }
    }
}
