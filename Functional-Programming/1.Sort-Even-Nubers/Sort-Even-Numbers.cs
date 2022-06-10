using System;
using System.Linq;

class SortEvenNumbers
{
    static void Main()
    {
        SortNumsPureFunc();
        Method2Sorting();
    }

    static void SortNumsPureFunc()
    {
        Console.WriteLine
                    (
                    String.Join
                        (
                            ", ", Console.ReadLine()
                        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .Where(n => n % 2 == 0)
                        .OrderBy(n => n)
                        .ToArray()
                        )
                    );
    }
    static void Method2Sorting()
    {
        string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

        //Function that takes a string x and parses it to an integer 
        Func<string, int> Parser = x => int.Parse(x);
        //.Select calls the Parser func for all the elements in the sequence
        int[] numbers = input.Select(Parser).ToArray();

        Func<int, bool> Filter = n => n % 2 == 0;
        int[] evenNumbers = numbers.Where(Filter).ToArray();
    }
}
