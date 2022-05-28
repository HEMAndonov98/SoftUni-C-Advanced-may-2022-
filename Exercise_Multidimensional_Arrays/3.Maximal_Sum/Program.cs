using System;
using System.Linq;

namespace _3.Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[dimensions[0], dimensions[1]];
            FillRectangle(matrix);

            int bestRecSum = int.MinValue;
            int[,] bestRectangle = new int[3, 3];

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int[,] currRectangle = new int[3, 3]
                    {
                        {matrix[row, col], matrix[row, col + 1], matrix[row, col + 2] },
                        {matrix[row + 1, col], matrix[row + 1, col + 1], matrix[row + 1, col + 2] },
                        {matrix[row + 2, col], matrix[row + 2, col + 1], matrix[row + 2, col + 2] }
                    };

                    int currRecSum =
                      (from int val in currRectangle select val)
                      .Sum();

                    if (currRecSum > bestRecSum)
                    {
                        bestRecSum = currRecSum;
                        Array.Copy(currRectangle, 0, bestRectangle, 0, currRectangle.Length);
                    }
                }
            }

            Console.WriteLine($"Sum = {bestRecSum}");
            PrintRectangle(bestRectangle);
            
        }

        static void FillRectangle(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columnElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columnElements[col];
                }
            }
        }
        static void PrintRectangle(int[,] bestRectangle)
        {
            for (int r = 0; r < bestRectangle.GetLength(0); r++)
            {
                for (int c = 0; c < bestRectangle.GetLength(1); c++)
                {
                    Console.Write($"{bestRectangle[r, c]} ");
                }

                Console.WriteLine();
            }
        }
    }
}

