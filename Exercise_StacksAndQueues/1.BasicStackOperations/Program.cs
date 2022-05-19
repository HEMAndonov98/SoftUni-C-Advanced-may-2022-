using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = input[0]; // how many elements to push "5"
            int s = input[1]; // how many elements to pop "2"
            int x = input[2]; // element to look for in the stack "13"

            int[] numbersToOperate = Console.ReadLine() //numbers to opperate on "1 13 45 32 4"
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            //Push Operation

            if (n > numbersToOperate.Length)
            {
                n = numbersToOperate.Length;
            }

            for (int i = 0; i < n; i++)
            {
                stack.Push(numbersToOperate[i]);
            }

            //Pop Operation

            if (s > stack.Count)
            {
                s = stack.Count;
            }

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            //Contains Operation

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (stack.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}

