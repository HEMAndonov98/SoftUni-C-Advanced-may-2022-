using System;
using System.Diagnostics;

namespace Recursive_InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            Console.WriteLine("Enter the length you want for your random array");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the max value for a single element in the array(Only Positive Integers!!!)");
            var nums = CreateRandomArray(length, int.Parse(Console.ReadLine()));
            watch.Start();
            InsertionSort(nums);
            watch.Stop();

            Console.WriteLine($"Time elapsed {watch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Time elapsed {watch.ElapsedMilliseconds / 1000} s");
            decimal minutes = (watch.ElapsedMilliseconds / 1000) / 60;
            Console.WriteLine($"Time elapsed {minutes} minutes");
        }

        public static void InsertionSort(int[] arr)
        {
            InsertionSort(arr, 1);
        }

        public static void InsertionSort(int[] arr, int keyIndex)
        {
            if (keyIndex > arr.Length - 1) return;
            InsertKey(arr, arr[keyIndex], keyIndex - 1);
            Console.WriteLine($"Current Array {string.Join(' ', arr)}");
            InsertionSort(arr, keyIndex + 1);

        }

        private static void InsertKey(int[] arr, int key, int currentIndex)
        {

            if (currentIndex < 0 || arr[currentIndex] < key) return;

            arr[currentIndex + 1] = arr[currentIndex];
            arr[currentIndex] = key;

            Console.WriteLine($"Switched {key} with {arr[currentIndex + 1]}");

            InsertKey(arr, key, currentIndex - 1);

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

