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
  public  class TumGaleriServis
    {
        TumGaleriRepository TumGaleriRepository;

        public TumGaleriServis()
        {
            if (TumGaleriRepository==null)
            {
                TumGaleriRepository = new TumGaleriRepository();
            }
        }

        public IEnumerable<TumGaleriDTO> TumGaleriListele()
        {
            return TumGaleriRepository.GetirListele().Select(r => new TumGaleriDTO
            {
                GaleriID=r.GaleriID,
                GaleriKategoriAdi=r.GaleriKategoriAdi,
                GaleriAdi=r.GaleriAdi,
                GaleriLogo=r.GaleriLogo,
                BuyukResim1=r.BuyukResim1,
                BuyukResim2=r.BuyukResim2,
                BuyukResim3=r.BuyukResim3,
                BuyukResim4=r.BuyukResim4
            }).ToList();
        }

        // View olduğu için sadece çekme listeleme işlemi yaptım.

    }
}
