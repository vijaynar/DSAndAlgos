/*
Reference:
https://www.programiz.com/dsa/heap-sort
https://www.hackerearth.com/practice/algorithms/sorting/heap-sort/tutorial/

Summary:
Relationship between array indexes and tree elements:
Complete binary tree has an interesting property that we can use to find the children and parents of any node.
If the index of any element in the array is i, the element in the index 2i+1 will become the left child and element in 2i+2 index will become 
the right child. Also, the parent of any element at index i is given by the lower bound of (i-1)/2.

What is Heap Data Structure ?
Heap is a special tree-based data structure. A binary tree is said to follow a heap data structure if
1) it is a complete binary tree
2) All nodes in the tree follow the property that they are greater than their children i.e. 
the largest element is at the root and both its children and smaller than the root and so on.
Such a heap is called a max-heap. If instead all nodes are smaller than their children, it is called a min-heap

Procedures to follow for Heapsort:
1) Since the tree satisfies Max-Heap property, then the largest item is stored at the root node.
2) Remove the root element and put at the end of the array (nth position) Put the last item of the tree (heap) at the vacant place.
3) Reduce the size of the heap by 1 and heapify the root element again so that we have highest element at root.
4) The process is repeated until all the items of the list is sorted.

Application of Heap Sort:
Systems concerned with security and embedded system such as Linux Kernel uses Heap Sort because of the O(n log n) upper bound
on Heapsort's running time and constant O(1) upper bound on its auxiliary storage.

Although Heap Sort has O(n log n) time complexity even for worst case, it doesn’t have more applications 
( compared to other sorting algorithms like Quick Sort, Merge Sort ). 
However, its underlying data structure, heap, can be efficiently used if we want to extract smallest (or largest) from 
the list of items without the overhead of keeping the remaining items in the sorted order. For e.g Priority Queues.

Time Complexity:
Average = O(nlogn).
Worst = O(nlogn).

Space Complexity = O(?)
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

            int n = arr.Length - 1;

            // Build max-heap. To build a max-heap from any tree, we can thus start heapifying each sub-tree from the bottom up
            int nonLeafIndex = n / 2 - 1;
            for (int i = nonLeafIndex; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            // Now as the largest item is stored at the root node. so remove the root element and put at the end of the array.
            // basically Swap root with last node.
            for (int i = n; i >= 0; i--)
            {
                Helper.Swap(arr, 0, i);
                Heapify(arr, i, 0);
            }
        }

        public static void SortRecursive(int[] arr, int n)
        {
            if (arr == null)
                return;
        }

        private static void Heapify(int[] arr, int n, int i)
        {
            if (arr == null)
                return;

            int largest = i;
            int left = i * 2 + 1;
            int right = i * 2 + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                Helper.Swap(arr, i, largest);
                Heapify(arr, n, largest);
            }
        }
    }
}
