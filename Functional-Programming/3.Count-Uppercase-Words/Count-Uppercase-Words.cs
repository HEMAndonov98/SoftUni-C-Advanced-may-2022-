using System;
using System.Linq;

class CountUpperCaseWords
{
    static void Main()
    {
        //Just testing how to write functions
        Func<string, bool> isUpper = w => char.IsUpper(w[0]);
        string[] words = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //alternative is to write .Where(w => char.IsUpper(w))
            .Where(isUpper)
            .ToArray();

        //Action syntax test
        Action<string> printWord = w => Console.WriteLine(w);
        Array.ForEach(words, printWord);

        //Better alternative is to just write Console.WriteLine(string.Join(Enviorment.NewLine, words))

    }
}

