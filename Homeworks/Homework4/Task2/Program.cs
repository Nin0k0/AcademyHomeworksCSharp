using System;
using System.ComponentModel;


namespace Task2
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
                var strings = new string[arraySize];
                var ints = new int[arraySize];
                for (int i = 0; i < 2;)
                {
                    if (i == 0)
                    {
                        strings = CreateArray<String>(arraySize);
                        i++;
                    }
                    else
                    {
                        ints = CreateArray<int>(arraySize);
                        i++;
                    }
                }

                var resultArray = new string[arraySize];
                for (int i = 0; i < arraySize; i++)
                {
                    resultArray[i] = $"{strings[i]} {ints[i]}";

                }

                Console.WriteLine(string.Join(" ", resultArray));




            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Array Size not Valid!");
            }
        }

        static T[] CreateArray<T>(int length)
        {
            var resultArray = new T[length];
            var type = typeof(T);
            var converter = TypeDescriptor.GetConverter(typeof(T));
            for (int i = 0; i < length;)
            {
                Console.WriteLine($"Enter {type} Element # {i + 1}");

                var element = Console.ReadLine();

                var converted = (T)converter.ConvertFromString(element);

                resultArray[i] = converted;
                i++;

            }

            return resultArray;
        }



    }
}