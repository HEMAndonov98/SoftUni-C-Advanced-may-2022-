using System;
namespace ImplementCustomStack
{
	public class MyStack<T>
	{
        public MyStack()
        {
			this.data = new T[initialCapacity];
			this.Count = 0;
        }
		const int initialCapacity = 4;
		private T[] data;
        public int Count { get; private set; }

		public void Push(T element)
        {
            if (this.Count == this.data.Length)
                Resize();
            this.data[this.Count++] = element;
        }
        public T Pop()
        {
            if (this.Count == 0)
                throw new ArgumentOutOfRangeException();

            var element = this.data[--this.Count];
            this.data[this.Count] = default;
            return element;
        }
        public T Peek()
        {
            if (this.Count - 1 < 0)
                throw new ArgumentOutOfRangeException();
            var element = this.data[this.Count - 1];
            return element;
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
    }
}

