using System;

namespace CustomDoublyLinkedList
{
	public class DoublyLinkedList<T>
	{
        private class ListNode
        {
            public ListNode(T data)
            {
                this.Data = data;
                this.Next = null;
                this.Previous = null;
            }

            public T Data { get; set; }
            public ListNode Next { get; set; }
            public ListNode Previous { get; set; }
        }
        private ListNode head;
        private ListNode tail;


        public int Count { get; private set; }

        public void AddFirst(T element)
        {
            var newNode = new ListNode(element);

            if (this.Count == 0)
            {
                this.head = this.tail = newNode;
            }
            else
            {
                var oldHead = this.head;
                this.head = newNode;
                oldHead.Previous = newNode;
                newNode.Next = oldHead;
            }
            this.Count++;
        }
        public void AddLast(T element)
        {
            var newNode = new ListNode(element);
            if (this.Count == 0)
            {
                this.head = this.tail = newNode;
            }
            else
            {
                var oldTail = this.tail;
                this.tail = newNode;
                oldTail.Next = newNode;
                newNode.Previous = oldTail;
            }
            this.Count++;
        }
        public T RemoveFirst()
        {
            if (this.Count == 0)
                throw new InvalidOperationException("The list is empty.");

            var firstNode = this.head;
            this.head = this.head.Next;

            if (this.head != null)
                this.head.Previous = null;
            else if (this.head == null)
            {
                this.tail = null;
            }
            this.Count--;
            return firstNode.Data;
        }
        public T RemoveLast()
        {
            if (this.Count == 0)
                throw new InvalidOperationException("The list is empty.");

            var lastNode = this.tail;
            this.tail = this.tail.Previous;
            if (this.tail != null)
            {
                this.tail.Next = null;
            }
            else if (this.tail == null)
            {
                this.head = null;
            }
            this.Count--;
            return lastNode.Data;
        }
        public void ForEach(Action<T> action)
        {
            var currentNode = this.head;
            while (currentNode != null)
            {
                action(currentNode.Data);
                currentNode = currentNode.Next;
            }
        }
        public T[] ToArray()
        {
            T[] nodes = new T[this.Count];
            int index = 0;
            //FillArray(this.head, nodes, index);

            //intuitive way
            var currentNode = this.head;
            while (currentNode != null)
            {
                nodes[index++] = currentNode.Data;
                currentNode = currentNode.Next;
            }
            return nodes;
        }

        public void Print()
        {
            Console.WriteLine($"This is the head of the list: {this.head.Data}");
            Console.WriteLine($"This is next to the head: {(this.Count > 1 ? this.head.Next.Data.ToString() : "null")}");
            Console.WriteLine($"This is the tail of the list {this.tail.Data}");
            Console.WriteLine($"The current count is {this.Count}");

            Console.WriteLine("This is the whole list:");
            PrintLList(this.head);
            

        }

        private void PrintLList(ListNode head)
        {
            var currentNode = head;
            if (currentNode == null)
            {
                return;
            }
            Console.Write($"| {currentNode.Data} |");
            PrintLList(currentNode.Next);
        }
        //Recursive way
        private void FillArray(ListNode head, T[] nodes, int index)
        {
            if (head == null)
            {
                return;
            }
            var currentNode = head;
            nodes[index++] = currentNode.Data;
            FillArray(currentNode.Next, nodes, index);
        }
    }
}

