using System;
using System.Collections.Generic;
using UnitOfWorkAndRepositoryDemo.Models;

namespace UnitOfWorkAndRepositoryDemo.DataAccess.Abstract
{
    public interface ITransactionRepository : IRepository<Transaction>
    {
        IEnumerable<TransactionLine> GetTransactionLinessByProduct(string productCode);
        IEnumerable<TransactionLine> GetTransactionLinessByProduct(string productCode, DateTime dateFrom, DateTime dateTo);
        IEnumerable<Transaction> GetTransactionsByCustomer(Customer customer);
        IEnumerable<Transaction> GetTransactionsByCustomer(Customer customer, DateTime dateTimeFrom, DateTime dateTimeTo);
        IEnumerable<Transaction> GetTransactionsByProduct(string productCode);
        IEnumerable<Transaction> GetTransactionsByProduct(string productCode, DateTime dateFrom, DateTime dateTo);
    }
}