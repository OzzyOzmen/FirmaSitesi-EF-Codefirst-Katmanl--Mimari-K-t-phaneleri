using FirmaSitesi.ORM;
using FirmaSitesi.Repository;
using FirmaSitesi.DTO;
using System.Collections.Generic;
using System.Linq;

namespace FirmaSitesi.Servisler
{
    public class HizmetlerServis
    {
        HizmetlerRepository hizmetlerRepository;

        public HizmetlerServis()
        {
            if (hizmetlerRepository==null)
            {
                hizmetlerRepository = new HizmetlerRepository();
            }
        }

        public IEnumerable<HizmetlerDTO> ServislerListele()
        {
            return hizmetlerRepository.GetirListele().Select(x => new HizmetlerDTO
            {
                HizmetID = x.HizmetID,
                HizmetBaslik = x.HizmetBaslik,
                HizmetIcerik = x.HizmetIcerik,
                KucukResim = x.KucukResim,
                BuyukResim1 = x.BuyukResim1,
                BuyukResim2 = x.BuyukResim2,
                BuyukResim3 = x.BuyukResim3,
                BuyukResim4 = x.BuyukResim4

            }).ToList();
        }

        public void HizmetlerEkle(HizmetlerDTO entity)
        {

           Hizmetler hizmet = new Hizmetler
            {
                HizmetBaslik=entity.HizmetBaslik,
                HizmetIcerik=entity.HizmetIcerik,
                KucukResim=entity.KucukResim,
                BuyukResim1=entity.BuyukResim1,
                BuyukResim2=entity.BuyukResim2,
                BuyukResim3=entity.BuyukResim3,
                BuyukResim4=entity.BuyukResim4

            };
            hizmetlerRepository.Ekle(hizmet);

        }

        public void HizmetGuncelle(HizmetlerDTO entity)
        {
            var hizmet = hizmetlerRepository.GetirListele().Where(r => r.HizmetID == entity.HizmetID).FirstOrDefault();
            hizmet.HizmetBaslik = entity.HizmetBaslik;
            hizmet.HizmetIcerik = entity.HizmetIcerik;
            hizmet.KucukResim = entity.KucukResim;
            hizmet.BuyukResim1 = entity.BuyukResim1;
            hizmet.BuyukResim2 = entity.BuyukResim2;
            hizmet.BuyukResim3 = entity.BuyukResim3;
            hizmet.BuyukResim4 = entity.BuyukResim4;

            hizmetlerRepository.Guncelle();
            hizmetlerRepository.Context.SaveChanges();
        }

        public void HizmetSil(HizmetlerDTO entity)
        {
            var hizmet = hizmetlerRepository.GetirListele().Where(r => r.HizmetID == entity.HizmetID).FirstOrDefault();
            hizmet.HizmetBaslik = entity.HizmetBaslik;
            hizmet.HizmetIcerik = entity.HizmetIcerik;
            hizmet.KucukResim = entity.KucukResim;
            hizmet.BuyukResim1 = entity.BuyukResim1;
            hizmet.BuyukResim2 = entity.BuyukResim2;
            hizmet.BuyukResim3 = entity.BuyukResim3;
            hizmet.BuyukResim4 = entity.BuyukResim4;

            hizmetlerRepository.Sil(hizmet);
        }
    }
}
