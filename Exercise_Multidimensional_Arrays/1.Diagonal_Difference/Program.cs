using System;
using System.Linq;

namespace _1.Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] square = new int[size, size];
            FillSquare(square);

            //Find diagonal sums

            int primeDiagSum = 0;
            int secDiagSum = 0;

            for (int rowAndCol = 0; rowAndCol < size; rowAndCol++)
            {
                primeDiagSum += square[rowAndCol, rowAndCol];
                secDiagSum += square[rowAndCol, (size - 1) - rowAndCol];
            }

            Console.WriteLine(Math.Abs(primeDiagSum - secDiagSum));
        }

        static void FillSquare(int[,] square)
        {
            for (int row = 0; row < square.GetLength(0); row++)
            {
                int[] columnElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < square.GetLength(1); col++)
                {
                    square[row, col] = columnElements[col];
                }
            }
        }
    }
}

