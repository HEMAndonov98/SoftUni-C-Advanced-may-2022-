using System;

namespace _1.GenericBoxOfString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new Box<string>(Console.ReadLine()));
            }
        }
    }
}

