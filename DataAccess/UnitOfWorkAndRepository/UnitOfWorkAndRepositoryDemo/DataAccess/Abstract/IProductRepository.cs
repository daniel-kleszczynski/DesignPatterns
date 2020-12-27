using System.Collections.Generic;
using UnitOfWorkAndRepositoryDemo.Models;
using UnitOfWorkAndRepositoryDemo.Models.Enums;

namespace UnitOfWorkAndRepositoryDemo.DataAccess.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetProductsByCategory(ProductCategory category);
        IEnumerable<Product> GetProductsByCategory(ProductCategory category, decimal minPrice, decimal maxPrice);
    }
}