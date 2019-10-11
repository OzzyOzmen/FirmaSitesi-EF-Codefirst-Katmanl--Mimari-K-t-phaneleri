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
    public class UrunlerServis
    {

        UrunlerRepository urunlerRepository;

        public UrunlerServis()
        {
            if (urunlerRepository == null)
            {
                urunlerRepository = new UrunlerRepository();
            }
        }

        public IEnumerable<UrunlerDTO> UrunleriListele()
        {

            return urunlerRepository.GetirListele().Select(x => new UrunlerDTO
            {

                UrunID = x.UrunID,
                UrunKategoriID = x.UrunKategoriID,
                UrunAdi = x.UrunAdi,
                UrunFiyati = x.UrunFiyati,
                UrunStokAdeti = x.UrunStokAdeti,
                TedarikciID = x.TedarikciID

            }).ToList();
        }

        public void UrunlerEkle(UrunlerDTO entity)
        {
            Urun urun = new Urun
            {
                UrunKategoriID = entity.UrunKategoriID,
                UrunAdi = entity.UrunAdi,
                UrunFiyati = entity.UrunFiyati,
                UrunStokAdeti = entity.UrunStokAdeti,
                TedarikciID = entity.TedarikciID

            };

            urunlerRepository.Ekle(urun);
            urunlerRepository.Context.SaveChanges();

        }

        public void UrunGuncelle(UrunlerDTO entity)
        {
            var urun = urunlerRepository.GetirListele().Where(r => r.UrunID == entity.UrunID).FirstOrDefault();
            urun.UrunKategoriID = entity.UrunKategoriID;
            urun.UrunAdi = entity.UrunAdi;
            urun.UrunFiyati = entity.UrunFiyati;
            urun.UrunStokAdeti = entity.UrunStokAdeti;
            urun.TedarikciID = entity.TedarikciID;
            urunlerRepository.Guncelle();
            urunlerRepository.Context.SaveChanges();
        }

        public void UrunSil(UrunlerDTO entity)
        {
            var urun = urunlerRepository.GetirListele().Where(r => r.UrunID == entity.UrunID).FirstOrDefault();
            urun.UrunKategoriID = entity.UrunKategoriID;
            urun.UrunAdi = entity.UrunAdi;
            urun.UrunFiyati = entity.UrunFiyati;
            urun.UrunStokAdeti = entity.UrunStokAdeti;
            urun.TedarikciID = entity.TedarikciID;
            urunlerRepository.Sil(urun);
            urunlerRepository.Context.SaveChanges();
        }

    }
}
