using System;

namespace Task3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the arrays:");
            int size = int.Parse(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];


            for (int i = 0; i < size;)
            {
                try
                {
                    Console.WriteLine($"Enter {i + 1} element of first array");
                    array1[i] = int.Parse(Console.ReadLine());
                    i++;
                }
                catch (Exception)
                {

                    Console.WriteLine("Enter Valid Integer");
                }

            }

            Console.WriteLine("Enter the elements of Array 2:");
            for (int i = 0; i < size;)
            {

                try
                {
                    Console.WriteLine($"Enter {i + 1} element of second array");
                    array2[i] = int.Parse(Console.ReadLine());
                    i++;
                }
                catch (Exception)
                {

                    Console.WriteLine("Enter Valid Integer");
                }

            }

            Console.WriteLine("Enter the sorting order (ASC or DESC):");
            string sortOrder = Console.ReadLine();

            int[] mergedArray = MergeArrays(array1, array2);
            int[] sortedArray = SortArray(mergedArray, sortOrder);

            Console.WriteLine("Sorted array:");
            foreach (int element in sortedArray)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }

        static int[] MergeArrays(int[] array1, int[] array2)
        {
            int size = array1.Length;
            int[] mergedArray = new int[size * 2];

            Array.Copy(array1, mergedArray, size);
            Array.Copy(array2, 0, mergedArray, size, size);

            return mergedArray;
        }

        static int[] SortArray(int[] array, string sortOrder)
        {
            int[] sortedArray = new int[array.Length];
            Array.Copy(array, sortedArray, array.Length);

            if (sortOrder == "ASC")
            {
                Array.Sort(sortedArray);
            }
            else if (sortOrder == "DESC")
            {
                Array.Sort(sortedArray);
                Array.Reverse(sortedArray);
            }

            return sortedArray;
        }
    }
}
