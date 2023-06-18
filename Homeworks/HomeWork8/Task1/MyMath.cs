using System;

namespace Task1
{
    internal class MyMath
    {
        private readonly static double tolerance = 0.0000000000001;
        public static double Sum (double x, double y)
        {
            return x + y;
        }


        public static double Substract (double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double? Divide(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            try
            {
                throw new ArgumentException("Can't divide numbers to 0!");
            }
            catch (Exception e)
            {

                Console.WriteLine( e.Message);
                Console.WriteLine(e.StackTrace);
                return null;
            }
           
        
        }

        public static double Pow(double number, int pow)
        {
            double result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= number;
            }

            return result;

        }

        public static double Sqrt(double x)
        {
            if (x < 0)
            {
                throw new ArgumentException("Operation Can't be Done on Negative numbers");
            }

            if (x == 0)
            {
                return 0;
            }
            if (x == 1)
            {
                return 1;
            }

            double randomGuess = x / 2; 

            while (GetAbsolute(randomGuess * randomGuess - x) > tolerance)
            {
                randomGuess = (randomGuess + x / randomGuess) / 2;
            }

            return randomGuess;
        }

        private static  double GetAbsolute(double x)
        {
            if (x < 0)
            {
                return x - (2 * x);
            }
            return x;
        }
    }


}
