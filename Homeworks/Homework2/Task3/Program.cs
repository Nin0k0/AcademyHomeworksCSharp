using System;

namespace Task3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a number to draw a pyramid: ");
            var number = Console.ReadLine();
            if (int.TryParse(number, out _))
            {
                var numberInt = int.Parse(number);
                if (numberInt > 0)
                {
                    DrawPyramid(numberInt);
                }
                else if (numberInt < 0)
                {
                    DrawPyramidBackward(Math.Abs(numberInt));
                }
                else
                {
                    Console.WriteLine("No Pyramids for you!");
                }


            }
            else { Console.WriteLine("Not a valid Number"); }
        }
        static void DrawPyramid(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                var spaces = new string(' ', number - i);
                var stars = new string('*', 2 * i - 1);
                Console.WriteLine(spaces + stars);
            }
        }
        //for fun I also did backwards in case of negative numbers
        static void DrawPyramidBackward(int number)
        {
            for (int i = number; i >= 1; i--)
            {
                var spaces = new string(' ', number - i);
                var stars = new string('*', 2 * i - 1);
                Console.WriteLine(spaces + stars);
            }
        }
    }
}
