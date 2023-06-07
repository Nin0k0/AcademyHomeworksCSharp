using System;
using System.Collections.Generic;

namespace Task2
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
                var divisors = GetDivisors(numberInt);

                Console.WriteLine("The divisors of the number are: " + string.Join(", ", divisors));
            }
            else { Console.WriteLine("Not a valid Number"); }
        }

        static List<int> GetDivisors(int number)
        {
            var divisors = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                }
            }

            return divisors;
        }
    }
}
