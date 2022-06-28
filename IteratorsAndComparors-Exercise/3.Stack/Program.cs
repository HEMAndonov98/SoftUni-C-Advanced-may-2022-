using System;
using System.Linq;

namespace _3.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var customStack = new MyStack<int>();

            string lines;
            while ((lines = Console.ReadLine()) != "END")
            {
                if (lines.StartsWith("Push"))
                {
                    var numbers = lines.Split(new String[] {", ", " "}, StringSplitOptions.RemoveEmptyEntries)
                        .Skip(1)
                        .Select(int.Parse)
                        .ToArray();

                    foreach (var number in numbers)
                    {
                        customStack.Push(number);
                    }
                }
                else if (lines == "Pop")
                {
                    customStack.Pop();
                }
            }

            foreach (var element in customStack)
            {
                Console.WriteLine(element);
            }

            foreach (var element in customStack)
            {
                Console.WriteLine(element);
            }
        }
    }
}

