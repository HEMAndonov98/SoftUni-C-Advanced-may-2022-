using System;
using System.Linq;

namespace _1.SumMatrixElements
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
        int sum = 0;

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            int[] colElements = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = colElements[cols];
                    sum += matrix[rows, cols];
                }
        }

        Console.WriteLine(matrix.GetLength(0));
        Console.WriteLine(matrix.GetLength(1));
        Console.WriteLine(sum);
    }
}
}

