using System;
using System.Collections.Generic;

namespace UnitOfWorkAndRepositoryDemo.DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Remove(T entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Func<T, bool> predicate);
    }
}
