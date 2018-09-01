/*
Reference:
https://www.hackerearth.com/practice/algorithms/sorting/bucket-sort/tutorial/

Summary:
Bucket sort is a comparison sort algorithm that operates on elements by dividing them into different buckets and then sorting these buckets individually. Each bucket is sorted individually using a separate sorting algorithm or by applying the bucket sort algorithm recursively. Bucket sort is mainly useful when the input is uniformly distributed over a range.

Bucket sort breaks a list down into sub-lists, you can then use another algo to sort the sub-lists
Bucketsort isn't a good choice if you don't know the range or distribution of the data
Bucket Sort time complexity
 
In this case, we will focus on building an algorithm that uses bucketsort to sort an array of integers between 1 and 99
we will also assume that the integers in the passed array are evenly distributed

Time Complexity:
Average = O(n+k) - k being the number of buckets that were created.
Worst = O(N^2).

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

            int bucketSize = 10;
            List<int>[] buckets = new List<int>[bucketSize];
            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new List<int>();
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int bucketNo = arr[i] / bucketSize;
                buckets[bucketNo].Add(i);
            }

            for (int i = 0; i < buckets.Length; i++)
            {
                QuickSort.SortIterative(buckets[i].ToArray());
            }
        }

        public static void SortRecursive(int[] arr, int n)
        {
            if (arr == null)
                return;
        }
    }
}
