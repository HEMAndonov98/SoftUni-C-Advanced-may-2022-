using System;
using System.Linq;

class AppliedArithmetics
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        string arg;
        while ((arg = Console.ReadLine()) != "end")
        {
            if (arg == "print")
            {
                Console.WriteLine(String.Join(' ', numbers));
                continue;
            }
            Func<int, int> calc = CreateFunc(numbers, arg);

            numbers = numbers.Select(calc).ToArray();
            
            
        }
    }

    private static Func<int, int> CreateFunc( int[] numbers, string arg)
    {
        if (arg == "add")
        {
            return x => x + 1;
        }
        else if (arg == "multiply")
        {
            return x => x * 2;
        }
        else if (arg == "subtract")
        {
            return x => x - 1;
        }

        return x => x;
    }
}

