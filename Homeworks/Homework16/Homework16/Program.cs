using Homework16;

while (true)
{
    Console.WriteLine("Select an operation:");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Exponentiation");
    Console.WriteLine("6. Square Root");
    Console.WriteLine("0. Exit");

    Console.Write("Enter your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 0)
        break;

    double result = 0;

    if (choice >= 1 && choice <= 4)
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        MathOperation operation = null;

        switch (choice)
        {
            case 1:
                operation = Calculator.Addition;
                break;
            case 2:
                operation = Calculator.Subtraction;
                break;
            case 3:
                operation = Calculator.Multiplication;
                break;
            case 4:
                operation = Calculator.Division;
                break;
        }

        if (operation != null)
        {
            result = PerformOperation(operation, num1, num2);
        }
    }
    else if (choice == 5)
    {
        Console.Write("Enter the base number: ");
        double baseNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        double exponent = Convert.ToDouble(Console.ReadLine());

        result = PerformOperation(Calculator.Exponentiation, baseNum, exponent);
    }
    else if (choice == 6)
    {
        Console.Write("Enter the number: ");
        double num = Convert.ToDouble(Console.ReadLine());

        result = PerformOperation(Calculator.SquareRoot, num, 0);
    }

    Console.WriteLine($"Result: {result}");
    Console.WriteLine();
}


        

 static double PerformOperation(MathOperation operation, double x, double y)
{
    return operation(x, y);
}