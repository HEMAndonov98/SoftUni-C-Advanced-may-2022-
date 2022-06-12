using System;

class KnightOfHonor
{
    static void Main(string[] args)
    {
        string[] names = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Action<string> addSir = name => Console.WriteLine($"Sir {name}");
        Array.ForEach(names, addSir);
    }
}
