using System;
using System.Linq;
using System.Text;

namespace ImplementingList
{
	public class MyList<T>
	{
        public MyList()
        {
            this.values = new T[initalCapacity];
        }


		private T[] values;
        private const int initalCapacity = 2;
        public int Count { get; private set; }

        private T this[int index]
        {
            get
            {
                if (ValidateIndex(index))
                    return this.values[index];
                throw new ArgumentOutOfRangeException("Outside the bounds of the list.");
            }
            set
            {
                if (!ValidateIndex(index))
                {
                    throw new ArgumentOutOfRangeException("Outside the bounds of the list.");
                }
                this.values[index] = value;
            }
        }

        public void Add(T item)
        {
            if (this.Count == this.values.Length)
                this.Resize();
            this.values[this.Count++] = item;
        }
        public T RemoveAt(int index)
        {
            if (!ValidateIndex(index))
                throw new ArgumentOutOfRangeException("Outside bounds of the list");

            var removedItem = this.values[index];
            this.values[index] = default;
            this.Shift(index);

            this.Count--;
            if (this.Count <= this.values.Length / 4)
                this.Shrink();
            return removedItem;
        }
        public void Insert(int index, T item)
        {
            if (!ValidateIndex(index))
                throw new ArgumentOutOfRangeException("Index out of range");
            if (this.Count == this.values.Length)
                this.Resize();
            this.ShiftToRight(index);
            this.values[index] = item;
            this.Count++;
        }
        public bool Containes(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.values[i].Equals(item))
                    return true;
            }
            return false;
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            if (!ValidateIndex(firstIndex))
                throw new ArgumentOutOfRangeException();
            if (!ValidateIndex(secondIndex))
                throw new ArgumentOutOfRangeException();

            T temp = this.values[firstIndex];
            this.values[firstIndex] = this.values[secondIndex];
            this.values[secondIndex] = temp;
        }
        public string ToString(string separator)
        {
            string[] strings = new string[this.Count];
            for (int i = 0; i < this.Count; i++)
            {
                strings[i] = this.values[i].ToString();
            }

            var sb = new StringBuilder();
            sb.Append(strings[0]);
            for (int i = 1; i < strings.Length; i++)
            {
                sb.Append(separator);
                sb.Append(strings[i]);
            }
            return sb.ToString();
        }


        private bool ValidateIndex(int index)
        {
            if (index >= 0 && index < this.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Resize()
        {
            T[] copy = new T[this.values.Length * 2];

            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = values[i];
            }
            this.values = copy;
        }
        private void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.values[i] = this.values[i + 1];
            }
        }
        private void ShiftToRight(int index)
        {
            for (int i = this.Count; i > index; i--)
            {
                this.values[i] = this.values[i - 1];
            }
        }
        private void Shrink()
        {
            T[] copy = new T[this.values.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.values[i];
            }

            this.values = copy;
        }


    }
}
