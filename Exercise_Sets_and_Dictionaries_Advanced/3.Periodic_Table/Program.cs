using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var uniqueChems = new SortedSet<string>();

        for (int i = 0; i < n; i++)
        {
            List<string> compounds = new List<string>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));

            uniqueChems.UnionWith(compounds);
        }

        Console.WriteLine(String.Join(' ', uniqueChems));
    }
}

