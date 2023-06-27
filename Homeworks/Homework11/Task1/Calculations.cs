using System;

namespace Task1
{
    public interface ICalculations<T>
    {
        T Add(T x, T y);
        T Subtract(T x, T y);
        T Multiply(T x, T y);
    }

    public class IntegerCalculations : ICalculations<int>
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }

    public class DoubleCalculations : ICalculations<double>
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }
    }

    public class StringCalculations : ICalculations<string>
    {
        public string Add(string x, string y)
        {
            return x + " " + y;
        }

        public string Multiply(string a, string b)
        {
            throw new NotSupportedException();
        }

        public string Subtract(string a, string b)
        {
            throw new NotSupportedException();
        }
    }

}
