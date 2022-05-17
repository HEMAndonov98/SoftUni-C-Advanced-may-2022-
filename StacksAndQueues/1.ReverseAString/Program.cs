﻿using System;
using System.Collections.Generic;

namespace _1.ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var ch in input)
            {
                stack.Push(ch);
            }

            Console.WriteLine(string.Join(string.Empty, stack));
        }
    }
}

