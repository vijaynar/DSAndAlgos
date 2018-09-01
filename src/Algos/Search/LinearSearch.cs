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
    public class LinearSearch
    {
        public static int Search(int[] arr, int item)
        {
            if (arr == null)
                return -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (item == arr[i])
                    return i;
            }

            return -1;
        }
    }
}
