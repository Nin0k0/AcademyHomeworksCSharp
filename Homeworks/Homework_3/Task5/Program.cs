using System;

namespace Task5
{
internal class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Choose matrix size:");
            Console.WriteLine("1. 2 x 2");
            Console.WriteLine("2. 3 x 3");

            int choice;
            bool isValidChoice = false;
            do
            {
                Console.Write("Enter your choice: ");
                string choiceInput = Console.ReadLine();

                isValidChoice = int.TryParse(choiceInput, out choice);
                if (!isValidChoice || (choice != 1 && choice != 2))
                {
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                }
            } while (!isValidChoice || (choice != 1 && choice != 2));

            int[,] matrix = ReadMatrix(choice);

            Console.WriteLine("You entered matrix:");
            PrintMatrix(matrix);

            int determinant = CalculateDeterminant(matrix);
            Console.WriteLine("Determinant is: " + determinant);
        }

        static int[,] ReadMatrix(int choice)
        {
            int rows, columns;
            if (choice == 1)
            {
                rows = 2;
                columns = 2;
            }
            else
            {
                rows = 3;
                columns = 3;
            }

            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    bool isValidInput = false;
                    do
                    {
                        Console.Write($"Enter element [{i}][{j}]: ");
                        string input = Console.ReadLine();

                        isValidInput = int.TryParse(input, out int value);
                        if (!isValidInput)
                        {
                            Console.WriteLine("Invalid input. Please enter an integer.");
                        }
                        else
                        {
                            matrix[i, j] = value;
                        }
                    } while (!isValidInput);
                }
            }

            return matrix;
        }

        static int CalculateDeterminant(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            if (rows == 2 && columns == 2)
            {
                int a = matrix[0, 0];
                int b = matrix[0, 1];
                int c = matrix[1, 0];
                int d = matrix[1, 1];

                int determinant = a * d - b * c;
                return determinant;
            }
            else if (rows == 3 && columns == 3)
            {
                int a = matrix[0, 0];
                int b = matrix[0, 1];
                int c = matrix[0, 2];
                int d = matrix[1, 0];
                int e = matrix[1, 1];
                int f = matrix[1, 2];
                int g = matrix[2, 0];
                int h = matrix[2, 1];
                int i = matrix[2, 2];

                int determinant = a * (e * i - f * h) - b * (d * i - f * g) + c * (d * h - e * g);
                return determinant;
            }
            else
            {
                throw new InvalidOperationException("Invalid matrix size. The determinant can only be calculated for a 2 x 2 or 3 x 3 matrix.");
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }



}
