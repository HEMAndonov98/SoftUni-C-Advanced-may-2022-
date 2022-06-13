using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

class ListOfPredicates
{
    static void Main()
    {
        int range = int.Parse(Console.ReadLine());
        int[] dividers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        List<int> divisibleNumbers = new List<int>();
        Func<int[], int, bool> isDivisible = (d, n) =>
        {
            for (int i = 0; i < d.Length; i++)
            {
                if (n % d[i] != 0)
                {
                    return false;
                }
            }
            return true;
        };
        Action<List<int>> PrintDivisibleNums = n => Console.WriteLine(String.Join(' ', divisibleNumbers));

        for (int number = 1; number <= range; number++)
        {
            if (isDivisible(dividers, number))
            {
                divisibleNumbers.Add(number);
            }
        }

        PrintDivisibleNums(divisibleNumbers);
    }

}

