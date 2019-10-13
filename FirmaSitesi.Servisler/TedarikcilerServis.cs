using FirmaSitesi.ORM;
using FirmaSitesi.Repository;
using FirmaSitesi.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSitesi.Servisler
{
   public class TedarikcilerServis
    {

        TedarikcilerRepository tedarikcilerRepository;

        public TedarikcilerServis()
        {
            if (tedarikcilerRepository==null)
            {
                tedarikcilerRepository = new TedarikcilerRepository();
            }
        }

        public IEnumerable<TedarikcilerDTO> TedarikcilerListesi()
        {
            return tedarikcilerRepository.GetirListele().Select(r => new TedarikcilerDTO
            {

                TedarikciID = r.TedarikciID,
                TedarikciAdi = r.TedarikciAdi

            }).ToList();
        }

        public void TedarikcilerEkle(TedarikcilerDTO entity)
        {

            Tedarikci tedarikci = new Tedarikci
            {
                TedarikciAdi = entity.TedarikciAdi
            };

            tedarikcilerRepository.Ekle(tedarikci);
            tedarikcilerRepository.Context.SaveChanges();
        }

        public void TedarikciGuncelle(TedarikcilerDTO entity)
        {
            var tedarikci = tedarikcilerRepository.GetirListele().Where(x => x.TedarikciID == entity.TedarikciID).FirstOrDefault();
            tedarikci.TedarikciAdi = entity.TedarikciAdi;

            tedarikcilerRepository.Guncelle();
            tedarikcilerRepository.Context.SaveChanges();
        }
        
        public void TedarikciSil(TedarikcilerDTO entity)
        {
            var tedarikci = tedarikcilerRepository.GetirListele().Where(x => x.TedarikciID == entity.TedarikciID).FirstOrDefault();
            tedarikci.TedarikciAdi = entity.TedarikciAdi;

            tedarikcilerRepository.Sil(tedarikci);
            tedarikcilerRepository.Context.SaveChanges();
        }

        public bool TedarikciSilbyId(int id)
        {
            return tedarikcilerRepository.SilByPredicate(r => r.TedarikciID == id);
        }

    }
}
