using System;
namespace _2.GenericBoxOfInteger
{
    public class Box<T>
	{
		private T value;

		public Box(T value)
		{
			this.value = value;
		}

        public override string ToString()
        {
			return $"{typeof(T)}: {value}";
        }
    }
}

