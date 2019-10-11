using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSitesi.DTO
{
   public class ReferanslarDTO
    {

        public int ReferansID { get; set; }
        public int ReferansKategoriID { get; set; }

        public string ReferansAdi { get; set; }

        public string ReferansAciklama { get; set; }

        public string ReferansLogo { get; set; }
    }
}
