using System;
using System.Linq;
using Algos;
using Algos.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ArrayTests
    {
        //private int[] arr = { 40, 10, 80, 30, 90, 50, 70, 76, 57, 81, 16, 39, -23, -908, -1 };
        private int[] arr = { 30, 40, 50, 60, 70, 80, 90, 100, 200, 300};

        [TestMethod]
        public void Test_LinearSearch()
        {
            ArrayProblems.Rotate(arr, 15);
        }
    }
}
