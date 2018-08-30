using System;
using System.Linq;
using Algos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class SortingTests
    {
        private int[] arr = { 40, 10, 80, 30, 90, 50, 70 };

        [TestMethod]
        public void Test_quickSort()
        {
            QuickSort.SortRecursive(arr, 0, arr.Length - 1);
            QuickSort.SortIterative(arr);
        }

        [TestMethod]
        public void Test_BubbleSort()
        {
            //BubbleSort.SortIterative(arr);
            BubbleSort.SortRecursive(arr,arr.Length);
        }

        [TestMethod]
        public void Test_MergeSort()
        {
            //BubbleSort.SortIterative(arr);
            BubbleSort.SortRecursive(arr, arr.Length);
        }

        [TestMethod]
        public void Test_InsertionSort()
        {
            //InsertionSort.SortIterative(arr);
            InsertionSort.SortRecursive(arr, arr.Length);
        }

        [TestMethod]
        public void Test_SelectionSort()
        {
            SelectionSort.SortIterative(arr);
            SelectionSort.SortRecursive(arr, arr.Length);
        }

        [TestMethod]
        public void Test_HeapSort()
        {
            HeapSort.SortIterative(arr);
            HeapSort.SortRecursive(arr, arr.Length);
        }
    }
}
