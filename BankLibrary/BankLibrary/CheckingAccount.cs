using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class CheckingAccount : Account
    {
        public decimal OverdraftLimit { get; private set; }
        public CheckingAccount(string accountNumber,string accountName, decimal initialBalance, decimal overDraftLimit) :
            base(accountNumber,accountName,initialBalance)
        {
            OverdraftLimit = overDraftLimit;
        }
        public override void Withdraw(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Withdrawl amount must be positive");
            if (amount > Balance + OverdraftLimit) throw new InvalidOperationException("Overdraft limit exceeded");
            this.Withdraw(amount);
        }

    }
}
