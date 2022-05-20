using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read input
            Stack<int> clothesStack = new Stack<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int rackCapacity = int.Parse(Console.ReadLine());
            int numOfRacks = 0;

            //Loop until there are no more clothes in the stack
            while (clothesStack.Count > 0)
            {
                int currentRackCap = 0;
                //Take out a new rack.
                numOfRacks++;

                //Loop until the current rack capacity is filled
                while (rackCapacity >= (currentRackCap += clothesStack.Peek()))
                {
                    clothesStack.Pop();

                    if (clothesStack.Count == 0)
                    {
                        break;
                    }
                }
            }
            //Print the number of racks needed to clear the stack
            Console.WriteLine(numOfRacks);
        }
    }
}

