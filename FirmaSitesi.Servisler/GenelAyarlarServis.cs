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
    public class GenelAyarlarServis
    {
        GenelAyarlarRepository genelAyarlarRepository;

        public GenelAyarlarServis()
        {
            if (genelAyarlarRepository==null)
            {
                genelAyarlarRepository = new GenelAyarlarRepository();
            }
        }
        public IEnumerable<GenelAyarlarDTO> GenelAyarlarListele()
        {
            return genelAyarlarRepository.GetirListele().Select(x => new GenelAyarlarDTO
            {
                GenelAyarID=x.GenelAyarID,
                AdSoyad =x.AdSoyad,
                EmailAdresi=x.EmailAdresi,
                KullaniciAdi=x.KullaniciAdi,
                KullaniciSifre=x.KullaniciSifre,
                WebsiteAdi=x.WebsiteAdi,
                WebsiteAdresi=x.WebsiteAdresi,
                WebsiteEmail=x.WebsiteEmail,
                WebsiteEmailParola=x.WebsiteEmailParola,
                SmtpAdres = x.SmtpAdres,
                SmptPort = x.SmtpPort

            }).ToList();

        }

        public void GenelAyarlarEkle(GenelAyarlarDTO entity)
        {
            GenelAyarlar genelAyarlar = new GenelAyarlar
            {

                AdSoyad = entity.AdSoyad,
                EmailAdresi = entity.EmailAdresi,
                KullaniciAdi = entity.KullaniciAdi,
                KullaniciSifre = entity.KullaniciSifre,
                WebsiteAdi = entity.WebsiteAdi,
                WebsiteAdresi = entity.WebsiteAdresi,
                WebsiteEmail = entity.WebsiteEmail,
                WebsiteEmailParola = entity.WebsiteEmailParola,
                SmtpAdres = entity.SmtpAdres,
                SmtpPort = entity.SmptPort
            };

            genelAyarlarRepository.Ekle(genelAyarlar);
        }

        public void GenelAyarlarGuncelle(GenelAyarlarDTO entity)
        {

            var genelayar = genelAyarlarRepository.GetirListele().Where(r => r.GenelAyarID == entity.GenelAyarID).FirstOrDefault();
            genelayar.AdSoyad = entity.AdSoyad;
            genelayar.EmailAdresi = entity.EmailAdresi;
            genelayar.KullaniciAdi = entity.KullaniciAdi;
            genelayar.KullaniciSifre = entity.KullaniciSifre;
            genelayar.WebsiteAdi = entity.WebsiteAdi;
            genelayar.WebsiteAdresi = entity.WebsiteAdresi;
            genelayar.WebsiteEmail = entity.WebsiteEmail;
            genelayar.WebsiteEmailParola = entity.WebsiteEmailParola;
            genelayar.SmtpAdres = entity.SmtpAdres;
            genelayar.SmtpPort = entity.SmptPort;

            genelAyarlarRepository.Guncelle();
            genelAyarlarRepository.Context.SaveChanges();

        }

        public void GenelAyarlarSil(GenelAyarlarDTO entity)
        {
            var genelayar = genelAyarlarRepository.GetirListele().Where(r => r.GenelAyarID == entity.GenelAyarID).FirstOrDefault();
            genelayar.AdSoyad = entity.AdSoyad;
            genelayar.EmailAdresi = entity.EmailAdresi;
            genelayar.KullaniciAdi = entity.KullaniciAdi;
            genelayar.KullaniciSifre = entity.KullaniciSifre;
            genelayar.WebsiteAdi = entity.WebsiteAdi;
            genelayar.WebsiteAdresi = entity.WebsiteAdresi;
            genelayar.WebsiteEmail = entity.WebsiteEmail;
            genelayar.WebsiteEmailParola = entity.WebsiteEmailParola;
            genelayar.SmtpAdres = entity.SmtpAdres;
            genelayar.SmtpPort = entity.SmptPort;

            genelAyarlarRepository.Sil(genelayar);
        }

    }
}
