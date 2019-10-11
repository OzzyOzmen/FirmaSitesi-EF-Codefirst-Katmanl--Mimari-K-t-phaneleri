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
    public class TumUrunlerServis
    {
        TumUrunlerRepository tumUrunlerRepository;

        public TumUrunlerServis()
        {
            if (tumUrunlerRepository==null)
            {
                tumUrunlerRepository = new TumUrunlerRepository();
            }
        }

      public IEnumerable<TumUrunlerDTO> TumUrunlerListele()
        {
            return tumUrunlerRepository.GetirListele().Select(r => new TumUrunlerDTO
            {
                UrunID=r.UrunID,
                UrunKategoriAdi=r.UrunKategoriAdi,
                UrunAdi=r.UrunAdi,
                UrunFiyati=r.UrunFiyati,
                UrunStokAdeti=r.UrunStokAdeti,
                TedarikciAdi=r.TedarikciAdi

            }).ToList();

        }


        // View olduğu için sadece çekme listeleme işlemi yaptım.
    }
}
