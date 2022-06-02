using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var lotRegistry = new HashSet<string>();
        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string carNumber = tokens[1];

            if (input.StartsWith("IN"))
            {
                lotRegistry.Add(carNumber);
            }
            else if (input.StartsWith("OUT"))
            {
                lotRegistry.Remove(carNumber);
            }
        }

        if (lotRegistry.Count > 0)
        {
            foreach (var car in lotRegistry)
            {
                Console.WriteLine(car);
            }
        }
        else
        {
            Console.WriteLine("Parking Lot is Empty");
        }
    }
}

