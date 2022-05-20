using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MaximumAndMinimumElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read input
            int n = int.Parse(Console.ReadLine());

            Stack<int> numbersStack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] cmdParams = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int cmdToken = cmdParams[0];

                // Add the number x to the stack
                if (cmdToken == 1)
                {
                    int numToAdd = cmdParams[1];
                    numbersStack.Push(numToAdd);
                }
                // Delete the top element from the stack
                else if (cmdToken == 2)
                {
                    //Check if the stack is empty(If true we dont delete any elements from the stack)
                    if (numbersStack.Count == 0)
                    {
                        continue;
                    }
                    numbersStack.Pop();
                }
                else if (cmdToken == 3)
                {
                    //Check if the stack is empty.
                    if (numbersStack.Count == 0)
                    {
                        continue;
                    }

                    Console.WriteLine(numbersStack.Max());
                }
                else if (cmdToken == 4)
                {
                    //Check if the stack is empty(If true we dont delete any elements from the stack)
                    if (numbersStack.Count == 0)
                    {
                        continue;
                    }

                    Console.WriteLine(numbersStack.Min());
                }
            }

            //Print the stack.
            Console.WriteLine(string.Join(", ", numbersStack));
        }
    }
}

