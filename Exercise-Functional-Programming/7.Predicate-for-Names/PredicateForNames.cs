using System;
using System.Collections.Generic;
using System.Linq;

class PredicateForNames
{
    static void Main()
    {
        //Method1();
        //Method2();
    }

    private static void Method2()
    {
        int length = int.Parse(Console.ReadLine());
        List<string> names = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        Func<string, bool> filterNames = n => n.Length <= length;

        Console.WriteLine
            (
                string.Join
                (
                    Environment.NewLine,
                    names
                    .Where(filterNames)
                )
            );
    }
    private static void Method1()
    {
        int length = int.Parse(Console.ReadLine());
        List<string> names = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        Predicate<string> isRequiredLength = n => n.Length <= length;
        Action<List<string>> printNames = names =>
        {
            for (int i = 0; i < names.Count; i++)
            {
                if (!isRequiredLength(names[i]))
                {
                    names.RemoveAt(i);
                    i--;
                }
            }


            Console.WriteLine(String.Join(Environment.NewLine, names));
        };

        printNames(names);
    }
}
