using System;
using System.Collections.Generic;
using System.Linq;

class FindEvenOrOdds
{
    static void Main()
    {
        int[] range = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        string condition = Console.ReadLine();
        Predicate<int> filter = CreatePredicate(condition);

        List<int> numbers = new List<int>();
        for (int i = range[0]; i <= range[1]; i++)
        {
            if (filter(i))
            {
                numbers.Add(i);
            }
        }

        Console.WriteLine(String.Join(' ', numbers));
    }

    private static Predicate<int> CreatePredicate(string condition)
    {
        if (condition == "even")
        {
            return x => x % 2 == 0;
        }
        else if (condition == "odd")
        {
            return x => x % 2 != 0;
        }

        throw new ArgumentException("Invalid condition given");
    }
}

