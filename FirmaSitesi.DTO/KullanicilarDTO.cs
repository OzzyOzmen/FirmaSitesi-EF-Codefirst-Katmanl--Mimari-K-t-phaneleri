using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSitesi.DTO
{
    public class KullanicilarDTO
    {

        public int KullaniciID { get; set; }

      
        public int KullaniciYetkiID { get; set; }

      
        public string KullaniciAdi { get; set; }

        public string KullaniciSifre { get; set; }

        public string AdSoyad { get; set; }

    
        public string Telefon { get; set; }

        public string Email { get; set; }
    }
}
