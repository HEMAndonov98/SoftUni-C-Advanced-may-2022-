using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, Dictionary<string, List<string>>> continets = new Dictionary<string, Dictionary<string, List<string>>>();

        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string continent = tokens[0];
            string country = tokens[1];
            string city = tokens[2];

            if (!continets.ContainsKey(continent))
            {
                continets[continent] = new Dictionary<string, List<string>>();         
            }

            if (!continets[continent].ContainsKey(country))
            {
                continets[continent][country] = new List<string>();
            }

            continets[continent][country].Add(city);
        }

        foreach (var (continentName, countryName) in continets)
        {
            Console.WriteLine($"{continentName}:");
            foreach (var (contr, cty) in countryName)
            {
                Console.WriteLine($"    {contr} -> {string.Join(", ", cty)}");
            }
        }
    }
}

