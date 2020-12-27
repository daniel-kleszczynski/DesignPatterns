using System;
using System.Collections.Generic;

namespace UnitOfWorkAndRepositoryDemo.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public Customer Customer { get; set; }
        public virtual List<TransactionLine> Lines { get; set; } = new List<TransactionLine>();
    }
}
