using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var occurencies = new Dictionary<int, int>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (!occurencies.ContainsKey(num))
            {
                occurencies[num] = 0;
            }
            occurencies[num] += 1;
        }
        int even = occurencies.First(n => n.Value % 2 == 0).Key;
        Console.WriteLine(even);
    }
}

