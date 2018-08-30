/*
https://www.programiz.com/dsa/heap-sort
Application of Heap Sort:
Systems concerned with security and embedded system such as Linux Kernel uses Heap Sort because of the O(n log n) upper bound
on Heapsort's running time and constant O(1) upper bound on its auxiliary storage.

Although Heap Sort has O(n log n) time complexity even for worst case, it doesn’t have more applications 
( compared to other sorting algorithms like Quick Sort, Merge Sort ). 
However, its underlying data structure, heap, can be efficiently used if we want to extract smallest (or largest) from 
the list of items without the overhead of keeping the remaining items in the sorted order. For e.g Priority Queues.

Average complexity is O(?).
Worst complexity is O(?).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    /// <summary>
    /// 
    /// 
    /// </summary>
    public class HeapSort
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
