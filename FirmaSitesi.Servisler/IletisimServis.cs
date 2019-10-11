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
    public class IletisimServis
    {
        IletisimRepository iletisimRepository;

        public IletisimServis()
        {
            if (iletisimRepository==null)
            {
                iletisimRepository = new IletisimRepository();
            }
        }

        public IEnumerable<IletisimDTO> IletisimListele()
        {
            return iletisimRepository.GetirListele().Select(x => new IletisimDTO
            {

                IletisimID=x.IletisimID,
                Gonderen=x.Gonderen,
                GonderiTarih=x.GonderiTarih,
                IletisimMesaj=x.IletisimMesaj,
                Okundu=x.Okundu

            }).ToList();
        }

        public void IletisimEkle(IletisimDTO entity)
        {
            Iletisim iletisim = new Iletisim
            {
                Gonderen=entity.Gonderen,
                GonderiTarih=entity.GonderiTarih,
                IletisimMesaj=entity.IletisimMesaj,
                Okundu=entity.Okundu

            };

            iletisimRepository.Ekle(iletisim);
        }

        public void IletisimGuncelle(IletisimDTO entity)
        {
            var iletisim = iletisimRepository.GetirListele().Where(r=>r.IletisimID==entity.IletisimID).ToList().FirstOrDefault();
            iletisim.Gonderen = entity.Gonderen;
            iletisim.GonderiTarih = entity.GonderiTarih;
            iletisim.IletisimMesaj = entity.IletisimMesaj;
            iletisim.Okundu = entity.Okundu;

            iletisimRepository.Guncelle();
            iletisimRepository.Context.SaveChanges();
        }

        public void IletisimSil(IletisimDTO entity)
        {
            var iletisim = iletisimRepository.GetirListele().Where(r => r.IletisimID == entity.IletisimID).ToList().FirstOrDefault();
            iletisim.Gonderen = entity.Gonderen;
            iletisim.GonderiTarih = entity.GonderiTarih;
            iletisim.IletisimMesaj = entity.IletisimMesaj;
            iletisim.Okundu = entity.Okundu;

            iletisimRepository.Sil(iletisim);
        }
    }
}
