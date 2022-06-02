using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        //Key of the Dict is the color
        //Key of the Dict Value is the clothing item
        //Value of the Dict Value is the occurence of said item
        var wardrobe = new Dictionary<string, Dictionary<string, int>>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

            string color = tokens[0];
            string[] items = tokens[1].Split(',', StringSplitOptions.RemoveEmptyEntries);
            //Add Color to the wardrobe
            if (!wardrobe.ContainsKey(color))
            {
                wardrobe[color] = new Dictionary<string, int>();
            }

            //Cycle through the items given in the input
            for (int j = 0; j < items.Length; j++)
            {
                //Check if this color contains this item
                if (!wardrobe[color].ContainsKey(items[j]))
                {
                    wardrobe[color][items[j]] = 0;
                }
                //Item already exists and we only need to increase occurence count
                wardrobe[color][items[j]] += 1;
            }
        }

        string[] search = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string found = " (found!)";
        
        foreach (var (color, items) in wardrobe)
        {
            //Print Each Color
            Console.WriteLine($"{color} clothes:");
            //Trinary operator if color is found
            bool colorIsFound = (color == search[0]) ? true : false;
            foreach (var (item, occurence) in items)
            {
                //for each color print all its items and if the trinary operator is true concat a new string (found!) else
                //concat an empty string(nothing)
                Console.WriteLine($"* {item.Trim()} - {occurence}{new string((colorIsFound && item == search[1]) ? found : string.Empty)}");
            }
        }
    }
}

