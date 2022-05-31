using System;
using System.Collections.Generic;

namespace _7.Knights_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] board = new char[size, size];
            int numKnightsRemoved = 0;
            Queue<Tuple<int, int>> moves = new Queue<Tuple<int, int>>();
            EnqueueMoves(moves);
            bool hasHit = true;

            FillBoard(board);
            int savedRow = 0;
            int savedCol = 0;

            while (hasHit)
            {
                int mostDangerous = 0;

                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        if (board[row, col] == 'k')
                        {
                            int dangerCounter = 0;
                            for (int i = 0; i < moves.Count; i++)
                            {
                                int moveRow = moves.Peek().Item1;
                                int moveCol = moves.Peek().Item2;

                                moves.Enqueue(moves.Dequeue());

                                if (!ValidateMove(row, col, moveRow, moveCol, board))
                                {
                                    continue;
                                }

                                if (board[row + moveRow, col + moveCol] == 'k')
                                {
                                    dangerCounter++;
                                    hasHit = true;
                                }
                             
                            }

                            if (dangerCounter > mostDangerous)
                            {
                                mostDangerous = dangerCounter;
                                savedRow = row;
                                savedCol = col;
                            }
                           
                        }
                    }
                }
                if (mostDangerous == 0)
                {
                    hasHit = false;
                }

                if (hasHit == true && savedRow != -1 && savedCol != -1)
                {
                    board[savedRow, savedCol] = 'X';
                    numKnightsRemoved++;
                }
            }

            Console.WriteLine(numKnightsRemoved);
        }

        static void FillBoard(char[,] board)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                string pieces = Console.ReadLine().ToLower();

                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = pieces[col];
                }
            }
        }
        static void EnqueueMoves(Queue<Tuple<int, int>> moves)
        {
            moves.Enqueue(new Tuple<int, int>(-2, +1));
            moves.Enqueue(new Tuple<int, int>(-1, +2));
            moves.Enqueue(new Tuple<int, int>(+1, +2));
            moves.Enqueue(new Tuple<int, int>(+2, +1));
            moves.Enqueue(new Tuple<int, int>(+2, -1));
            moves.Enqueue(new Tuple<int, int>(+1, -2));
            moves.Enqueue(new Tuple<int, int>(-1, -2));
            moves.Enqueue(new Tuple<int, int>(-2, -1));

        }
        static bool ValidateMove(int row, int col,
            int moveRow, int moveCol,
            char[,] board)
        {
            int currentMoveRow = row + moveRow;
            int currentMoveCol = col + moveCol;

            if (currentMoveRow >= 0 && currentMoveRow < board.GetLength(0) &&
                currentMoveCol >= 0 && currentMoveCol < board.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }
}

