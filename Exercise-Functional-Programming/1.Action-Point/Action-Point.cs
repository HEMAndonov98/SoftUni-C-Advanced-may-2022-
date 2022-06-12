using System;

class ActionPoint
{
    static void Main(string[] args)
    {
        //Method 1
        //Method1();

        Method2();
    }

    private static void Method2()
    {
        Console.WriteLine
                    (
                    String.Join
                    (
                        Environment.NewLine,
                        Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries))
                    );
    }

    private static void Method1()
    {
        Action<string> printName = name => Console.WriteLine(name);
        string[] names = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Array.ForEach(names, printName);
    }
}
