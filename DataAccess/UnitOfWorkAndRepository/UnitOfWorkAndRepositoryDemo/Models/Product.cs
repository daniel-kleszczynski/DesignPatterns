using System.ComponentModel.DataAnnotations;
using UnitOfWorkAndRepositoryDemo.Models.Enums;

namespace UnitOfWorkAndRepositoryDemo.Models
{
    public class Product
    {
        [Key, StringLength(5)]
        public string ProductCode { get; set; }
        [MaxLength(60)]
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public ProductCategory Category { get; set; }
    }
}
