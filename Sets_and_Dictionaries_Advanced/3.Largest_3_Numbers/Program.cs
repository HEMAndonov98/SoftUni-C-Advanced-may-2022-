﻿using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .OrderByDescending(n => n)
            .ToArray();

        if (numbers.Length >= 3)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
        else
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}

