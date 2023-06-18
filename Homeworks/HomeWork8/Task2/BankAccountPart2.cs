using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    partial class BankAccount
    {

        public void TransferFunds(BankAccount target, Decimal amount)
        {
            Withdraw(amount,out bool canBeWithdrawned);
            if (canBeWithdrawned)
            {
                var amountForTarget = CurrencyConverter.ConvertedCurrencyAmount(this.Balance,target.Balance,amount);
                target.Deposit(amountForTarget);
            }
            else
            {
                Console.WriteLine($"Not Abled to transfer this amount of money! You can Only Transfer Max {this.Balance.Amount}");
            }
            
        }
    }
}
