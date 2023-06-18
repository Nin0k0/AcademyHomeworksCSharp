using System;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {           
            Console.WriteLine(MyMath.Pow(5,2));
            Console.WriteLine(MyMath.Divide(84.4,2));
            Console.WriteLine(MyMath.Sqrt(24));
            Console.WriteLine(MyMath.Sqrt(1));
            Console.WriteLine(MyMath.Sqrt(2));
            Console.WriteLine(MyMath.Sqrt(3));
            Console.WriteLine(MyMath.Sqrt(1000));

            Console.WriteLine(MyMath.Substract(-50.69,54));

            Console.WriteLine(MyMath.Divide(84.4, 0));

        }
    }
}
