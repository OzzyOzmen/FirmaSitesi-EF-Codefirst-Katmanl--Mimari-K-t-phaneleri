using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSitesi.DTO
{
   public class UrunlerDTO
    {

        public int UrunID { get; set; }

        public int UrunKategoriID { get; set; }

        public int TedarikciID { get; set; }

        public string UrunAdi { get; set; }

        public short UrunStokAdeti { get; set; }

        public decimal UrunFiyati { get; set; }

    }
}
