using System.ComponentModel.DataAnnotations;
using UnitOfWorkAndRepositoryDemo.Models.Enums;

namespace UnitOfWorkAndRepositoryDemo.Models
{
    public class Customer
    {
        [Key]
        [StringLength(11)]
        [RegularExpression("^[0-9]{11}$")]
        public string IdentityNumber { get; set; }

        [MaxLength(20)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }
}
