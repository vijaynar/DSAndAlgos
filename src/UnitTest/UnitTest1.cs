using System;
using Algos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private int[] arr = { 40, 10, 80, 30, 90, 50, 70 };

        [TestMethod]
        public void Test_quickSort()
        {
            //QuickSort.SortRecursive(arr, 0, arr.Length - 1);
            QuickSort.SortIterative(arr);
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
