using System;
using System.Collections.Generic;

namespace _6.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Queue<string> customersQueue = new Queue<string>();

            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid" && customersQueue.Count > 0)
                {
                    Console.WriteLine(string.Join(Environment.NewLine, customersQueue));
                    customersQueue.Clear();
                }
                else if (input != "Paid")
                {
                    customersQueue.Enqueue(input);
                }
            }

            Console.WriteLine($"{customersQueue.Count} people remaining.");
        }
    }
}

