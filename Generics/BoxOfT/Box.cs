using System;
using System.Collections.Generic;
using System.Linq;

namespace BoxOfT
{
	public class Box<T>
	{
		private List<T> data;
		private int count => this.data.Count;

		public Box()
		{
			this.data = new List<T>();
		}

		public int Count { get { return count; } }

		public void Add(T element)
        {
			this.data.Add(element);
        }
		public T Remove()
        {
            if (this.Count == 0)
				throw new ArgumentOutOfRangeException();

			var element = this.data.Last();
			this.data.RemoveAt(this.Count - 1);
			return element;
        }
	}
}

