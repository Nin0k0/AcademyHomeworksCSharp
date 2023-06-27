using System;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Triangle Sides");
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());

            var triangle = new Triangle(sideA, sideB, sideC);
            var justForTestTriangle = new Triangle(4,5,6);
            Console.WriteLine(triangle.Equals(justForTestTriangle));
            Console.WriteLine(triangle==justForTestTriangle);
            Console.WriteLine(triangle.Area());
        }
    }
}
