using System;
using System.Collections.Generic;

namespace _6.GenericCountMethodDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<double>();
            for (int i = 0; i < n; i++)
            {
                list.Add(double.Parse(Console.ReadLine()));
            }
            var box = new Box<double>(list);
            Console.WriteLine(box.CompareCount(box.Data, double.Parse(Console.ReadLine())));
        }
    }
}

