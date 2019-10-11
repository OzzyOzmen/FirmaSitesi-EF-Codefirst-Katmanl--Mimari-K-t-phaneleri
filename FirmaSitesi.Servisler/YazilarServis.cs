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
   public class YazilarServis
    {
        YazilarRepository yazilarRepository;

        public YazilarServis()
        {
            if (yazilarRepository==null)
            {
                yazilarRepository = new YazilarRepository();
            }
        }

        public IEnumerable<YazilarDTO> YaziListele()
        {
            return yazilarRepository.GetirListele().Select(r => new YazilarDTO
            {
                YazilarID = r.YazilarID,
                YaziKategoriID =r.YaziKategoriID,
                YazilarBaslik=r.YazilarBaslik,
                YazilarIcerik=r.YazilarIcerik,
                KucukResim=r.KucukResim,
                BuyukResim1=r.BuyukResim1,
                BuyukResim2=r.BuyukResim2,
                BuyukResim3=r.BuyukResim3,
                BuyukResim4=r.BuyukResim4
            
            }).ToList();
        }

        public void Yazilarekle(YazilarDTO entity)
        {
            Yazilar yazilar = new Yazilar
            {
                YaziKategoriID = entity.YaziKategoriID,
                YazilarBaslik = entity.YazilarBaslik,
                YazilarIcerik = entity.YazilarIcerik,
                KucukResim = entity.KucukResim,
                BuyukResim1 = entity.BuyukResim1,
                BuyukResim2 = entity.BuyukResim2,
                BuyukResim3 = entity.BuyukResim3,
                BuyukResim4 = entity.BuyukResim4
            };
            yazilarRepository.Ekle(yazilar);
        }

        public void YazilarGuncelle(YazilarDTO entity)
        {
            var yazi = yazilarRepository.GetirListele().Where(r => r.YazilarID == entity.YazilarID).FirstOrDefault();
            yazi.YaziKategoriID = entity.YaziKategoriID;
            yazi.YazilarBaslik = entity.YazilarBaslik;
            yazi.YazilarIcerik = entity.YazilarIcerik;
            yazi.KucukResim = entity.KucukResim;
            yazi.BuyukResim1 = entity.BuyukResim1;
            yazi.BuyukResim2 = entity.BuyukResim2;
            yazi.BuyukResim3 = entity.BuyukResim3;
            yazi.BuyukResim4 = entity.BuyukResim4;

            yazilarRepository.Guncelle();
            yazilarRepository.Context.SaveChanges();
        }

        public void YazilarSil(YazilarDTO entity)
        {
            var yazi = yazilarRepository.GetirListele().Where(r => r.YazilarID == entity.YazilarID).FirstOrDefault();
            yazi.YaziKategoriID = entity.YaziKategoriID;
            yazi.YazilarBaslik = entity.YazilarBaslik;
            yazi.YazilarIcerik = entity.YazilarIcerik;
            yazi.KucukResim = entity.KucukResim;
            yazi.BuyukResim1 = entity.BuyukResim1;
            yazi.BuyukResim2 = entity.BuyukResim2;
            yazi.BuyukResim3 = entity.BuyukResim3;
            yazi.BuyukResim4 = entity.BuyukResim4;

            yazilarRepository.Sil(yazi);
            yazilarRepository.Context.SaveChanges();
        }

    }
}
