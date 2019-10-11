using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSitesi.DTO
{
   public class YazilarDTO
    {

        public int YazilarID { get; set; }

        public int YaziKategoriID { get; set; }

        public string YazilarBaslik { get; set; }

        public string YazilarIcerik { get; set; }

        public string KucukResim { get; set; }

        public string BuyukResim1 { get; set; }

        public string BuyukResim2 { get; set; }

        public string BuyukResim3 { get; set; }

        public string BuyukResim4 { get; set; }
    }
}
