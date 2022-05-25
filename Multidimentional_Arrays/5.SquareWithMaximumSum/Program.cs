using System;
using System.Linq;

namespace _5.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] colElements = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = colElements[cols];
                }
            }

            int bestSquare = int.MinValue;
            string bestSquareValues = string.Empty;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSquareSum = matrix[row, col] +
                        matrix[row, col + 1] +
                        matrix[row + 1, col] +
                        matrix[row + 1, col + 1];

                    if (currentSquareSum > bestSquare)
                    {
                        bestSquare = currentSquareSum;
                        bestSquareValues = new string($"{matrix[row, col]} {matrix[row, col + 1]}" +
                            $"{Environment.NewLine}{matrix[row + 1, col]} {matrix[row + 1, col + 1]}");
                    }
                }
            }

            Console.WriteLine(bestSquareValues);
            Console.WriteLine(bestSquare);
        }
    }
}

