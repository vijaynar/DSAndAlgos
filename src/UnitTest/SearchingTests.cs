using System;
using System.Linq;
using Algos;
using Algos.Search;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class SearchingTests
    {
        //private int[] arr = { 40, 10, 80, 30, 90, 50, 70, 76, 57, 81, 16, 39, -23, -908, -1 };
        private int[] arr = { 30, 40, 50, 60, 70, 80, 90, 100, 200, 300};

        [TestMethod]
        public void Test_LinearSearch()
        {
            int s = LinearSearch.Search(arr, 30);
            s = LinearSearch.Search(arr, -10);
        }

        [TestMethod]
        public void Test_BinarySearch()
        {
            QuickSort.SortIterative(arr);
            int s = BinarySearch.Search(arr, 70);
            s = BinarySearch.Search(arr, -10);
        }
    }
}
