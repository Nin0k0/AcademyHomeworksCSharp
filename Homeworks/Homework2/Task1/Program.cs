using System;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            var number = Console.ReadLine();
            if (int.TryParse(number, out _))
            {
                var numberInt = int.Parse(number);
                if (IsPrime(numberInt))
                {
                    Console.WriteLine("Prime Number.");
                }
                else
                {
                    Console.WriteLine("Not a Prime Number");
                }
            }
            else { Console.WriteLine("Not a Valid Integer"); }

        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
