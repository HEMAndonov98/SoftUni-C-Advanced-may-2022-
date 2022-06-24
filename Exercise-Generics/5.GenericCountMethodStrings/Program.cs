using System;
using System.Collections.Generic;

namespace _5.GenericCountMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
            var box = new Box<string>(list);
            Console.WriteLine(box.CompareCount(box.Data, Console.ReadLine()));
        }
    }
}

