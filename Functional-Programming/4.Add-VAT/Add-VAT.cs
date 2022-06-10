using System;
using System.Linq;

class AddVAT
{
    static void Main()
    {
        Func<double, double> addVat = p => p * 1.2;
        double[] prices = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .Select(p => addVat(p))
            .ToArray();
        Action<double> printFormatedPrice = price => Console.WriteLine($"{price:F2}");
        Array.ForEach(prices, printFormatedPrice);
    }
}
