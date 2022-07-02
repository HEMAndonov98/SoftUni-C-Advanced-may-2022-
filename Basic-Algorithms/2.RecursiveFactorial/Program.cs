using System;

namespace _2.RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateFactorial(int.Parse(Console.ReadLine())));
        }

        public static long CalculateFactorial(int n)
        {
            if (n >= 1) return n * CalculateFactorial(n - 1);
            else
                return 1;
        }

    }
}

