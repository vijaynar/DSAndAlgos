using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    /// <summary>
    /// Quick Sort in its general form is an in-place sort.
    /// Quicksort is a comparison-based algorithm that uses divide-and-conquer to sort an array.
    /// The algorithm picks a pivot element, A[q], and then rearranges the array into two subarrays A[p...q-1], 
    /// such that all elements are less than A[q], and A[q+1...r], such that all elements are greater than or equal to A[q].
    /// Average complexity is O(NlogN).
    /// </summary>
    public class QuickSort
    {
        public static void SortRecursive(int[] arr, int low, int high)
        {
            if (arr == null)
                return;

            if (low < high)
            {
                int pi = Partition(arr, low, high);
                SortRecursive(arr, low, pi - 1);
                SortRecursive(arr, pi + 1, high);
            }
        }

        public static void SortIterative(int[] arr)
        {
            if (arr == null)
                return;

            Stack<int> stack = new Stack<int>();

            // Push low & high index of arr in stack.
            stack.Push(arr.Length - 1);
            stack.Push(0);

            do
            {
                int low = stack.Pop();
                int high = stack.Pop();
                if(low<high)
                {
                    int pi = Partition(arr, low, high);
                    if (pi > 1)
                    {
                        stack.Push(pi - 1);
                        stack.Push(low);
                    }
                    if (pi < arr.Length - 1)
                    {
                        stack.Push(high);
                        stack.Push(pi + 1);
                    }
                }
            }
            while (stack.Count > 0);
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int j = low - 1;
            for (int i = low; i < high; i++)
            {
                if (arr[i] < pivot)
                {
                    j++;
                    Helper.Swap(arr, i, j);
                }
            }

            Helper.Swap(arr, j + 1, high);
            return j + 1;
        }

        public static void SortIterativeWithTwoMarkersPartition(int[] arr)
        {
        }

        /// <summary>
        /// In 3 Way QuickSort, an array arr[l..r] is divided in 3 parts:
        /// a) arr[l..i] elements less than pivot.
        /// b) arr[i + 1..j - 1] elements equal to pivot.
        /// c) arr[j..r] elements greater than pivot.
        /// Consider an array which has many redundant elements. For example, {1, 4, 2, 4, 2, 4, 1, 2, 4, 1, 2, 2, 2, 2, 4, 1, 4, 4, 4}. If 4 is picked as pivot in Simple QuickSort, we fix only one 4 and recursively process remaining occurrences.
        /// The idea of 3 way QuickSort is to process all occurrences of pivot and is based on Dutch National Flag algorithm.
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort_3_Way(int[] arr)
        {
        }
    }
}
