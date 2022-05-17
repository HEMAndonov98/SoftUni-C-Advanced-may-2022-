using System;
using System.Collections.Generic;

namespace _4.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == '(')
                {
                    stack.Push(i);
                }

                if (currentChar == ')')
                {
                    int startIndex = stack.Pop();

                    Console.WriteLine(input.Substring(startIndex, i - startIndex + 1));
                }
            }
        }

       
    }
}

