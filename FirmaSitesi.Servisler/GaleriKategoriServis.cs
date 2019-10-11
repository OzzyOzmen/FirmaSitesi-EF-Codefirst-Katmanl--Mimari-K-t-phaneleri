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
    public class GaleriKategoriServis
    {
        GaleriKategoriRepository galeriKategoriRepository;

        public GaleriKategoriServis()
        {
            if (galeriKategoriRepository==null)
            {
                galeriKategoriRepository = new GaleriKategoriRepository();
            } 
        }

        public IEnumerable<GaleriKategoriDTO> GaleriKateogriListele()
        {
            return galeriKategoriRepository.GetirListele().Select(x => new GaleriKategoriDTO
            {

                GaleriKategoriID=x.GaleriKategoriID,
                GaleriKategoriAdi=x.GaleriKategoriAdi

            }).ToList();
        }

        public void GaleriKategoriEkle(GaleriKategoriDTO entity)
        {
            GaleriKategori galeriKategori = new GaleriKategori
            {
                GaleriKategoriAdi = entity.GaleriKategoriAdi

            };

            galeriKategoriRepository.Ekle(galeriKategori);
            galeriKategoriRepository.Context.SaveChanges();

        }

        public void GaleriKategoriGuncelle(GaleriKategoriDTO entity)
        {
            var galeriKategori = galeriKategoriRepository.GetirListele().Where(r => r.GaleriKategoriID == entity.GaleriKategoriID).FirstOrDefault();

            galeriKategori.GaleriKategoriAdi = entity.GaleriKategoriAdi;

            galeriKategoriRepository.Guncelle();
            galeriKategoriRepository.Context.SaveChanges();

        }

        public void GaleriKategoriSil(GaleriKategoriDTO entity)
        {
            var galeriKategori = galeriKategoriRepository.GetirListele().Where(r => r.GaleriKategoriID == entity.GaleriKategoriID).FirstOrDefault();
              galeriKategori.GaleriKategoriAdi = entity.GaleriKategoriAdi;

            galeriKategoriRepository.Sil(galeriKategori);
            galeriKategoriRepository.Context.SaveChanges();
        }

    }
}
