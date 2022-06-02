using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] lengths = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        HashSet<int> firstSet = new HashSet<int>();
        HashSet<int> secondSet = new HashSet<int>();

        int currentNum = 0;
        for (int i = 0; i < lengths[0]; i++)
        {
            currentNum = int.Parse(Console.ReadLine());
            firstSet.Add(currentNum);
        }
        for (int j = 0; j < lengths[1]; j++)
        {
            currentNum = int.Parse(Console.ReadLine());
            secondSet.Add(currentNum);
        }

        firstSet.IntersectWith(secondSet);

        Console.WriteLine(String.Join(' ', firstSet));
    }
}

