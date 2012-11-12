using System;
using System.Collections.Generic;

namespace ServiceLayer.ServiceDbSet
{
    public interface IServiceDbSet<T>
    {
        bool TryGet(Func<T, bool> predicate, out T entity);
        T Get(Func<T, bool>predicate );
        List<T> List(Func<T, bool>predicate = null);
        T Add(T t);
        void Delete(Func<T, bool> predicate);
        void Delete(T entity);
    }
}