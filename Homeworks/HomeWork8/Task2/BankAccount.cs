using System;

namespace Task2
{
    partial class BankAccount
    {
        private readonly string AccountNumber;
        private readonly string AccountHolderName;
        private Currency Balance;

        public BankAccount(string accountNumber, string accountHolderName, Currency balance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = balance;
        }

        public void Deposit(Decimal balance)
        {
            //To Avoid Overflow Expetion
            if(balance > 0)
            {
                try
                {
                    Balance.Amount += balance;
                }
                catch (Exception)
                {

                    Console.WriteLine("Impossible to Deposit this amount!");
                }
            }
            
            
        }

        public void Withdraw(Decimal balance, out bool canBeWithDrawned)
        {   if(balance > 0) {

                if (Balance.Amount >= balance)
                {
                    Balance.Amount -= balance;
                    canBeWithDrawned = true;
                }
                else
                {
                    Console.WriteLine($"Not Enogh money! You can windrow maximum {Balance.Amount}");
                    canBeWithDrawned = false;
                }
            }
            else
            {
                canBeWithDrawned=false;
            }
            
        }

        public Currency BalanceCheck()
        {
            return Balance;
        }

    }
}
