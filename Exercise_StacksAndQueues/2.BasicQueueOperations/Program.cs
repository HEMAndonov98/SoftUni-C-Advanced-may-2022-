using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputOpperations = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = inputOpperations[0];
            int s = inputOpperations[1];
            int x = inputOpperations[2];

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbersQueue = new Queue<int>();

            // check if n is bigger than numbers length
            if (n > numbers.Length)
            {
                n = numbers.Length;
            }

            // enqueue n elements from numbers to numbersQueue
            for (int i = 0; i < n; i++)
            {
                numbersQueue.Enqueue(numbers[i]);
            }

            //check if s is bigger than numersQueue count of elements
            if (s > numbersQueue.Count)
            {
                s = numbersQueue.Count;
            }

            //Dequeue s number of elements from numbersQueue
            for (int i = 0; i < s; i++)
            {
                numbersQueue.Dequeue();
            }

            //Check if the queue is empty
            if (numbersQueue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (numbersQueue.Contains(x)) //Check if queue contains the element x
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine($"{numbersQueue.Min()}"); //write the smallest element in the queue
            }
        }
    }
}

