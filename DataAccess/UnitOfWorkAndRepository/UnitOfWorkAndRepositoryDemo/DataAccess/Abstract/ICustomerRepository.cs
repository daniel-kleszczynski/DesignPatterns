using System.Collections.Generic;
using UnitOfWorkAndRepositoryDemo.Models;
using UnitOfWorkAndRepositoryDemo.Models.Enums;

namespace UnitOfWorkAndRepositoryDemo.DataAccess.Abstract
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer GetByIdentityNumber(string identityNumber);
        IEnumerable<Customer> GetAdults(Gender gender);
        IEnumerable<Customer> GetElderly(Gender gender);
        IEnumerable<Customer> GetUnderAge(Gender gender);
        IEnumerable<Customer> GetYoungAdults(Gender gender);
    }
}
