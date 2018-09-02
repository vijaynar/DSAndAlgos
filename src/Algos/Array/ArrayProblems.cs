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
        /// </summary>
        /// <returns></returns>
        public static bool FindIfPairExistForSumX(int[] arr, int d)
        {

            return true;
        }
    }
}
