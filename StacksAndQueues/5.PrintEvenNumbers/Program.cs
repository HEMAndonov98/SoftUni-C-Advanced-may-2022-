using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbersQueue = new Queue<int>(input);

            for (int i = 0; i < input.Length; i++)
            {

                if (numbersQueue.Peek() % 2 == 0)
                {
                    numbersQueue.Enqueue(numbersQueue.Dequeue());
                }
                else if (numbersQueue.Peek() % 2 != 0)
                {
                    numbersQueue.Dequeue();
                }
            }
            
            Console.WriteLine(string.Join(", ", numbersQueue));
        }
    }
}

