using System.Data.Entity;
using UnitOfWorkAndRepositoryDemo.Models;

namespace UnitOfWorkAndRepositoryDemo.DataAccess.EntityFramework.Setup
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base("CompanyDbContext")
        {
            Database.SetInitializer(new CompanyDbInitializer());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
