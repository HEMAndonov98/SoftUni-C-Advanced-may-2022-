using System;

namespace _7.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameAndAddress = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var fullName = $"{nameAndAddress[0]} {nameAndAddress[1]}";
            var address = nameAndAddress[2];

            var nameAddress = new MyTuple<string, string>(fullName, address);

            var nameAndBeer = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var name = nameAndBeer[0];
            var liters = int.Parse(nameAndBeer[1]);

            var nameBeer = new MyTuple<string, int>(name, liters);

            var numbersInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var intNumber = int.Parse(numbersInput[0]);
            var doubleNumber = double.Parse(numbersInput[1]);

            var numbers = new MyTuple<int, double>(intNumber, doubleNumber);

            Console.WriteLine(nameAddress);
            Console.WriteLine(nameBeer);
            Console.WriteLine(numbers);

            
        }
    }
}

