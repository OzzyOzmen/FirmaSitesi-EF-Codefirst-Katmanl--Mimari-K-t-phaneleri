using FirmaSitesi.DTO;
using FirmaSitesi.Repository;
using FirmaSitesi.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSitesi.Servisler
{
   public class KullaniciYetkiServis
    {

        KullaniciYetkiRepository kullaniciYetkiRepository;

        public KullaniciYetkiServis()
        {
            if (kullaniciYetkiRepository==null)
            {
                kullaniciYetkiRepository = new KullaniciYetkiRepository();
            }
        }
           

      public  IEnumerable<KullaniciYetkiDTO> KullaniciYetkiListele()
        {
            return kullaniciYetkiRepository.GetirListele().Select(r => new KullaniciYetkiDTO
            {
                KullaniciYetkiID=r.KullaniciYetkiID,
                KullaniciYetkisi=r.KullaniciYetkisi

            }).ToList();
        }

        public void KullaniciYetkiEkle(KullaniciYetkiDTO entity)
        {
            KullaniciYetki kullaniciYetki = new KullaniciYetki
            {
                KullaniciYetkisi=entity.KullaniciYetkisi
            };

            kullaniciYetkiRepository.Ekle(kullaniciYetki);

        }

        public void KullaniciYetkiGuncelle(KullaniciYetkiDTO entity)
        {
            var kullaniciYetki = kullaniciYetkiRepository.GetirListele().Where(r => r.KullaniciYetkiID == entity.KullaniciYetkiID).FirstOrDefault();
            kullaniciYetki.KullaniciYetkisi = entity.KullaniciYetkisi;

            kullaniciYetkiRepository.Guncelle();
            kullaniciYetkiRepository.Context.SaveChanges();

        }

        public void KullaniciYetkiSil(KullaniciYetkiDTO entity)
        {
            var kullaniciYetki = kullaniciYetkiRepository.GetirListele().Where(r => r.KullaniciYetkiID == entity.KullaniciYetkiID).FirstOrDefault();
            kullaniciYetki.KullaniciYetkisi = entity.KullaniciYetkisi;

            kullaniciYetkiRepository.Sil(kullaniciYetki);

        }


    }
}
