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


    public class EBultenServis
    {
        EBultenRepository ebultenRepository;
        public EBultenServis()
        {
            if (ebultenRepository==null)
            {
                ebultenRepository = new EBultenRepository();
            }
        }

       public IEnumerable<EBultenDTO> EbultenListesi()
        {
            return ebultenRepository.GetirListele().Select(x => new EBultenDTO
            {

                EBultenID= x.EBultenID,
                EmailAdresi=x.EmailAdresi

            }).ToList();
        }

        public void EbultenEkle(EBultenDTO entity)
        {
            EBulten eBulten = new EBulten
            {
                EmailAdresi=entity.EmailAdresi

            };
            ebultenRepository.Ekle(eBulten);
        }
        public void EbultenGuncelle(EBultenDTO entity)
        {
           
            var eBulten = ebultenRepository.GetirListele().Where(r => r.EBultenID == entity.EBultenID).FirstOrDefault();
            eBulten.EmailAdresi = entity.EmailAdresi;
            ebultenRepository.Guncelle();
            ebultenRepository.Context.SaveChanges();


        }
        public void EbultenSil(EBultenDTO entity)
        {
            var Ebulten = ebultenRepository.GetirListele().Where(r => r.EBultenID == entity.EBultenID).FirstOrDefault();
            Ebulten.EBultenID = entity.EBultenID;
            Ebulten.EmailAdresi = entity.EmailAdresi;
            ebultenRepository.Sil(Ebulten);
        }

    }
}
