using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace WebDemo.Data.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string ExternalTransactionId { get; set; }
        public decimal Amount { get; set; }
        public decimal Fee { get; set; }
        public string Result { get; set; }
        public string Message { get; set; }
        public TransactionStatus Status { get; set; }
        public string Provider { get; set; }
        //Relationship
        public AppUser AppUser { get; set; }
    }
}
