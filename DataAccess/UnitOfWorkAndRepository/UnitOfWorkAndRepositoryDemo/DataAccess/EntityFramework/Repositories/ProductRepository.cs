using System.Collections.Generic;
using System.Linq;
using UnitOfWorkAndRepositoryDemo.DataAccess.Abstract;
using UnitOfWorkAndRepositoryDemo.DataAccess.EntityFramework.Setup;
using UnitOfWorkAndRepositoryDemo.Models;
using UnitOfWorkAndRepositoryDemo.Models.Enums;

namespace UnitOfWorkAndRepositoryDemo.DataAccess.EntityFramework.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(CompanyDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Product> GetProductsByCategory(ProductCategory category)
        {
            return DbContext.Products.Where(p => p.Category == category).ToList();
        }

        public IEnumerable<Product> GetProductsByCategory(ProductCategory category, decimal minPrice, decimal maxPrice)
        {
            return DbContext.Products
                .Where(p => p.Category == category && p.UnitPrice >= minPrice && p.UnitPrice <= maxPrice)
                .ToList();
        }
    }
}
