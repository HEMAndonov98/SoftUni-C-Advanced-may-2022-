
using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();
            for (int i = 0; i < n; i++)
            {
                int[] pumpParams = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                pumps.Enqueue(pumpParams);
            }

            for (int i = 0; i < n; i++)
            {
                int totalLiters = 0;
                bool startIsFound = true;

                Queue<int[]> pumpsCopy = new Queue<int[]>(pumps);

                for (int j = 0; j < n; j++)
                {
                    var pump = pumpsCopy.First();

                    int liters = pump[0];
                    int distance = pump[1];

                    totalLiters += liters;

                    if (totalLiters >= distance)
                    {
                        totalLiters -= distance;
                        pumpsCopy.Enqueue(pumpsCopy.Dequeue());
                    }
                    else
                    {
                        startIsFound = false;
                        pumps.Enqueue(pumps.Dequeue());
                        break;
                    }
                }

                if (startIsFound)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}

//4
//1 1
//1 5
//1 1
//5 1