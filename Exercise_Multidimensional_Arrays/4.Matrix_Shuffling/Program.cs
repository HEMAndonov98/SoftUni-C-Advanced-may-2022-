using System;
using System.Linq;

namespace _4.Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[dimensions[0], dimensions[1]];
            FillMatrix(matrix);

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "swap" && tokens.Length == 5 && ValidateInput(tokens))
                {
                    
                        int x1 = int.Parse(tokens[1]);
                        int y1 = int.Parse(tokens[2]);
                        int x2 = int.Parse(tokens[3]);
                        int y2 = int.Parse(tokens[4]);

                    if (!ValidateCoordinates(x1, y1, x2, y2, dimensions))
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    string temp = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = temp;
                    PrintMatrix(matrix);
                  
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] colElements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
        }
        static bool ValidateInput(string[] tokens)
        {
            string[] coordinates = tokens.Skip(1).ToArray();
            
            for (int i = 0; i < coordinates.Length; i++)
            {
                int result;
                if (!int.TryParse(coordinates[i], out result))
                {
                    return false;
                }
            }
            return true;
        }
        static bool ValidateCoordinates(int x1, int y1, int x2, int y2, int[] dimensions)
        {
            int rowLength = dimensions[0];
            int colLength = dimensions[1];

            if (x1 < 0 || x1 >= rowLength || x2 < 0 || x2 >= rowLength)
            {
                return false;
            }

            if (y1 < 0 || y1 >= colLength || y2 < 0 || y2 >= colLength)
            {
                return false;
            }

            return true;
        }
        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
