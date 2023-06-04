using System;

namespace _1_HOMEWORK
{
    internal class Program
    {
        static void Main()
        {
            #region Task2
            Console.WriteLine("Choose temperature");

            string temp = Console.ReadLine();
            if (double.TryParse(temp, out _))
            {
                Console.WriteLine(Temperature(double.Parse(temp)));

            }
            else
            {
                Console.WriteLine("Not a Valid temperature");
            }

            static string Temperature(double temp)
            {
                double lowBarier = 0;
                double highBarier = 30;

                return temp > highBarier ? "It's hot!" :
                       temp < lowBarier ? "It's cold!" : "Nice Weather!";
            }

            #endregion











        }
    }
}
