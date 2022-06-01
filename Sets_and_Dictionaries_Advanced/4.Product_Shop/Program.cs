using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

        string input;
        while ((input = Console.ReadLine()) != "Revision")
        {
            string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string shopName = tokens[0];
            string productName = tokens[1];
            double productPrice = double.Parse(tokens[2]);

            if (!shops.ContainsKey(shopName))
            {
                shops[shopName] = new Dictionary<string, double>();
            }

            shops[shopName][productName] = productPrice;
        }

        shops = shops.OrderBy(s => s.Key).ToDictionary(s => s.Key, v => v.Value);

        //"{shop}->
        //Product: {product}, Price: {price}"

        foreach (var (shop, products) in shops)
        {
            Console.WriteLine($"{shop}->");

            foreach (var (product, price) in products)
            {
                Console.WriteLine($"Product: {product}, Price: {price}");
            }
        }
    }
}

