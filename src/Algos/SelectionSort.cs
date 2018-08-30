/*
Reference:
https://www.programiz.com/dsa/selection-sort

Summary:
Selection sort algorithm starts by compairing first two elements of an array and swapping if necessary, i.e., if you want to sort the elements of 
array in ascending order and if the first element is greater than second then, you need to swap the elements but, if the first element is smaller 
than second, leave the elements as it is. Then, again first element and third element are compared and swapped if necessary. This process goes on 
until first and last element of an array is compared. This completes the first step of selection sort.

If there are n elements to be sorted then, the process mentioned above should be repeated n-1 times to get required result. But, for better 
performance, in second step, comparison starts from second element because after first step, the required number is automatically placed at the 
first (i.e, In case of sorting in ascending order, smallest element will be at first and in case of sorting in descending order, largest element 
will be at first.). Similarly, in third step, comparison starts from third element and so on.

Time Complexity:
Average = O(n2).
Worst = O(n2).

Space Complexity = O(1)
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    /// <summary>
    /// The selection sort algorithm sorts an array by repeatedly finding the minimum element (considering ascending order) from unsorted part and 
    /// putting it at the beginning. The algorithm maintains two subarrays in a given array.
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

            
            for(int i=0;i<arr.Length-1;i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        Helper.Swap(arr, i, j);
                    }
                }
            }

        }

        public static void SortRecursive(int[] arr, int n)
        {
            if (arr == null)
                return;
        }
    }
}
