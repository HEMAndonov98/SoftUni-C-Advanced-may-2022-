using System;
using System.Linq;

namespace _4.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int r = 0; r < n; r++)
            {
                string input = Console.ReadLine();

                for (int c = 0; c < n; c++)
                {
                    matrix[r, c] = input[c];
                }
            }

            int sybolToSearch = char.Parse(Console.ReadLine());
            bool symbolIsFound = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == sybolToSearch)
                    {
                        Console.WriteLine($"({row}, {col})");
                        symbolIsFound = true;
                        break;
                    }
                }
                if (symbolIsFound)
                {
                    break;
                }
            }

            if (!symbolIsFound)
            {
                Console.WriteLine($"{(char)sybolToSearch} does not occur in the matrix");
            }
        }
    }
}

