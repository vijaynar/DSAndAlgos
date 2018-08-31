/*
Reference:
https://www.hackerearth.com/practice/algorithms/sorting/bucket-sort/tutorial/

Summary:
Bucket sort is a comparison sort algorithm that operates on elements by dividing them into different buckets and then sorting these buckets individually. Each bucket is sorted individually using a separate sorting algorithm or by applying the bucket sort algorithm recursively. Bucket sort is mainly useful when the input is uniformly distributed over a range.

Time Complexity:
Average = O(?).
Worst = O(?).

Space Complexity = O(?)
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    /// <summary>
    /// 
    /// </summary>
    public class BucketSort
    {
        public static void SortIterative(int[] arr)
        {
            if (arr == null)
                return;
        }

        public static void SortRecursive(int[] arr, int n)
        {
            if (arr == null)
                return;
        }
    }
}
