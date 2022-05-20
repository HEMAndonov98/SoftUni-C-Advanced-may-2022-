using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read Input
            int qtyOfFood = int.Parse(Console.ReadLine()); //quantity of food in kilograms
            Queue<int> ordersQueue = new Queue<int>(Console.ReadLine()
                .Split(' ')
                .Select(int.Parse));

            //Print the biggest order
            Console.WriteLine(ordersQueue.Max());

            //Iterate through the orders
            while (ordersQueue.Count > 0)
            {
                //Check if current quantity is enough to complete the current order in the queue
                if (qtyOfFood >= ordersQueue.Peek())
                {
                    qtyOfFood -= ordersQueue.Dequeue();
                    continue;
                }
                break;
            }
            //Check if all orders are complete
            if (ordersQueue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                //print remaining orders
                Console.WriteLine($"Orders left: {string.Join(' ', ordersQueue)}");
            }
        }
    }
}

