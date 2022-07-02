using System;
using System.Linq;

namespace _1.RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = ArraySum(numbers, 0, 0);

            Console.WriteLine(sum);

        }

        public static int ArraySum(int[] arr, int start, int sum)
        {
            if (start == arr.Length) return sum;

            sum += arr[start++];

            return ArraySum(arr, start, sum);
        }
    }
}

