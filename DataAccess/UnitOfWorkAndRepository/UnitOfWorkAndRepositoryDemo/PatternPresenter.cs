using System;
using System.Collections.Generic;
using UnitOfWorkAndRepositoryDemo.DataAccess.Abstract;
using UnitOfWorkAndRepositoryDemo.DataAccess.EntityFramework;
using UnitOfWorkAndRepositoryDemo.Models;
using UnitOfWorkAndRepositoryDemo.Models.Enums;

namespace UnitOfWorkAndRepositoryDemo
{
    public class PatternPresenter
    {
        public void AlterCustomersDemo()
        {
            using (ISalesUnitOfWork unitOfWork = new SalesUnitOfWorkEF())
            {
                const string CustomerIdentity = "93061151423";
                var cusomerToDelete = unitOfWork.Customers.GetByIdentityNumber(CustomerIdentity);
                var newCustomer = new Customer { FirstName = "Merry", LastName = "Jane", Age = 27, Gender = Gender.Female, IdentityNumber = CustomerIdentity };

                if (cusomerToDelete != null)
                    unitOfWork.Customers.Remove(cusomerToDelete);
                else
                    unitOfWork.Customers.Add(newCustomer);

                var customerToModify = unitOfWork.Customers.GetByIdentityNumber("92112444243");
                customerToModify.FirstName = "Natalia";

                unitOfWork.Commit();
            }
        }

        public void ReadFromDatabaseDemo()
        {
            using (ISalesUnitOfWork unitOfWork = new SalesUnitOfWorkEF())
            {
                var elderMales = unitOfWork.Customers.GetElderly(Gender.Male);
                var youngAdultFemales = unitOfWork.Customers.GetYoungAdults(Gender.Female);
                var allAdults = unitOfWork.Customers.GetAdults(Gender.Female | Gender.Male | Gender.Undefined);

                var allProducts = unitOfWork.Products.GetAll();
                var gpuList = unitOfWork.Products.GetProductsByCategory(ProductCategory.GPU);

                const string customerIdentityNumber = "92112444243";
                var customer = unitOfWork.Customers.GetByIdentityNumber(customerIdentityNumber);
                var customerTransactions = unitOfWork.Transactions.GetTransactionsByCustomer(customer);
                PresentTransactions(customerTransactions);

                Console.WriteLine("\n******************************\n");

                var productTransactions = unitOfWork.Transactions.GetTransactionLinessByProduct("C0001");
                PresentTransactionLines(productTransactions);

                Console.ReadKey();
            }
        }

        private void PresentTransactions(IEnumerable<Transaction> transactions)
        {
            foreach (var transaction in transactions)
            {
                var timeInfo = $"{transaction.DateTime.ToString("dd.MM.yyyy")}";
                var customerInfo = $"{transaction.Customer.FirstName} {transaction.Customer.LastName}";

                Console.WriteLine($"Transaction: {transaction.Id} at {timeInfo}, customer: {customerInfo}");

                PresentTransactionLines(transaction.Lines);
            }
        }

        private void PresentTransactionLines(IEnumerable<TransactionLine> transactionLines)
        {
            foreach (var line in transactionLines)
                Console.WriteLine($"transactionId: {line.TransactionId}, lineNum: {line.LineNum}." +
                    $" {line.Product.Name}, quantity: {line.Quantity}");
        }
    }
}
