using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    /// <summary>
    /// The selection sort algorithm sorts an array by repeatedly finding the minimum element (considering ascending order) from unsorted part and putting it at the beginning. The algorithm maintains two subarrays in a given array.
    /// 1) The subarray which is already sorted.
    /// 2) Remaining subarray which is unsorted.
    /// In every iteration of selection sort, the minimum element(considering ascending order) from the unsorted subarray is picked and moved to the sorted subarray.
    /// Average complexity is O(N2).
    /// </summary>
    public class SelectionSort
    {
        public static void SortIterative(int[] arr)
        {
            if (arr == null)
                return;

            
            for(int i=0;i<arr.Length;i++)
            {
                int min = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                Helper.Swap(arr, i, j);
            }

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
