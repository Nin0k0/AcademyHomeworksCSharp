namespace Homework16;

public static class Calculator
{
    public static double Addition(double x, double y)
    {
        return x + y;
    }

    public static double Subtraction(double x, double y)
    {
        return x - y;
    }

    public static double Multiplication(double x, double y)
    {
        return x * y;
    }

    public static double Division(double x, double y)
    {
        if (y != 0)
            return x / y;
        else
            throw new DivideByZeroException("Cannot divide by zero.");
    }

    public static double Exponentiation(double x, double y)
    {
        return Math.Pow(x, y);
    }

    public static double SquareRoot(double x, double y)
    {
        if (x >= 0)
            return Math.Sqrt(x);
        throw new ArgumentException("Cannot calculate square root of a negative number.");
    }
}