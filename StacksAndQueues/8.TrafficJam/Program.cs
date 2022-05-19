using System;
using System.Collections.Generic;

namespace _8.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string cmd;

            int numOfPassedCars = 0;

            Queue<string> carsQueue = new Queue<string>();

            while ((cmd = Console.ReadLine()) != "end")
            {
                if (cmd == "green" && carsQueue.Count > 0)
                {
                    if (carsQueue.Count < n)
                    {
                        int numberOfCarsWaiting = carsQueue.Count;
                        for (int i = 0; i < numberOfCarsWaiting; i++)
                        {
                            Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                            numOfPassedCars++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                            numOfPassedCars++;
                        }
                    }
                }
                else if (cmd != "green")
                {
                    carsQueue.Enqueue(cmd);
                }
            }

            Console.WriteLine($"{numOfPassedCars} cars passed the crossroads.");
        }
    }
}

