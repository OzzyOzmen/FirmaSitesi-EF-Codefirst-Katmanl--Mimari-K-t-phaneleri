using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSitesi.DTO
{
   public class TumUrunlerDTO
    {

        public int UrunID { get; set; }

        public string UrunKategoriAdi { get; set; }

        public string UrunAdi { get; set; }

        public short UrunStokAdeti { get; set; }

        public decimal UrunFiyati { get; set; }

        public string TedarikciAdi { get; set; }

    }
}
