using System;
using System.Collections.Generic;
using System.Linq;
using UnitOfWorkAndRepositoryDemo.DataAccess.Abstract;
using UnitOfWorkAndRepositoryDemo.DataAccess.EntityFramework.Setup;

namespace UnitOfWorkAndRepositoryDemo.DataAccess.EntityFramework.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly CompanyDbContext DbContext;

        public Repository(CompanyDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public void Add(T entity)
        {
            DbContext.Set<T>().Add(entity);
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return DbContext.Set<T>().Where(predicate).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            return DbContext.Set<T>().ToList();
        }

        public void Remove(T entity)
        {
            DbContext.Set<T>().Remove(entity);
        }
    }
}
