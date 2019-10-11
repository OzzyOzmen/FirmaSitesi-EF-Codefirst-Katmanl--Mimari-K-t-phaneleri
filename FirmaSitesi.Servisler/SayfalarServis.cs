using FirmaSitesi.ORM;
using FirmaSitesi.DTO;
using FirmaSitesi.Repository;
using System.Collections.Generic;
using System.Linq;

namespace FirmaSitesi.Servisler
{
    public class SayfalarServis
    {
        SayfalarRepository sayfalarRepository ;
        public SayfalarServis()
        {
            if (sayfalarRepository==null)
            {
                sayfalarRepository = new SayfalarRepository();
            }
        }
        public IEnumerable<SayfalarDTO> SayfaListele()
        {

            return sayfalarRepository.GetirListele().Select(x => new SayfalarDTO
            {
                SayfaID = x.SayfaID,
                SayfaBaslik = x.SayfaBaslik,
                SayfaIcerik = x.SayfaIcerik,
                KucukResim = x.KucukResim,
                BuyukResim = x.BuyukResim,
                SayfaUrl = x.SayfaUrl


            }).ToList();
        }

        public void SayfaEkle(SayfalarDTO entity)
        {
            Sayfalar sayfalar = new Sayfalar
            {
                SayfaBaslik = entity.SayfaBaslik,
                SayfaIcerik = entity.SayfaIcerik,
                KucukResim = entity.KucukResim,
                BuyukResim = entity.BuyukResim,
                SayfaUrl = entity.SayfaUrl

            };

            sayfalarRepository.Ekle(sayfalar);
            sayfalarRepository.Context.SaveChanges();
        }

        public void SayfaGuncelle(SayfalarDTO entity)
        {
            var Sayfa = sayfalarRepository.GetirListele().Where(r => r.SayfaID == entity.SayfaID).FirstOrDefault();
            Sayfa.SayfaBaslik = entity.SayfaBaslik;
            Sayfa.SayfaIcerik = entity.SayfaIcerik;
            Sayfa.KucukResim = entity.KucukResim;
            Sayfa.BuyukResim = entity.BuyukResim;
            Sayfa.SayfaUrl = entity.SayfaUrl;
            sayfalarRepository.Guncelle();
            sayfalarRepository.Context.SaveChanges();
        }

        public void SayfaSil(SayfalarDTO entity)
        {
            var Sayfa = sayfalarRepository.GetirListele().Where(r => r.SayfaID == entity.SayfaID).FirstOrDefault();
            Sayfa.SayfaBaslik = entity.SayfaBaslik;
            Sayfa.SayfaIcerik = entity.SayfaIcerik;
            Sayfa.KucukResim = entity.KucukResim;
            Sayfa.BuyukResim = entity.BuyukResim;
            Sayfa.SayfaUrl = entity.SayfaUrl;
            sayfalarRepository.Sil(Sayfa);
            sayfalarRepository.Context.SaveChanges();

        }
    }
 
}
