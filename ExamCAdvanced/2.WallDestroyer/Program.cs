using System;
using System.Linq;

namespace _2.WallDestroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize, matrixSize];
            int rowPosition = 0;
            int colPosition = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                char[] layout = FillLayout(input);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = layout[col];
                    if (matrix[row, col] == 'V')
                    {
                        rowPosition = row;
                        colPosition = col;
                        matrix[row, col] = '*';
                    }
                }
            }

            int rodsHit = 0;
            int holesMade = 1;

            Tuple<int, int> up = new Tuple<int, int>(-1, 0);
            Tuple<int, int> down = new Tuple<int, int>(1, 0);
            Tuple<int, int> left = new Tuple<int, int>(0, -1);
            Tuple<int, int> right = new Tuple<int, int>(0, 1);

            string command;
            while ((command = Console.ReadLine()) != "End" )
            {
                if (command == "up")
                {
                    if (!CheckBoundaries(rowPosition, colPosition, up, matrix))
                        continue;
                    rowPosition += up.Item1;
                    colPosition += up.Item2;
                }
                else if (command == "down")
                {
                    if (!CheckBoundaries(rowPosition, colPosition, down, matrix))
                        continue;
                    rowPosition += down.Item1;
                    colPosition += down.Item2;
                }
                else if (command == "left")
                {
                    if (!CheckBoundaries(rowPosition, colPosition, left, matrix))
                        continue;
                    rowPosition += left.Item1;
                    colPosition += left.Item2;
                }
                else if (command == "right")
                {
                    if (!CheckBoundaries(rowPosition, colPosition, right, matrix))
                        continue;
                    rowPosition += right.Item1;
                    colPosition += right.Item2;
                }

                if (matrix[rowPosition, colPosition] == '-')
                {
                    matrix[rowPosition, colPosition] = '*';
                    holesMade++;
                }
                else if (matrix[rowPosition, colPosition] == '*')
                {
                    Console.WriteLine($"The wall is already destroyed at position [{rowPosition}, {colPosition}]!");
                }
                else if (matrix[rowPosition, colPosition] == 'R')
                {
                    Console.WriteLine("Vanko hit a rod!");
                    rodsHit++;
                    if (command == "up")
                    {

                        rowPosition -= up.Item1;
                        colPosition -= up.Item2;
                    }
                    else if (command == "down")
                    {

                        rowPosition -= down.Item1;
                        colPosition -= down.Item2;
                    }
                    else if (command == "left")
                    {

                        rowPosition -= left.Item1;
                        colPosition -= left.Item2;
                    }
                    else if (command == "right")
                    {

                        rowPosition -= right.Item1;
                        colPosition -= right.Item2;
                    }
                }
                else if (matrix[rowPosition, colPosition] == 'C')
                {
                    matrix[rowPosition, colPosition] = 'E';
                    holesMade++;
                    Console.WriteLine($"Vanko got electrocuted, but he managed to make {holesMade} hole(s).");
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col]);
                        }
                        Console.WriteLine();
                    }
                    break;
                }
            }
            if (command == "End")
            {
                matrix[rowPosition, colPosition] = 'V';
                Console.WriteLine($"Vanko managed to make {holesMade} hole(s) and he hit only {rodsHit} rod(s).");

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    Console.WriteLine();
                }
            }
        }

        public static char[] FillLayout(string input)
        {
            char[] temp = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                temp[i] = input[i];
            }
            return temp;
        }
        public static bool CheckBoundaries(int row, int col, Tuple<int, int> direction, char[,] matrix)
        {
            row += direction.Item1;
            col += direction.Item2;

            if (row >= 0 && row < matrix.GetLength(0) &&
                col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }


    }
}

