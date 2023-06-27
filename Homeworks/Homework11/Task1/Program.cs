using System;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            ICalculations<int> intCalculator = new IntegerCalculations();
            
            var minus = intCalculator.Subtract(30, 45);
            var multiply = intCalculator.Multiply(1000, 4500);
            var sum = intCalculator.Add(254, 300);
            Console.WriteLine($" sum = {sum}, minus = {minus}, multiply = {multiply}");

            ICalculations<double> doubleCalculator = new DoubleCalculations();
            double sumDouble = doubleCalculator.Add(52.4, 4);         
            double multiplyDouble = doubleCalculator.Multiply(96.4, -6.5);
            double minusDouble = doubleCalculator.Subtract(3.0, 789.0);
            Console.WriteLine($"sumDouble = {sumDouble}, multiplyDouble = {multiplyDouble}, minusDouble = {minusDouble}");
        }
    }
}
