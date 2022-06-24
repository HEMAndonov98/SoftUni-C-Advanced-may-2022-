using System;

namespace ImplementCustomStack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var myStack = new MyStack<char>();

            myStack.Push('A');
            myStack.Push('B');
            myStack.Push('C');
            Console.WriteLine(myStack.Peek());
            myStack.Pop();
            Action<char> Print = msg => Console.WriteLine(msg);
            myStack.ForEach(Print);
        }
    }
}

