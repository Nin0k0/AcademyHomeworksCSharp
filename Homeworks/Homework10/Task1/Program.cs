using System;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            var firstMatrix = Matrix.CreateFromUserInput();
            var secondMatrix = Matrix.CreateFromUserInput();

            var thirdMatrix = firstMatrix + secondMatrix;
            Console.WriteLine(thirdMatrix.ToString());

            thirdMatrix = -firstMatrix;
            Console.WriteLine(thirdMatrix.ToString());

            thirdMatrix = firstMatrix * secondMatrix;
            Console.WriteLine(thirdMatrix.ToString());
        }
    }
}
