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
   public class KullanicilarServis
    {

        KullanicilarRepository kullanicilarRepository;

        public KullanicilarServis()
        {
            if (kullanicilarRepository==null)
            {
                kullanicilarRepository = new KullanicilarRepository();
            }
        }

        public IEnumerable<KullanicilarDTO> KullanicilarListeler()
        {
            return kullanicilarRepository.GetirListele().Select(x => new KullanicilarDTO
            {

                KullaniciID=x.KullaniciID,
                KullaniciYetkiID=x.KullaniciYetkiID,
                KullaniciAdi=x.KullaniciAdi,
                KullaniciSifre=x.KullaniciSifre,
                AdSoyad=x.AdSoyad,
                Telefon=x.Telefon,
                Email=x.Email

            }).ToList();
        }

        public void KullanicilarEkle(KullanicilarDTO entity)
        {
            Kullanici kullanici = new Kullanici
            {
                KullaniciYetkiID = entity.KullaniciYetkiID,
                KullaniciAdi = entity.KullaniciAdi,
                KullaniciSifre = entity.KullaniciSifre,
                AdSoyad = entity.AdSoyad,
                Telefon = entity.Telefon,
                Email = entity.Email

            };

            kullanicilarRepository.Ekle(kullanici);
            kullanicilarRepository.Context.SaveChanges();
        }

        public void KullanicilarGuncelle(KullanicilarDTO entity)
        {
            var kullanici = kullanicilarRepository.GetirListele().Where(r => r.KullaniciID == entity.KullaniciID).FirstOrDefault();
            kullanici.KullaniciAdi = entity.KullaniciAdi;
            kullanici.KullaniciSifre = entity.KullaniciSifre;
            kullanici.AdSoyad = entity.AdSoyad;
            kullanici.Telefon = entity.Telefon;
            kullanici.Email = entity.Email;

            kullanicilarRepository.Guncelle();
            kullanicilarRepository.Context.SaveChanges();

           
        }

        public void KullanicilarSil(KullanicilarDTO entity)
        {
            var kullanici = kullanicilarRepository.GetirListele().Where(r => r.KullaniciID == entity.KullaniciID).FirstOrDefault();
            kullanici.KullaniciAdi = entity.KullaniciAdi;
            kullanici.KullaniciSifre = entity.KullaniciSifre;
            kullanici.AdSoyad = entity.AdSoyad;
            kullanici.Telefon = entity.Telefon;
            kullanici.Email = entity.Email;

            kullanicilarRepository.Sil(kullanici);
            kullanicilarRepository.Context.SaveChanges();
        }

        public bool KullanicilarSilbyId(int id)
        {
            return kullanicilarRepository.SilByPredicate(r => r.KullaniciID == id);

        }
    }
}
