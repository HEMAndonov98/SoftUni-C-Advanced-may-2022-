using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1.ListyIterator
{
	public class ListyIterator<T> : IEnumerable<T>
	{
		private readonly List<T> values;
		private int index;

		public ListyIterator(params T[] elements)
		{
			this.values = elements.ToList();
			this.index = 0;
		}

		public bool Move()
        {
            if (this.index + 1 < this.values.Count)
            {
				this.index++;
				return true;
            }
			return false;
        }

		public bool HasNext()
        {
			return this.index + 1 < this.values.Count ? true : false;
        }

		public void Print()
        {
            try { Console.WriteLine(this.values[index]); }
            catch { Console.WriteLine("Invalid Operation!"); }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.values.Count; i++)
            {
                yield return this.values[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

