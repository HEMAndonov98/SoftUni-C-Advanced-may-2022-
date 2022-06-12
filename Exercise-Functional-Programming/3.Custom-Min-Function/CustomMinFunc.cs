using System;
using System.Linq;

class CustomMinFunc
{
    static void Main()
    {
        Func<int[], int> customMin = numbers =>
        {
            int min = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        };
        int[] numbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine(customMin(numbers));
    }
}


