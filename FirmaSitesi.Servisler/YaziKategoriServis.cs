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
   public class YaziKategoriServis
    {
        YaziKategoriRepository yaziKategoriRepository;

        public YaziKategoriServis()
        {
            if (yaziKategoriRepository==null)
            {
                yaziKategoriRepository = new YaziKategoriRepository();
            }
        }

        public IEnumerable<YaziKategoriDTO> YaziKategoriListele()
        {
            return yaziKategoriRepository.GetirListele().Select(x => new YaziKategoriDTO
            {
                YaziKategoriID=x.YaziKategoriID,
                YaziKategoriAdi=x.YaziKategoriAdi

            }).ToList();
        }

        public void YaziKategoriEkle(YaziKategoriDTO entity)
        {
            YaziKategori yaziKategori = new YaziKategori
            {
                YaziKategoriAdi=entity.YaziKategoriAdi
            };
            yaziKategoriRepository.Ekle(yaziKategori);
            yaziKategoriRepository.Context.SaveChanges();

        }

        public void YaziKategoriGuncelle(YaziKategoriDTO entity)
        {
            var yazikategori = yaziKategoriRepository.GetirListele().Where(r => r.YaziKategoriID == entity.YaziKategoriID).FirstOrDefault();
            yazikategori.YaziKategoriAdi = entity.YaziKategoriAdi;
            yaziKategoriRepository.Guncelle();
            yaziKategoriRepository.Context.SaveChanges();
        }

        public void YaziKategoriSil(YaziKategoriDTO entity)
        {
            var yazikategori = yaziKategoriRepository.GetirListele().Where(r => r.YaziKategoriID == entity.YaziKategoriID).FirstOrDefault();
            yazikategori.YaziKategoriAdi = entity.YaziKategoriAdi;
            yaziKategoriRepository.Sil(yazikategori);
            yaziKategoriRepository.Context.SaveChanges();
        }

        public bool YaziKategoriSilbyId(int id)
        {
            return yaziKategoriRepository.SilByPredicate(r => r.YaziKategoriID == id);
        }
    }
}
