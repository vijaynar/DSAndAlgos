using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    /// <summary>
    /// Bubble sort is a comparison​-based algorithm that compares each pair of elements in an array and swaps them if they are out of order 
    /// until the entire array is sorted.
    /// For each element in the list, the algorithm compares every pair of elements.
    /// Average complexity is O(NlogN).
    /// </summary>
    public class BubbleSort
    {
        public static void SortIterative(int[] arr)
        {
            if (arr == null)
                return;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Helper.Swap(arr, j, j + 1);
                    }
                }
            }
        }

        public static void SortRecursive(int[] arr, int n)
        {
            if (arr == null)
                return;

            if (n == 1)
                return;

            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    Helper.Swap(arr, i, i + 1);
                }
            }

            SortRecursive(arr, --n);
        }
    }
}
