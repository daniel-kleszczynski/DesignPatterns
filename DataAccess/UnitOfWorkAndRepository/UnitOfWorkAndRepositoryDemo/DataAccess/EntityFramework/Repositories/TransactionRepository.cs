using System;
using System.Collections.Generic;
using System.Linq;
using UnitOfWorkAndRepositoryDemo.DataAccess.Abstract;
using UnitOfWorkAndRepositoryDemo.DataAccess.EntityFramework.Setup;
using UnitOfWorkAndRepositoryDemo.Models;

namespace UnitOfWorkAndRepositoryDemo.DataAccess.EntityFramework.Repositories
{
    public class TransactionRepository : Repository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(CompanyDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Transaction> GetTransactionsByProduct(string productCode)
        {
            return DbContext.Transactions
                .Where(t => t.Lines.FirstOrDefault(l => l.Product.ProductCode == productCode) != null)
                .ToList();
        }

        public IEnumerable<Transaction> GetTransactionsByProduct(string productCode, DateTime dateFrom, DateTime dateTo)
        {
            return DbContext.Transactions
                .Where(t =>
                    t.DateTime.Date >= dateFrom.Date &&
                    t.DateTime.Date <= dateTo.Date &&
                    t.Lines.FirstOrDefault(l => l.Product.ProductCode == productCode) != null)
                .ToList();
        }

        public IEnumerable<TransactionLine> GetTransactionLinessByProduct(string productCode)
        {
            return DbContext.Transactions
                .SelectMany(t => t.Lines.Where(l => l.Product.ProductCode == productCode))
                .ToList();
        }

        public IEnumerable<TransactionLine> GetTransactionLinessByProduct(string productCode, DateTime dateFrom, DateTime dateTo)
        {
            return DbContext.Transactions
                .Where(t => t.DateTime.Date >= dateFrom.Date && t.DateTime.Date <= dateTo.Date)
                .SelectMany(t => t.Lines.Where(l => l.Product.ProductCode == productCode))
                .ToList();
        }

        public IEnumerable<Transaction> GetTransactionsByCustomer(Customer customer)
        {
            return DbContext.Transactions
                .Where(t => t.Customer.IdentityNumber == customer.IdentityNumber)
                .ToList();
        }

        public IEnumerable<Transaction> GetTransactionsByCustomer(Customer customer, DateTime dateFrom, DateTime dateTo)
        {
            return DbContext.Transactions
                .Where(t =>
                    t.Customer.IdentityNumber == customer.IdentityNumber &&
                    t.DateTime >= dateFrom &&
                    t.DateTime <= dateTo)
                .ToList();
        }
    }
}
