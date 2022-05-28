using System;
using System.Linq;

namespace _2.Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[,] matrix = new char[dimensions[0], dimensions[1]];
            FillMatrix(matrix);

            int equalSquaresFound = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {

                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char[] currSquare = new char[4]
                    {
                        matrix[row, col],
                        matrix[row, col + 1],
                        matrix[row + 1, col],
                        matrix[row + 1, col + 1]
                    };

                    if (currSquare.All(val => val == currSquare[0]))
                    {
                        equalSquaresFound++;
                    }
                }
            }

            Console.WriteLine(equalSquaresFound);
        }

        static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] columnElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columnElements[col];
                }
            }
        }
    }
}

