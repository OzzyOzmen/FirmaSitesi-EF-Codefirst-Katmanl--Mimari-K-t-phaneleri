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
    public class ReferanslarServis
    {
        ReferanslarRepository referanslarRepository;

        public ReferanslarServis()
        {
            if (referanslarRepository==null)
            {
                referanslarRepository = new ReferanslarRepository();
            }
        }

        public IEnumerable<ReferanslarDTO> ReferanslarListele()
        {
            return referanslarRepository.GetirListele().Select(x => new ReferanslarDTO
            {
                ReferansID=x.ReferansID,
                ReferansKategoriID=x.ReferansKategoriID,
                ReferansAdi=x.ReferansAdi,
                ReferansAciklama=x.ReferansAciklama,
                ReferansLogo=x.ReferansLogo

            }).ToList();

        }

        public void ReferanslarEkle(ReferanslarDTO entity)
        {
            Referanslar referanslar = new Referanslar
            {

                ReferansKategoriID=entity.ReferansKategoriID,
                ReferansAdi=entity.ReferansAdi,
                ReferansAciklama=entity.ReferansAciklama,
                ReferansLogo=entity.ReferansLogo

            };

            referanslarRepository.Ekle(referanslar);
        }

        public void ReferanslarGuncelle(ReferanslarDTO entity)
        {
            var referans = referanslarRepository.GetirListele().Where(r => r.ReferansID == entity.ReferansID).FirstOrDefault();
            referans.ReferansKategoriID = entity.ReferansKategoriID;
            referans.ReferansAdi = entity.ReferansAdi;
            referans.ReferansAciklama = entity.ReferansAciklama;
            referans.ReferansLogo = entity.ReferansLogo;

            referanslarRepository.Guncelle();
            referanslarRepository.Context.SaveChanges();
        }

        public void ReferanslarSil(ReferanslarDTO entity)
        {
            var referans = referanslarRepository.GetirListele().Where(r => r.ReferansID == entity.ReferansID).FirstOrDefault();
            referans.ReferansKategoriID = entity.ReferansKategoriID;
            referans.ReferansAdi = entity.ReferansAdi;
            referans.ReferansAciklama = entity.ReferansAciklama;
            referans.ReferansLogo = entity.ReferansLogo;

            referanslarRepository.Sil(referans);
        }

    }
}
