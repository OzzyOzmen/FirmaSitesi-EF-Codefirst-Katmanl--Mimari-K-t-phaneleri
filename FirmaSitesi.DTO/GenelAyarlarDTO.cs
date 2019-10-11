using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSitesi.DTO
{
   public class GenelAyarlarDTO
    {
        public int GenelAyarID { get; set; }

        public string WebsiteAdi { get; set; }
        public string WebsiteAdresi { get; set; }

        public string AdSoyad { get; set; }

        public string KullaniciAdi { get; set; }

        public string KullaniciSifre { get; set; }

        public string EmailAdresi { get; set; }

        public string WebsiteEmail { get; set; }

        public string WebsiteEmailParola { get; set; }

        public string SmtpAdres { get; set; }

        public int SmptPort { get; set; }
    }
}
