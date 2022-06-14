using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] names = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine(names.First(name => name.Select(symbol => (int)symbol).Sum() >= n));
    }
}

