using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public  class Library : IEnumerable<Book>
	{
        private List<Book> books;

        public Library(params Book[] books)
		{
            this.books = books.ToList();
		}

        //syntax sugar
        //public IEnumerator<Book> GetEnumerator()
        //{
        //    for (int i = 0; i < this.books.Count; i++)
        //    {
        //        yield return this.books[i];
        //    }
        //IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        //Use the methods below if you're using a custom iterator


        public IEnumerator<Book> GetEnumerator() => new LibraryIterator(this.books);
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        //This is the method using a custom iterator
        public  class LibraryIterator : IEnumerator<Book> 
        {

        private readonly List<Book> books;
        private int index;

        public LibraryIterator(IEnumerable<Book> books)
        {
                Reset();
                this.books = books.ToList();
        }

        public Book Current => this.books[this.index];

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
        }

        public bool MoveNext() => ++this.index < this.books.Count;

        public void Reset() => this.index = -1;
        }
    }

}

