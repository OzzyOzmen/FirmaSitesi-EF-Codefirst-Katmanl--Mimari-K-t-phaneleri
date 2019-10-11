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
    public class TumReferanslarServis
    {
        TumReferanslarRepository tumReferanslarRepository;

        public TumReferanslarServis()
        {
            if (tumReferanslarRepository==null)
            {
                tumReferanslarRepository = new TumReferanslarRepository();
            }
        }

        public IEnumerable<TumReferanslarDTO> TumRferanslarListele()
        {
            return tumReferanslarRepository.GetirListele().Select(x => new TumReferanslarDTO
            {
                ReferansID=x.ReferansID,
                ReferansKategoriAdi=x.ReferansKategoriAdi,
                ReferansAdi=x.ReferansAdi,
                ReferansAciklama=x.ReferansAciklama,
                ReferansLogo=x.ReferansLogo

            }).ToList();
        }



        // View olduğu için sadece çekme listeleme işlemi yaptım.
    }
}
