using System;
using System.Collections.Generic;
using System.Text;

namespace _4.GenericSwapMethodIntegers
{
    public class Box<T>
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

    }
}

