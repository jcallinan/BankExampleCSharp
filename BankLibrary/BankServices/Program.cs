using BankLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankServices
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Account.GenerateTestAccounts();
                //argument sent
                switch (args[0])
                {
                    case "test":
                        Console.WriteLine("Testing selected.");
                        foreach (var account in Account.Accounts)
                        {

                            Console.WriteLine(account);
                        }
                        break;
                    case "apply-interest":
                        Console.WriteLine("Applying Interest selected.");
                        InterestService interestService = new InterestService();
                        interestService.ApplyInterestToAccounts(Account.Accounts);
                        break;
                    default:
                        break;

                }
            }
            else
            {
                Console.WriteLine("No arguments sent");
            }
        }
    }
}
