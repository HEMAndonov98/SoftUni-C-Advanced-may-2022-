using System;
using System.Linq;

namespace _6.Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read input 
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];

            //Populate jagged array
            PopulateJagged(jagged);

            //Analise the jagged array

            for (int row = 0; row < jagged.GetLength(0) - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    MultiplyJagged(jagged, row);
                }
                else
                {
                    DivideJagged(jagged, row);
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int val = int.Parse(tokens[3]);

                if (!ValidateIndicies(row, col, jagged))
                {
                    continue;
                }

                if (tokens[0] == "Add")
                {
                    jagged[row][col] += val;
                }
                else if (tokens[0] == "Subtract")
                {
                    jagged[row][col] -= val;
                }
            }

            PrintJagged(jagged);
        }
        static void PopulateJagged(int[][] jagged)
        {
            for (int row = 0; row < jagged.GetLength(0); row++)
            {
                jagged[row] = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
        }
        static void MultiplyJagged(int[][] jagged, int row)
        {
            for (int col = 0; col < jagged[row].Length; col++)
            {
                jagged[row][col] *= 2;
                jagged[row + 1][col] *= 2;
            }
        }
        static void DivideJagged(int[][] jagged, int row)
        {
            for (int col1 = 0; col1 < jagged[row].Length; col1++)
            {
                jagged[row][col1] /= 2;
            }

            for (int col2 = 0; col2 < jagged[row + 1].Length; col2++)
            {
                jagged[row + 1][col2] /= 2;
            }
        }
        static bool ValidateIndicies(int row, int col, int[][] jagged)
        {
           
            if (row >= 0 && row < jagged.GetLength(0) &&
                col >= 0 && col < jagged[row].Length)
            {
                return true;
            }
            return false;
        }
        static void PrintJagged(int[][] jagged)
        {
            for (int row = 0; row < jagged.GetLength(0); row++)
            {
                Console.WriteLine(String.Join(' ', jagged[row]));
            }
        }
    }
}

