using System;

namespace GenericScale
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var equality = new EqualityScale<int>(2, 2);
            Console.WriteLine(equality.AreEqual());
        }
    }
}

