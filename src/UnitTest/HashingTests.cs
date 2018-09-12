using System;
using System.Linq;
using Algos;
using Algos.Hashing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class HashingTests
    {
        private string[] studentsNames = { "mukesh", "sumit", "mukesh", "vj", "richa", "mukesh" };

        [TestMethod]
        public void Test_FrequencyofStudents()
        {
            string name = studentsNames[new Random().Next(0, studentsNames.Length - 1)];
            int result = HashingProblems.FrequencyofStudents(studentsNames, name);
        }

    }
}
