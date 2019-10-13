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
   public class UrunKategoriServis
    {
        UrunKategoriRepository urunKategoriRepository;
        public UrunKategoriServis()
        {
            if (urunKategoriRepository==null)
            {
                urunKategoriRepository = new UrunKategoriRepository();
            }
        }

        public IEnumerable<UrunKategoriDTO> UrunKategoriListele()
        {
            return urunKategoriRepository.GetirListele().Select(x => new UrunKategoriDTO
            {
                UrunKategoriID=x.UrunKategoriID,
                UrunKategoriAdi=x.UrunKategoriAdi

            }).ToList();
        }

        public void UrunKategoriEkle(UrunKategoriDTO entity)
        {
            UrunKategori urunKategori = new UrunKategori
            {
              UrunKategoriAdi=entity.UrunKategoriAdi
            };

            urunKategoriRepository.Ekle(urunKategori);
            urunKategoriRepository.Context.SaveChanges();

        }

        public void UrunKategoriGuncelle(UrunKategoriDTO entity)
        {
            var urunkategori = urunKategoriRepository.GetirListele().Where(r => r.UrunKategoriID == entity.UrunKategoriID).FirstOrDefault();
            urunkategori.UrunKategoriAdi = entity.UrunKategoriAdi;
            urunKategoriRepository.Guncelle();
            urunKategoriRepository.Context.SaveChanges();
        }

        public void UrunKategoriSil(UrunKategoriDTO entity)
        {
            var urunkategori = urunKategoriRepository.GetirListele().Where(r => r.UrunKategoriID == entity.UrunKategoriID).FirstOrDefault();
            urunkategori.UrunKategoriAdi = entity.UrunKategoriAdi;
            urunKategoriRepository.Sil(urunkategori);
            urunKategoriRepository.Context.SaveChanges();
        }

        public bool UrunKategoriSilbyId(int id)
        {
            return urunKategoriRepository.SilByPredicate(r => r.UrunKategoriID == id);
        }
    }
}
