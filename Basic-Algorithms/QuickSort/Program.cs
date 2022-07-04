using System;
using System.Diagnostics;

namespace QuickSort
{
    public class QuickSort
    {
        public static void Sort<T>(T[] a) where T : IComparable<T>
        {
            Sort(a, 0, a.Length - 1);
        }
        private static void Sort<T>(T[] a, int lo, int hi) where T : IComparable<T>
        {
            if (lo >= hi)
                return;
            int p = Partition(a, lo, hi);
            Sort(a, lo, p - 1);
            Sort(a, p + 1, hi);
        }

        private static int Partition<T>(T[] a, int lo, int hi) where T : IComparable<T>
        {
            var pivot = a[hi];
            int i = lo - 1;

            for (int j = lo; j <= hi; j++)
            {
                if (IsLess(a[j], pivot))
                {
                    i++;
                    Swap(a, i, j);
                }
            }
            Swap(a, i + 1, hi);
            return i + 1;
        }

        private static void Swap<T>(T[] a, int i, int j) where T : IComparable<T>
        {
            var temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        private static bool IsLess<T>(T t1, T t2) where T : IComparable<T>
        {
            int firstVal = Convert.ToInt32(t1);
            int secondVal = Convert.ToInt32(t2);
            return firstVal < secondVal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            var arr = CreateRandomArray(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            watch.Start();
            QuickSort.Sort(arr);
            watch.Stop();
            Console.WriteLine(String.Join(' ', arr));
            Console.WriteLine($"Time elapsed: {watch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Time elapsed: {watch.ElapsedMilliseconds / 1000} s");
        }

        public static int[] CreateRandomArray(int length, int maxElementValue)
        {
            var array = new int[length];
            var random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, maxElementValue + 1);
            }

            return array;
        }
    }
}

