using System;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {


            Console.WriteLine("Write a size of an Array:");

            var strSize = Console.ReadLine();

            if (int.TryParse(strSize, out _))
            {

                var arraySize = int.Parse(strSize);
                var intArray = new int[arraySize];
                for (int i = 0; i < arraySize;)
                {
                    Console.WriteLine($"Write {i + 1} element: ");
                    var element = Console.ReadLine();

                    if (int.TryParse(element, out _))
                    {
                        intArray[i] = int.Parse(element);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid Integer! ");
                    }
                }

                Console.WriteLine("Here is your sorted Array: " + string.Join(", ", SortedArray(intArray)));
            }
            else
            {
                Console.WriteLine("Array Size not Valid!");
            }
        }




        private static int[] SortedArray(int[] intArr)
        {
            while (true)
            {
                bool swapped = false;
                for (var i = 1; i < intArr.Length; i++)
                {

                    if (intArr[i] < intArr[i - 1])
                    {
                        intArr[i] = intArr[i] * intArr[i - 1];
                        intArr[i - 1] = intArr[i] / intArr[i - 1];
                        intArr[i] = intArr[i] / intArr[i - 1];
                        swapped = true;
                    }

                }
                if (!swapped)
                {
                    return intArr;

                }
            }
        }
    }
}