using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Array
{
    public class ArrayProblems
    {
        /// <summary>
        /// Write a function rotate(ar[], d) that rotates arr[] by x elements.
        /// Using temp array.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="x"></param>
        public static void RotateArrayByxElements(int[] arr, int x)
        {
            // If rotation number is > array length then find the modulus and only rotate by that number.
            if (x > arr.Length)
            {
                x = x % arr.Length;
            }

            int[] tempArray = new int[x];
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = arr[arr.Length - 1 - i];
            }

            for (int i = arr.Length - 1 - x; i >= 0; i--)
            {
                arr[i + x] = arr[i];
            }

            for (int i = 0; i < tempArray.Length; i++)
            {
                arr[x - i - 1] = tempArray[i];
            }
        }

        /// <summary>
        /// Given an array A[] and a number x, check for pair in A[] with sum as x.
        /// 
        /// Approach 1:
        /// The naive way to do this would be to check all combinations(n choose 2). This exhaustive search is O(n2).
        /// Not implementing it here.
        /// 
        /// Approach 2:  
        /// A better way would be to sort the array.This takes O(n log n)
        /// Then for each x in array A, use binary search to look for T-x.This will take O(nlogn).
        /// So, overall search is  O(n log n)
        /// </summary>
        public static bool FindIfPairExistForSumXUsingSorting(int[] arr, int x)
        {
            // Sort the 
            QuickSort.SortIterative(arr);
            int startIndex = 0;
            int endIndex = arr.Length - 1;

            while (startIndex < endIndex)
            {
                int sum = arr[startIndex] + arr[endIndex];
                if (sum == x)
                    return true;
                else
                {
                    if (sum > x)
                    {
                        endIndex--;
                    }
                    else
                    {
                        startIndex++;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Given an array A[] and a number x, check for pair in A[] with sum as x.
        /// 
        /// Approach 3 : 
        /// The best way would be to insert every element into a hash table(without sorting). This takes O(n) as constant time insertion.
        /// Then for every x, we can just look up its complement, T-x, which is O(1).
        /// Overall the run time of this approach is O(n).
        /// </summary>
        public static bool FindIfPairExistForSumXUsingHashing(int[] arr, int x)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                dict.Add(arr[i], arr[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int value = x - arr[i];
                if (dict.ContainsKey(value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
