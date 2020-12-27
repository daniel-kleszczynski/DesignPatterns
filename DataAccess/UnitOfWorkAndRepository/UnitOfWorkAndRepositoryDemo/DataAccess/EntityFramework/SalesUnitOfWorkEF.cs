using UnitOfWorkAndRepositoryDemo.DataAccess.Abstract;
using UnitOfWorkAndRepositoryDemo.DataAccess.EntityFramework.Repositories;
using UnitOfWorkAndRepositoryDemo.DataAccess.EntityFramework.Setup;

namespace UnitOfWorkAndRepositoryDemo.DataAccess.EntityFramework
{
    public class SalesUnitOfWorkEF : ISalesUnitOfWork
    {
        private CompanyDbContext _dbContext;
        public SalesUnitOfWorkEF()
        {
            _dbContext = new CompanyDbContext();
            Products = new ProductRepository(_dbContext);
            Customers = new CustomerRepository(_dbContext);
            Transactions = new TransactionRepository(_dbContext);
        }

        public IProductRepository Products { get; }
        public ICustomerRepository Customers { get; }
        public ITransactionRepository Transactions { get; }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
