using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.GenericCountMethodStrings 
{
    public class Box<T> : IComparable<T> where T : IComparable<T>
	{
		private T value;

		public Box(T value)
		{
			this.value = value;
		}

        public Box(List<T> elements)
        {
            this.Data = elements;
        }

        public List<T> Data { get; private set; }
        public int CompareCount(List<T> elements, T readline)
        {
            return elements.Count(e => e.CompareTo(readline) > 0);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var item in this.Data)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

			return sb.ToString();
        }
        public void Swap(List<T> list, int firstIndex, int secondIndex)
        {
            var temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }
        public int CompareTo(T other)
        {
            return other.CompareTo(other);
        }
    }
}

