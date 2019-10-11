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
    public class ReferansKategoriServis
    {
        ReferansKategoriRepository referansKategoriRepository;

        public ReferansKategoriServis()
        {
            if (referansKategoriRepository==null)
            {
                referansKategoriRepository = new ReferansKategoriRepository();
            }
        }

        public IEnumerable<ReferansKategoriDTO> ReferansKategoriListele()
        {
            return referansKategoriRepository.GetirListele().Select(x => new ReferansKategoriDTO
            {
                ReferansKategoriID=x.ReferansKategoriID,
                ReferansKategoriAdi=x.ReferansKategoriAdi

            }).ToList();
        }

        public void ReferansKategoriEkle(ReferansKategoriDTO entity)
        {
            ReferansKategori referansKategori = new ReferansKategori
            {
                ReferansKategoriAdi=entity.ReferansKategoriAdi


            };

            referansKategoriRepository.Ekle(referansKategori);
        }

        public void ReferansKategoriGuncelle(ReferansKategoriDTO entity)
        {
            var referansKategori = referansKategoriRepository.GetirListele().Where(x => x.ReferansKategoriID == entity.ReferansKategoriID).FirstOrDefault();
            referansKategori.ReferansKategoriAdi = entity.ReferansKategoriAdi;

            referansKategoriRepository.Guncelle();
            referansKategoriRepository.Context.SaveChanges();
        }

        public void ReferansKategoriSil(ReferansKategoriDTO entity)
        {
            var referansKategori = referansKategoriRepository.GetirListele().Where(x => x.ReferansKategoriID == entity.ReferansKategoriID).FirstOrDefault();
            referansKategori.ReferansKategoriAdi = entity.ReferansKategoriAdi;

            referansKategoriRepository.Sil(referansKategori);
        }

    }
}
