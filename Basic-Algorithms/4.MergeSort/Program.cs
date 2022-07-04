using System;
using System.Linq;

namespace _4.MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray() ;
            Sort(nums, 0, nums.Length - 1);
            Console.WriteLine(String.Join(' ', nums));
        }
        public static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                Sort(arr, left, middle);
                Sort(arr, middle + 1, right);
                Merge(arr, left, middle, right);
            }
        }

        private static void Merge(int[] aux, int left, int mid, int right)
        {
            int[] leftArr = new int[mid - left + 1];
            int[] rightArr = new int[right - mid];

            Array.Copy(aux, left, leftArr, 0, mid - left + 1);
            Array.Copy(aux, mid + 1, rightArr, 0, right - mid);

            int i = 0; //left array index
            int j = 0; //right array index

            for (int k = left; k <= right; k++) //k is the main array index
            {
                if (i == leftArr.Length)
                {
                    aux[k] = rightArr[j];
                    j++;
                }
                else if (j == rightArr.Length)
                {
                    aux[k] = leftArr[i];
                    i++;
                }
                else if (leftArr[i] <= rightArr[j])
                {
                    aux[k] = leftArr[i];
                    i++;
                }
                else
                {
                    aux[k] = rightArr[j];
                    j++;
                }
            }
        }
    }
}

