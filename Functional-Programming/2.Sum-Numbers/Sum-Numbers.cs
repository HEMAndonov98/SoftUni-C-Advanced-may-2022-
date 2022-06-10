using System;
using System.Linq;

class SumNumbers
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
              .Split(", ", StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();
        Console.WriteLine(numbers.Length);
        Console.WriteLine(numbers.Sum());
    }
}
