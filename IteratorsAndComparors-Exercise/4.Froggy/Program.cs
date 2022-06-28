using System;
using System.Linq;

namespace _4.Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var lake = new Lake(input);
            Console.WriteLine(String.Join(", ", lake));
        }
    }
}

