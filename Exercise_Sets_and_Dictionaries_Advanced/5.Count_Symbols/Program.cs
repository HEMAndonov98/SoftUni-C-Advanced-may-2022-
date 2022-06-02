using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var occurencies = new SortedDictionary<char, int>();
        string text = Console.ReadLine();

        for (int i = 0; i < text.Length; i++)
        {
            char letter = text[i];
            if (!occurencies.ContainsKey(letter))
            {
                occurencies[letter] = 0;
            }
            occurencies[letter] += 1;
        }

        foreach (var kvp in occurencies)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
        }
    }
}


