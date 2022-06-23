using System;

namespace CustomDoublyLinkedList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //The List works with generics <T>
            var customList = new DoublyLinkedList<char>();
            //Try all the mothods

            //customList.AddFirst('A');

            //customList.AddLast('B');

            //customList.RemoveFirst();

            //customList.RemoveLast();

            //char[] chars = customList.ToArray();

            //Action<char> PrintNodes = msg => Console.WriteLine(msg);
            //customList.ForEach(PrintNodes);
        }
    }
}

