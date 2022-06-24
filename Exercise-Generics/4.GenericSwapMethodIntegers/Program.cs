using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.GenericSwapMethodIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            int[] indexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var box = new Box<int>(list);
            box.Swap(box.Data, indexes[0], indexes[1]);
            Console.WriteLine(box);
        }
    }
}

