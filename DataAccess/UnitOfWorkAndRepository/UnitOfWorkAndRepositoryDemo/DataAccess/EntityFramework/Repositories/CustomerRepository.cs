using System.Collections.Generic;
using System.Linq;
using UnitOfWorkAndRepositoryDemo.DataAccess.Abstract;
using UnitOfWorkAndRepositoryDemo.DataAccess.EntityFramework.Setup;
using UnitOfWorkAndRepositoryDemo.Models;
using UnitOfWorkAndRepositoryDemo.Models.Enums;

namespace UnitOfWorkAndRepositoryDemo.DataAccess.EntityFramework.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CompanyDbContext dbContext) : base(dbContext)
        {
        }
        public IEnumerable<Customer> GetUnderAge(Gender gender)
        {
            const int YoungAdultAge = 18;

            return DbContext.Customers
                .Where(c => c.Age < YoungAdultAge && (c.Gender & gender) != 0)
                .ToList();
        }

        public IEnumerable<Customer> GetYoungAdults(Gender gender)
        {
            const int YoungAdultAge = 18;
            const int AdultAge = 30;

            return DbContext.Customers
                .Where(c =>
                    c.Age >= YoungAdultAge &&
                    c.Age < AdultAge &&
                    (c.Gender & gender) != 0)
                .ToList();
        }

        public IEnumerable<Customer> GetAdults(Gender gender)
        {
            const int AdultAge = 30;
            const int ElderAge = 60;

            return DbContext.Customers
                .Where(c =>
                    c.Age >= AdultAge &&
                    c.Age < ElderAge &&
                    (c.Gender & gender) != 0)
                .ToList();
        }

        public IEnumerable<Customer> GetElderly(Gender gender)
        {
            const int ElderAge = 60;
            return DbContext.Customers.Where(c => c.Age >= ElderAge && (c.Gender & gender) != 0).ToList();
        }

        public Customer GetByIdentityNumber(string identityNumber)
        {
            return DbContext.Customers.SingleOrDefault(c => c.IdentityNumber == identityNumber);
        }
    }
}
