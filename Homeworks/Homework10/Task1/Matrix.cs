using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Matrix
    {
        private readonly double[,] _matrix;

        public Matrix(double[,] matrix)
        {
            _matrix = matrix;
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            int rows = matrix1._matrix.GetLength(0);
            int columns = matrix1._matrix.GetLength(1);
            //implicit casted when ints matrix
            double[,] result = new double[rows, columns];

            Enumerable.Range(0, rows).ToList().ForEach(i =>
            {
                Enumerable.Range(0, columns).ToList().ForEach(j =>
                {
                    result[i, j] = matrix1._matrix[i, j] + matrix2._matrix[i, j];
                });
            });

            return new Matrix(result);


        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            int rows = matrix1._matrix.GetLength(0);
            int columns = matrix1._matrix.GetLength(1);
            double[,] result = new double[rows, columns];

            Enumerable.Range(0, rows).ToList().ForEach(i =>
            {
                Enumerable.Range(0, columns).ToList().ForEach(j =>
                {
                    result[i, j] = matrix1._matrix[i, j] - matrix2._matrix[i, j];
                });
            });

            return new Matrix(result);
        }

        public static Matrix operator -(Matrix matrix)
        {
            
            var determinant = matrix._matrix[0,0]* matrix._matrix[1,1] - (matrix._matrix[0,1] * matrix._matrix[1,0]);

            var result = matrix.AdjMatrix() * determinant;

            return result;
        }
        public override string ToString()
        {
            int rows = _matrix.GetLength(0);
            int columns = _matrix.GetLength(1);
            string matrixString = "";

            Enumerable.Range(0, rows).ToList().ForEach(i =>
            {
                Enumerable.Range(0, columns).ToList().ForEach(j =>
                {
                    matrixString += _matrix[i, j] + " ";
                });
                matrixString += Environment.NewLine;
            });

            return matrixString;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Matrix other = (Matrix)obj;

            if (_matrix.GetLength(0) != other._matrix.GetLength(0) || _matrix.GetLength(1) != other._matrix.GetLength(1))
            {
                return false;
            }

            return _matrix.Cast<double>().SequenceEqual(other._matrix.Cast<double>());
        }
        public static Matrix CreateFromUserInput()
        {
            double[,] matrixValues = new double[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2;)
                {
                    Console.Write($"Enter the value for element [{i}, {j}]: ");
                    var value = int.TryParse(Console.ReadLine(), out int valueInt);
                    if (value)
                    {

                        matrixValues[i, j] = valueInt;
                        j++;
                    }
                    else
                    {
                        Console.WriteLine("Try valid number!");
                    }
                }

            }

            return new Matrix(matrixValues);
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            int rows1 = matrix1._matrix.GetLength(0);
            int columns1 = matrix1._matrix.GetLength(1);
            int rows2 = matrix2._matrix.GetLength(0);
            int columns2 = matrix2._matrix.GetLength(1);

            if (columns1 != rows2)
            {
                throw new ArgumentException("Invalid matrix dimensions for multiplication.");
            }

            double[,] result = new double[rows1, columns2];

            Enumerable.Range(0, rows1).ToList().ForEach(i =>
            {
                Enumerable.Range(0, columns2).ToList().ForEach(j =>
                {
                    Enumerable.Range(0, columns1).ToList().ForEach(k =>
                    {
                        result[i, j] = matrix1._matrix[i, k] * matrix2._matrix[k, j];
                    });
                });
            });
            return new Matrix(result);
        }

        //this is helper function
        public static Matrix operator *(Matrix matrix2,double determinant)
        {
            
            int rows2 = matrix2._matrix.GetLength(0);
            int columns2 = matrix2._matrix.GetLength(1);

            

            double[,] result = new double[rows2, columns2];

            Enumerable.Range(0, rows2).ToList().ForEach(i =>
            {
                Enumerable.Range(0, columns2).ToList().ForEach(j =>
                {
                    Enumerable.Range(0, columns2).ToList().ForEach(k =>
                    {
                        result[i, j] = matrix2._matrix[k, j] / determinant;
                    });
                });
            });
            return new Matrix(result);
        }

        private Matrix AdjMatrix()
        {
            if (_matrix.GetLength(0) != 2 || _matrix.GetLength(1) != 2)
            {
                throw new InvalidOperationException("Matrix must be 2x2 to calculate the adj Matrix");
            }

            double[,] adjugateValues = new double[2, 2];

            adjugateValues[0, 0] = _matrix[1, 1];
            adjugateValues[0, 1] = -_matrix[0, 1];
            adjugateValues[1, 0] = -_matrix[1, 0];
            adjugateValues[1, 1] = _matrix[0, 0];

            return new Matrix(adjugateValues);
        }
    }
}
