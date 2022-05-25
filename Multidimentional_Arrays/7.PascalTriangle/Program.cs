using System;

namespace _7.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] triangle = new long[n][];

            for (int row = 0; row < n; row++)
            {
                triangle[row] = new long[row + 1];
                triangle[row][0] = 1;
                triangle[row][row] = 1;

                for (int column = 1; column < row; column++)
                {
                    triangle[row][column] =
                        triangle[row - 1][column - 1]
                        + triangle[row - 1][column];
                }

            }

            foreach (var row in triangle)
            {
                Console.WriteLine(String.Join(' ', row));
            }
        }
    }
}

