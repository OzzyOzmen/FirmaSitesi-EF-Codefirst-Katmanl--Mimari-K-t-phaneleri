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
   
    public class GaleriServis
    {
        GaleriRepository galeriRepository;

        public GaleriServis()
        {
            if (galeriRepository==null)
            {
                galeriRepository = new GaleriRepository();
            }
        }

        public IEnumerable<GaleriDTO> GaleriListele()
        {
            return galeriRepository.GetirListele().Select(x => new GaleriDTO
            {
                GaleriID=x.GaleriID,
                GaleriKategoriID=x.GaleriKategoriID,
                GaleriAdi=x.GaleriAdi,
                GaleriLogo=x.GaleriLogo,
                BuyukResim1=x.BuyukResim1,
                BuyukResim2=x.BuyukResim2,
                BuyukResim3=x.BuyukResim3,
                BuyukResim4=x.BuyukResim4

            }).ToList();
        }

        public void GaleriEkle(GaleriDTO entity)
        {
            Galeri galeri = new Galeri
            {
                GaleriAdi = entity.GaleriAdi,
                GaleriKategoriID = entity.GaleriKategoriID,
                GaleriLogo = entity.GaleriLogo,
                BuyukResim1 = entity.BuyukResim1,
                BuyukResim2 = entity.BuyukResim2,
                BuyukResim3 = entity.BuyukResim3,
                BuyukResim4 = entity.BuyukResim4

            };
            galeriRepository.Ekle(galeri);
            galeriRepository.Context.SaveChanges();

        }
        public void GaleriGuncelle(GaleriDTO entity)
        {
            var galeri = galeriRepository.GetirListele().Where(x => x.GaleriID == entity.GaleriID).FirstOrDefault();
            galeri.GaleriKategoriID = entity.GaleriKategoriID;
            galeri.GaleriAdi = entity.GaleriAdi;
            galeri.GaleriLogo = entity.GaleriLogo;
            galeri.BuyukResim1 = entity.BuyukResim1;
            galeri.BuyukResim2 = entity.BuyukResim2;
            galeri.BuyukResim3 = entity.BuyukResim3;
            galeri.BuyukResim4 = entity.BuyukResim4;

            galeriRepository.Guncelle();
            galeriRepository.Context.SaveChanges();
        }
        public void GaleriSil(GaleriDTO entity)
        {
            var galeri = galeriRepository.GetirListele().Where(r => r.GaleriID == entity.GaleriID).FirstOrDefault();
            galeri.GaleriKategoriID = entity.GaleriKategoriID;
            galeri.GaleriAdi = entity.GaleriAdi;
            galeri.GaleriLogo = entity.GaleriLogo;
            galeri.BuyukResim1 = entity.BuyukResim1;
            galeri.BuyukResim2 = entity.BuyukResim2;
            galeri.BuyukResim3 = entity.BuyukResim3;
            galeri.BuyukResim4 = entity.BuyukResim4;

            galeriRepository.Sil(galeri);
            galeriRepository.Context.SaveChanges();

        } 

        public bool GaleriSilbyID(int id)
        {
            return galeriRepository.SilByPredicate(r => r.GaleriID == id);

        }
        
    }
}
