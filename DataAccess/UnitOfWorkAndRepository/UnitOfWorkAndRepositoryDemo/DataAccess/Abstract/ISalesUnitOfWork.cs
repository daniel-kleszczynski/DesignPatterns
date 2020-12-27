namespace UnitOfWorkAndRepositoryDemo.DataAccess.Abstract
{
    public interface ISalesUnitOfWork : IUnitOfWork
    {
        ICustomerRepository Customers { get; }
        IProductRepository Products { get; }
        ITransactionRepository Transactions { get; }
    }
}
