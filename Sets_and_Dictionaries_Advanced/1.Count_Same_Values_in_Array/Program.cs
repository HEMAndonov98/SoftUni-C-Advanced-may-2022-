using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

            Dictionary<double, int> occurencies = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                double currentNum = input[i];

                if (!occurencies.ContainsKey(currentNum))
                {
                    occurencies[currentNum] = 0;
                }

                occurencies[currentNum] += 1;
            }

            foreach (var (number, occurence) in occurencies)
            {
                Console.WriteLine($"{number} - {occurence} times");
            }
        }
    }
}

