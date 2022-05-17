using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(input);

            string cmd;
            while ((cmd = Console.ReadLine().ToLower()) != "end")
            {
                string[] tokens = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "add")
                {
                    stack.Push(int.Parse(tokens[1]));
                    stack.Push(int.Parse(tokens[2]));
                    continue;
                }

                if (tokens[0] == "remove")
                {
                    int numOfElementsToRemove = int.Parse(tokens[1]);

                    if (stack.Count < numOfElementsToRemove)
                    {
                        continue;
                    }

                    for (int i = 0; i < numOfElementsToRemove; i++)
                    {
                        stack.Pop();
                    }
                }
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}

