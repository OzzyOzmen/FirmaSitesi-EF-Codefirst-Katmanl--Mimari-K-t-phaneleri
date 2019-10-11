using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmaSitesi.ORM;

namespace FirmaSitesi.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        
        private FirmaDateBase context;

        public FirmaDateBase Context
        {
            get
            {

                if (context == null)
                {
                    context = new FirmaDateBase();
                }

                return context;

            }
            set { context = value; }
        }

        public IEnumerable<T> GetirListele()
        {
            return Context.Set<T>().ToList();
        }

        public IEnumerable<T> GetirListeleByPredicate(Func<T, bool> entity)
        {
            return Context.Set<T>().Where(entity);
        }

        public T Ekle(T entity)
        {
            return Context.Set<T>().Add(entity);
        }

        public int Guncelle()
        {
            return Context.SaveChanges();
        }

        public T Sil(T entity)
        {
            return  Context.Set<T>().Remove(entity);
           
        }

        public bool SilByPredicate(Func<T, bool> entity)
        {
            var veri = GetirListeleByPredicate(entity);
            if (veri.Count() == 0)
                return false;
            foreach (var item in veri)
            {
                Context.Set<T>().Remove(item);
            }
            Context.SaveChanges();
            return true;
        }

        //private bool disposed = false;
        //public virtual void Dispose(bool disponsing)
        //{
        //    if (!disposed)
        //    {
        //        if (disponsing)
        //        {
        //            Context.Dispose();
        //        }
        //    }
        //    disposed = true;
        //}
        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}


    }
}
