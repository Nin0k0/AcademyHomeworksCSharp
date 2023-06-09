using System;

namespace PreviusHomeworkTask3
{
    using System;

    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter  N: ");
            int n = GetValidIntegerInput();

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter number #{i + 1}: ");
                numbers[i] = GetValidIntegerInput();
            }

            int positiveCount = 0;
            int positiveSum = 0;
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    positiveCount++;
                    positiveSum += number;
                }
            }

            double positiveAverage = positiveCount > 0 ? (double)positiveSum / positiveCount : 0;

            Console.WriteLine($"Positive numbers Average: {positiveAverage}");
            Console.WriteLine($"Positive numbers Sum: {positiveSum}");
        }

        static int GetValidIntegerInput()
        {
            int value = 0;
            bool isValid = false;
            while (!isValid)
            {
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");

                }
            }
            return value;
        }
    }

}