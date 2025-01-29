using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class Transaction
    {
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal BalanceAfterTransaction {  get; set; }
        public string AccountNumber { get; set; }
        public string AccountOwnerAtTime { get; set; }

    }
}
