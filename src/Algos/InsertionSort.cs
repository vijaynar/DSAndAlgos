/*
Reference:
https://www.programiz.com/dsa/insertion-sort

Summary:
Step 1: The second element of an array is compared with the elements that appears before it (only first element in this case). If the second element is smaller than first element, second element is inserted in the position of first element. After first step, first two elements of an array will be sorted.
Step 2: The third element of an array is compared with the elements that appears before it (first and second element). If third element is smaller than first element, it is inserted in the position of first element. If third element is larger than first element but, smaller than second element, it is inserted in the position of second element. If third element is larger than both the elements, it is kept in the position as it is. After second step, first three elements of an array will be sorted.
Step 3: Similary, the fourth element of an array is compared with the elements that appears before it (first, second and third element) and the same procedure is applied and that element is inserted in the proper position. After third step, first four elements of an array will be sorted.

Time Complexity:
Average = O(?).
Worst = O(?).

Space Complexity = O(?)
*/

namespace Algos
{
    /// <summary>
    /// Insertion sort is a comparison-based algorithm that builds a final sorted array one element at a time. 
    /// It iterates through an input array and removes one element per iteration, finds the place the element belongs in the array, and then places it there.
    /// Average complexity is O(NlogN).
    /// </summary>
    public class InsertionSort
    {
        public static void SortIterative(int[] arr)
        {
            if (arr == null)
                return;

            ////for (int i = 0; i < arr.Length; i++)
            ////{
            ////    if (arr[i] > arr[j])
            ////    {
            ////        Helper.Swap(arr, i, j);
            ////    }
            ////}
        }

        public static void SortRecursive(int[] arr, int n)
        {
            if (arr == null)
                return;

            if (n <= 1)
                return;

            SortRecursive(arr, n - 1);

            int last = arr[n - 1];
            int j = n - 2;
            while (j >= 0 && last < arr[j])
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = last;
        }
    }
}
