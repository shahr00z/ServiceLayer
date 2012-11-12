using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Data;

namespace ServiceLayer.ServiceDbSet
{
    public class ServiceContext<T> : IServiceDbSet<T> where T : class
    {
        private readonly IDbSet<T> _dbSet;

        public  ServiceContext(IUnitOfWork iUnitOfWork)
        {
            _dbSet = iUnitOfWork.Set<T>();
        }

        #region IContext<T> Members

        public bool TryGet(Func<T, bool> predicate, out T entity)
        {
            entity = List(predicate).SingleOrDefault();
            return entity != null;
        }

        public T Get(Func<T, bool> predicate)
        {
            return List(predicate).Single();
        }

        public virtual List<T> List(Func<T, bool> predicate = null)
        {
            IEnumerable<T> result = _dbSet.AsEnumerable();
            if (predicate != null)
                result = result.Where(predicate);
            return result.ToList();
        }

        public T Add(T t)
        {
            _dbSet.Add(t);
            return t;
        }

        public void Delete(Func<T, bool> predicate)
        {
            List(predicate).ToList().ForEach(p => _dbSet.Remove(p));
        }

        public void Delete(T t)
        {
            _dbSet.Remove(t);
        }

        #endregion
    }
}