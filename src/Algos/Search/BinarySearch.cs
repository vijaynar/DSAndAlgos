/*
Reference:

Summary:

Time Complexity:
Average = O(?).
Worst = O(?).

Space Complexity = O(?)
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Search
{
    public class BinarySearch
    {
        public static int Search(int[] arr, int item)
        {
            if (arr == null)
                return -1;

            return Search(arr, item, 0, arr.Length - 1);
        }

        private static int Search(int[] arr, int item, int left, int right)
        {
            if (right > left)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == item)
                {
                    return mid;
                }
                else
                {
                    if (arr[mid] > item)
                    {
                        return Search(arr, item, left, mid);
                    }
                    else
                    {
                        return Search(arr, item, mid + 1, right);
                    }
                }
            }
            return -1;
        }
    }
}
