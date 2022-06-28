using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _3.Stack
{
	public class MyStack<T> : IEnumerable<T>
	{
        private List<T> data;

		public MyStack(params T[] values)
		{
            this.data = values.ToList();
		}

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.data.Count - 1; i >= 0; i--)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Push(T element)
        {
            this.data.Add(element);
        }

        public T Pop()
        {
            try {
                var removed = this.data[this.data.Count - 1];
                this.data.RemoveAt(this.data.Count - 1);
                return removed;
                }
            catch
            {
                Console.WriteLine("No elements");
                return default;
            }
        }
    }
}

