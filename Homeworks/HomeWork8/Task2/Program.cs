using System;
using System.Linq;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            var GELlBalance = new Currency { CurrencyLabel = ECurrency.GEL, Amount = 10000 };
            var USDlBalance = new Currency { CurrencyLabel = ECurrency.USD, Amount = 2000 };
            var EURlBalance = new Currency { CurrencyLabel = ECurrency.EUR, Amount = 7000 };

            var account1 = new BankAccount("898989898989", "NINOGACH", GELlBalance);
            var account2 = new BankAccount("454545454545", "SOMEONERICH", USDlBalance);
            var account3 = new BankAccount("545454548777", "SWISSPERSON", EURlBalance);

            //Console.WriteLine(account1.BalanceCheck().Amount + ": " + account1.BalanceCheck().CurrencyLabel);
            //Console.WriteLine(account2.BalanceCheck().Amount + ": " + account2.BalanceCheck().CurrencyLabel);
            //Console.WriteLine(account3.BalanceCheck().Amount + ": " + account3.BalanceCheck().CurrencyLabel);

            //account1.Deposit(1500);
            //account2.Deposit(2000);
            //account3.Deposit(5000);

            //account1.Withdraw(1500);
            //account2.Withdraw(4200);
            //account3.Withdraw(5000);

            account1.TransferFunds(account2, 2700);
            account1.TransferFunds(account3, 3100);

            Console.WriteLine(account1.BalanceCheck().Amount + ": " + account1.BalanceCheck().CurrencyLabel);
            Console.WriteLine(account2.BalanceCheck().Amount + ": " + account2.BalanceCheck().CurrencyLabel);
            Console.WriteLine(account3.BalanceCheck().Amount + ": " + account3.BalanceCheck().CurrencyLabel);

            

        }
    }
}
