using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnitOfWorkAndRepositoryDemo.Models
{
    public class TransactionLine
    {
        [Key, Column("Transaction_Id", Order = 0)]
        public int TransactionId { get; set; }
        [Key, Column(Order = 1)]
        public int LineNum { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
