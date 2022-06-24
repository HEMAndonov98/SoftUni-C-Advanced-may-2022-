using System;
namespace ImplementingCustomQueue
{
	public class CustomQueue<T>
	{
        public CustomQueue()
        {
            this.data = new T[initialCapacity];
            this.Count = 0;
        }

		const int initialCapacity = 4;
		private T[] data;

        public int Count { get; private set; }

        public void Enqueue(T element)
        {
            if (this.Count == this.data.Length)
                Resize();
            ShiftToRight();
            this.data[0] = element;
            this.Count++;

        }
        public T Dequeue()
        {
            var element = this.data[0];
            this.data[0] = default;
            this.Count--;
            ShiftToLeft();
            return element;
        }
        public T Peek()
        {
            if (this.Count == 0)
                throw new ArgumentOutOfRangeException();
            return this.data[0];
        }
        public void Clear()
        {
            this.data = new T[initialCapacity];
            this.Count = 0;
        }
        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                action(this.data[i]);
            }
        }

        private void Resize()
        {
            T[] copy = new T[this.data.Length * 2];

            for (int i = 0; i < this.data.Length; i++)
            {
                copy[i] = data[i];
            }
            this.data = copy;
        }
        private void ShiftToRight()
        {
            for (int i = this.Count; i > 0; i--)
            {
                this.data[i] = this.data[i - 1];
            }
        }
        private void ShiftToLeft()
        {
            for (int i = 0; i < this.Count; i++)
            {
                this.data[i] = this.data[i + 1];
            }
        }
    }
}

