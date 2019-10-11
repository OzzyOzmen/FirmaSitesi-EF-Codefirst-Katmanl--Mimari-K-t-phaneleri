using FirmaSitesi.DTO;
using FirmaSitesi.ORM;
using FirmaSitesi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSitesi.Servisler
{
   public class TumKullanicilarServis
    {

        TumKullanicilarRepository tumKullanicilarRepository;

        public TumKullanicilarServis()
        {
            if (tumKullanicilarRepository==null)
            {
                tumKullanicilarRepository = new TumKullanicilarRepository();
            }
        }

        public IEnumerable<TumKullanicilarDTO> TumKullanicilarListele()
        {
            return tumKullanicilarRepository.GetirListele().Select(x => new TumKullanicilarDTO
            {
                KullaniciID=x.KullaniciID,
                KullaniciYetki=x.KullaniciYetki,
                KullaniciAdi=x.KullaniciAdi,
                KullaniciSifre=x.KullaniciSifre,
                AdSoyad=x.AdSoyad,
                Telefon=x.Telefon,
                Email=x.Email

            }).ToList();
        }



        // View olduğu için sadece çekme listeleme işlemi yaptım.
    }
}
