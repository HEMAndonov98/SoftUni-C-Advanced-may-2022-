using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Comparer<int> sort = Comparer<int>.Create((x, y) =>
        {
            if (x % 2 == 0 && y % 2 != 0)
            {
                return -1;
            }
            else if (x % 2 != 0 && y % 2 == 0)
            {
                return 1;
            }
            else
            {
                return x.CompareTo(y);
            }
        });
        Array.Sort(numbers, sort);
        Console.WriteLine(String.Join(' ', numbers));
    }
}

