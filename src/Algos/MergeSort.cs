using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    /// <summary>
    /// Mergesort is a comparison-based algorithm that focuses on how to merge together two pre-sorted arrays such that the resulting array is also sorted.
    /// It is a sorting technique based on divide and conquer technique. With worst-case time complexity being Ο(n log n), 
    /// it is one of the most respected algorithms.
    /// Merge sort first divides the array into equal halves and then combines them in a sorted manner.
    /// Average complexity is O(NlogN).
    /// </summary>
    public class MergeSort
    {
        public void SortRecursively(int[] arr, int low, int high)
        {

            if (low < high)
            {
                int mid = (low + high) / 2;
                SortRecursively(arr, low, mid);
                SortRecursively(arr, mid + 1, high);
                Merge(arr, low, mid, high);
            }
        }

        public void SortIteratively(int[] arr)
        {
            if (arr == null)
                return;

        }
        private void Merge(int[] arr, int low, int mid, int high)
        {
            int start = low;
            int end = high;
            int[] tempArr = new int[high - low + 1];
            //while(low<mid+1 && )
            for (int i = low; i < high; i++)
            {
                if (arr[i] < arr[mid+1])
                {
                    i++;
                }
            }
        }
    }
}
