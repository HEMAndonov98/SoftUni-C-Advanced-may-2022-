using System;
using System.Linq;

class ReverseAndExclude
{
    static void Main(string[] args)
    {
        //Custom function for reversing array, can be even more customizable by making own method.
        Func<int[], int[]> reverseArr = arr => arr.Reverse().ToArray();
        //standard reading of collection and parsing
        int[] numbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int divider = int.Parse(Console.ReadLine());
        //filter checks if the number isn't divisible by the divider
        Func<int, bool> filter = n => n % divider != 0;

        //write a new line
        Console.WriteLine
            (
            //join the the collection given inside the custom reverseArr method
            String.Join
                (' ', reverseArr
                    (
                    //parameter given to the function is numbers
                    numbers
                    //.Where filters the collection by the given filter and returns a new collection
                    .Where(filter)
                    //.ToArray() We make the collection into a integer array.
                    .ToArray()
                    )
                )
            );
        //? Just for testing functional programming concepts in reality hard to read.
    }
}
