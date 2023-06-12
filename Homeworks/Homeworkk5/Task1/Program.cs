using System;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(CalculateDigitSum(3, 4, 7, 9, 1245453));
        }



        private static int? CalculateDigitSum(int index, params int[] array)
        {

            if (index < 0 || array.Length < index + 1)
            {
                Console.WriteLine("Not a Valid Index!");
                return null;
            }
            else
            {

                var element = array[index];
                int sum = 0;
                while (element != 0)
                {
                    int digit = element % 10;
                    sum += digit;
                    element /= 10;
                }
                return sum;

            }
        }
    }

}
