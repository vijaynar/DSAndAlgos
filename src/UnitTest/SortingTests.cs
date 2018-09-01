using System;
using System.Linq;
using Algos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class SortingTests
    {
        private int[] arr = { 40, 10, 80, 30, 90, 50, 70, 76, 57, 81, 16, 39, -23, -908, -1 };
        //private int[] arr = { 40, 50, 60, 70, 80, 90, 100, 200, 300};

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
            //MergeSort.SortIterative(arr);
            MergeSort.SortRecursively(arr, 0, arr.Length - 1);
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
            //HeapSort.SortRecursive(arr, arr.Length);
        }

        [TestMethod]
        public void Test_BucketSort()
        {
            BucketSort.SortIterative(arr);
            //HeapSort.SortRecursive(arr, arr.Length);
        }
    }
}
