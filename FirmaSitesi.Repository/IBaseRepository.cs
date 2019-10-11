using System;
using System.Collections.Generic;

namespace FirmaSitesi.Repository
{
    public interface IBaseRepository<T> where T : class
    {

        IEnumerable<T> GetirListele();
        IEnumerable<T> GetirListeleByPredicate(Func<T, bool> entity);
        T Ekle(T entity);
        int Guncelle();
        T Sil(T entity);
        bool SilByPredicate(Func<T, bool> entity);


    }
}