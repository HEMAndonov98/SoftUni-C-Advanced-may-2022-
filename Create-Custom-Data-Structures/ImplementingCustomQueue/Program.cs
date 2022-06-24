using System;

namespace ImplementingCustomQueue
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var myQueue = new CustomQueue<char>();
            myQueue.Enqueue('D');
            myQueue.Enqueue('C');
            myQueue.Enqueue('B');
            myQueue.Enqueue('A');
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Peek());
            myQueue.Clear();
            myQueue.Enqueue('D');
            myQueue.Enqueue('C');
            myQueue.Enqueue('B');
            myQueue.Enqueue('A');
            Action<char> print = letter => Console.WriteLine(letter);
            myQueue.ForEach(print);

        }
    }
}

