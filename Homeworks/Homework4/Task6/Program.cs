using System;

internal class Program
{
    static void Main()
    {
        int x, y, z;

        Console.Write("Enter the number of rows in the first matrix : ");
        while (!int.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Invalid input");
            Console.Write("Enter the number of rows in the first matrix : ");
        }

        Console.Write("Enter the number of columns in the first matrix and rows in the second matrix: ");
        while (!int.TryParse(Console.ReadLine(), out y))
        {
            Console.WriteLine("Invalid input");
            Console.Write("Enter the number of columns in the first matrix and rows in the second matrix: ");
        }

        Console.Write("Enter the number of columns in the second matrix: ");
        while (!int.TryParse(Console.ReadLine(), out z))
        {
            Console.WriteLine("Invalid input");
            Console.Write("Enter the number of columns in the second matrix: ");
        }


        //რადგან არ შეიძლება რომ პირველი მატრიცის სვეტების სვეტების და მეორე მატრიცის ხაზების რაოდენობა აცდენილი იყოს
        // აღარ ვთხოვ შეყვანას და პირდაპირ ვუტოლებ ამ ორს
        int[,] matrix1 = new int[x, y];
        int[,] matrix2 = new int[y, z];

        Console.WriteLine("Enter the elements of the first matrix:");
        GetMatrixElements(matrix1);

        Console.WriteLine("Enter the elements of the second matrix:");
        GetMatrixElements(matrix2);

        int[,] result = MultiplyMatrices(matrix1, matrix2);

        Console.WriteLine("The result matrix is:");
        PrintMatrix(result);
    }

    static void GetMatrixElements(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"Enter element at position ({i + 1},{j + 1}): ");
                while (!int.TryParse(Console.ReadLine(), out matrix[i, j]))
                {
                    Console.WriteLine("Invalid input. Please enter an integer value.");
                    Console.Write($"Enter element at position ({i + 1},{j + 1}): ");
                }
            }
        }
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int x = matrix1.GetLength(0);
        int y = matrix1.GetLength(1);
        int z = matrix2.GetLength(1);

        int[,] result = new int[x, z];

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < z; j++)
            {
                for (int k = 0; k < y; k++)
                {
                    result[i, j] += Multiply(matrix1[i, k], matrix2[k, j]);
                }
            }
        }

        return result;
    }

    static int Multiply(int a, int b)
    {
        int result = 0;
        while (b != 0)
        {
            if ((b & 1) != 0)
            {
                result += a;
            }
            a <<= 1;
            b >>= 1;
        }
        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
