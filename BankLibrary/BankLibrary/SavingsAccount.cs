using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class SavingsAccount : Account
    {
        public decimal InterestRate { get; private set; }
        public SavingsAccount(string accountNumber, string accountName, decimal initialBalance, decimal interestRate) :
            base(accountNumber,accountName,initialBalance)
        {
            InterestRate = interestRate;
        }
        public void ApplyInterest()
        {
            decimal interestPayment = Balance * InterestRate;
            this.Deposit(interestPayment);
        }
    }
}
