using System;
using System.Linq;

namespace _5.Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] stairs = new char[dimensions[0], dimensions[1]];
            string snake = Console.ReadLine();
            int snakeIndex = 0;


            for (int row = 0; row < stairs.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < stairs.GetLength(1); col++)
                    {
                        stairs[row, col] = snake[snakeIndex];

                        snakeIndex = (snakeIndex == (snake.Length - 1)) ? 0 : snakeIndex += 1;
                    }
                }
                else
                {
                    for (int col = stairs.GetLength(1) - 1; col >= 0; col--)
                    {
                        stairs[row, col] = snake[snakeIndex];

                        snakeIndex = (snakeIndex == (snake.Length - 1)) ? 0 : snakeIndex += 1;
                    }
                }
            }
            PrintStairs(stairs);
        }

        static char[] CopyRow(char[,] stairs, int row)
        {
            char[] chars = new char[stairs.GetLength(1)];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = stairs[row, i];
            }

            return chars;
        }
        static void PrintStairs(char[,] stairs)
        {
            for (int r = 0; r < stairs.GetLength(0); r++)
            {
                char[] snakeArr = CopyRow(stairs, r);
                string currentSnake = new string(snakeArr);
                Console.WriteLine(currentSnake);
            }
        }
    }
}
