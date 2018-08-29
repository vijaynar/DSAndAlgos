using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    /// <summary>
    /// Insertion sort is a comparison-based algorithm that builds a final sorted array one element at a time. 
    /// It iterates through an input array and removes one element per iteration, finds the place the element belongs in the array, and then places it there.
    /// Average complexity is O(NlogN).
    /// </summary>
    public class InsertionSort
    {
        public static void SortIterative(int[] arr)
        {
            if (arr == null)
                return;

            ////for (int i = 0; i < arr.Length; i++)
            ////{
            ////    if (arr[i] > arr[j])
            ////    {
            ////        Helper.Swap(arr, i, j);
            ////    }
            ////}
        }

        public static void SortRecursive(int[] arr, int n)
        {
            if (arr == null)
                return;

            if (n == 1)
                return;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        Helper.Swap(arr, i, j);
                    }
                }
            }
        }
    }
}
