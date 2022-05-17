using System;
using System.Collections.Generic;

namespace _3.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Stack<string> stack = new Stack<string>();

            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                stack.Push(tokens[i]);
            }

            for (int i = 0; i < stack.Count; i++)
            {
                stack.Push(stack.Pop());
            }

            int result = int.Parse(stack.Pop());
            while (stack.Count > 0)
            {
                char opperator = char.Parse(stack.Pop());
                int number = int.Parse(stack.Pop());

                if (opperator == '+')
                {
                    result += number;
                }

                if (opperator == '-')
                {
                    result -= number;
                }

            }

            Console.WriteLine(result);
        }
    }
}

