using System;
using System.Linq;

namespace Task4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());

            var array = new int[size];
            for (int i = 0; i < size;)
            {
                try
                {
                    Console.WriteLine($"Enter {i + 1} element of array");
                    array[i] = int.Parse(Console.ReadLine());
                    i++;
                }
                catch (Exception)
                {

                    Console.WriteLine("Enter Valid Integer");
                }
            }


            int[] sortedArray = array.OrderBy(x => x).ToArray();
            int maxDifference = sortedArray.Zip(sortedArray.Skip(1), (a, b) => b - a).Max();

            Console.WriteLine("Max Difference Between numbers is "+ maxDifference);
        }
    }
}
