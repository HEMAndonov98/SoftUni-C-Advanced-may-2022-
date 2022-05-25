using System;
using System.Linq;

namespace _6.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int rowsCount = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rowsCount][];

            for (int rows = 0; rows < rowsCount; rows++)
            {
                jagged[rows] = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            string cmd;

            while ((cmd = Console.ReadLine()) != "END")
            {
                string[] tokens = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int val = int.Parse(tokens[3]);

                if (cmd.StartsWith("Subtract"))
                {
                    val = -val;
                }

                if (row < 0 || row >= jagged.Length || col < 0 || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                jagged[row][col] += val;
            }

            foreach (var row in jagged)
            {
                Console.WriteLine(String.Join(' ', row));
            }
        }
    }
}

