using System;

namespace UnitOfWorkAndRepositoryDemo.DataAccess.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
