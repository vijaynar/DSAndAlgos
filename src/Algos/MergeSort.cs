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
        public static void SortRecursively(int[] arr, int low, int high)
        {

            if (low < high)
            {
                int mid = (low + high) / 2;
                SortRecursively(arr, low, mid);
                SortRecursively(arr, mid + 1, high);
                Merge(arr, low, mid, high);
                //MergeWithLessExtraSpace(arr, low, mid, high);
            }
        }

        public static void SortIteratively(int[] arr)
        {
            if (arr == null)
                return;

            throw new NotImplementedException();
        }
        private static void Merge(int[] arr, int low, int mid, int high)
        {
            int arr1Start = low;
            int arr2Start = mid + 1;
            int i = 0;

            int[] tempArr = new int[high - low + 1];

            // While both arrays are empty compare and fill temp array.
            while (arr1Start <= mid && arr2Start <= high)
            {
                if (arr[arr1Start] < arr[arr2Start])
                {
                    tempArr[i++] = arr[arr1Start++];
                }
                else
                {
                    tempArr[i++] = arr[arr2Start++];
                }
            }

            // Fill up remaining items from arr1 to temp array.
            while (arr1Start <= mid)
            {
                tempArr[i++] = arr[arr1Start++];
            }

            // Fill up remaining items from arr2 to temp array.
            while (arr2Start <= high)
            {
                tempArr[i++] = arr[arr2Start++];
            }

            // Fill up original array again.
            for (int j = 0; j < tempArr.Length; j++)
            {
                arr[low + j] = tempArr[j];
            }
        }

        private static void MergeWithLessExtraSpace(int[] arr, int low, int mid, int high)
        {
            // Create another array to store elements from mid to high.
            int[] arr2 = new int[high - mid];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = arr[mid + 1 + i];
            }

            // Now we have two sorted arrays where array(arr) has enough space to store all elements.
            int arr1EndIndex = mid;
            int arr2EndIndex = arr2.Length - 1;
            int arr1MergeIndex = high;

            // While arr2 is empty or arr1 first element is arr2 first element process element.
            while (arr2EndIndex >= 0 && arr1EndIndex - low >= 0)
            {
                if (arr2[arr2EndIndex] > arr[arr1EndIndex])
                {
                    arr[arr1MergeIndex--] = arr2[arr2EndIndex--];
                }
                else
                {
                    arr[arr1MergeIndex--] = arr[arr1EndIndex--];
                }
            }

            // If arr2 is not processed because of arr1 first element is arr2 first element
            // then fill loop through arr2 remaining element and fill arr1.
            if (arr2EndIndex >= 0)
            {
                for (int i = arr2EndIndex; i >= 0; i--)
                {
                    arr[arr1MergeIndex--] = arr2[arr2EndIndex--];
                }
            }
        }

        private static void MergeWithO1ExtraSpace(int[] arr, int low, int mid, int high)
        {

        }
    }
}
