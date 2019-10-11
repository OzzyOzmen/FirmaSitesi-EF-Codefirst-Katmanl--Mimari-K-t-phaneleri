using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSitesi.DTO
{
   public class IletisimDTO
    {
        public int IletisimID { get; set; }

        public string Gonderen { get; set; }

        public string IletisimMesaj { get; set; }

        public string GonderiTarih { get; set; }

        public bool Okundu { get; set; }
    }
}
