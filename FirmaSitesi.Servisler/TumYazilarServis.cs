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
    public class TumYazilarServis
    {
        TumYazilarRepository tumYazilarRepository;

        public TumYazilarServis()
        {
            if (tumYazilarRepository==null)
            {
                tumYazilarRepository = new TumYazilarRepository();
            }
        }

        public IEnumerable<TumYazilarDTO> TumYazilarListel()
        {
            return tumYazilarRepository.GetirListele().Select(x => new TumYazilarDTO
            {
                YazilarID=x.YazilarID,
                YaziKategoriAdi=x.YaziKategoriAdi,
                YazilarBaslik=x.YazilarBaslik,
                YazilarIcerik=x.YazilarIcerik,
                KucukResim=x.KucukResim,
                BuyukResim1=x.BuyukResim1,
                BuyukResim2=x.BuyukResim2,
                BuyukResim3=x.BuyukResim3,
                BuyukResim4=x.BuyukResim4


            }).ToList();

        }

        // View olduğu için sadece çekme listeleme işlemi yaptım.
    }
}
