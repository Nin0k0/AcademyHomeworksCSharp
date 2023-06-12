using System;
using System.Linq;

class Program
{
    static void Main()
    {

        var array = ReadArrayFromConsole();

        if (IsArrayValid(array))
        {
            Console.Write("Enter symbol to Count occurences =>  ");
            char symbol = Console.ReadKey().KeyChar;

            Console.WriteLine();
            int? count = CountChar(array: array, symbol: symbol);

            if (count == null)
            {

            }
            else
            {
                Console.WriteLine($"\n'{symbol}' is {count} times in the array.");
            }
        }
        else
        {
            Console.WriteLine("This program can not work without valid array! Bye bye ");
        }
        
        
    }

    static char[]? ReadArrayFromConsole()
    {
        Console.Write("Enter array size =>  ");


        var sizeStr = Console.ReadLine();

        if (int.TryParse(sizeStr, out _))
        {
            int size = int.Parse(sizeStr);
            char[] array = new char[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1} =>  ");
                array[i] = Console.ReadKey().KeyChar;
                Console.WriteLine();

            }
            return array;
        }
        else { 
            Console.WriteLine("Not a Valid size of array!");
            return null;
        }

        

        
    }

    static void Print(char[] array)
            {if  (array == null || array.Length == 0)
        {
            Console.WriteLine("There is no array to print out!");
        }
        else {
            foreach (char element in array)
            {
                Console.Write(element + " ");
            }
        }
        
    }

    static int? CountChar( char symbol, char[] array)
    {
        if (IsArrayValid(array))
        {
            return array.Count(element => element == symbol);
        }
        else
        {
            Console.WriteLine("Can not proccess this operation!");
            return null;
        }
        
    }



    private static  bool IsArrayValid(char[] array)
    {
        if (array == null || array.Length == 0 )
        {
            return false;
        }
        return true;
    }
}
