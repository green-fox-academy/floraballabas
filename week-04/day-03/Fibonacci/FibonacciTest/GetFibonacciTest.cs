using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fibonacci;

namespace FibonacciTest
{
    [TestFixture]
    public class GetFibonacciTest
    {
        GetFibonacci myClass = new GetFibonacci();
        [Test]
        public void RecursiveTest_WhenZeroOrOne_ReturnItself()
        {
            int n = 1;
            int output = n;
            Assert.AreEqual(output, myClass.Recursion(n));
        }
        [Test]
        public void RecursiveTest_WhenTwo_ReturnOne()
        {
            int n = 2;
            int output = 1;
            Assert.AreEqual(output, myClass.Recursion(n));
        }
        [Test]
        public void RecursiveTest_WhenThree_ReturnTwo()
        {
            int n = 3;
            int output = 2;
            Assert.AreEqual(output, myClass.Recursion(n));
        }
        [Test]
        public void RecursiveTest_WhenFour_ReturnThree()
        {
            int n = 4;
            int output = 3;
            Assert.AreEqual(output, myClass.Recursion(n));
        }
        [Test]
        public void RecursiveTest_WhenFive_ReturnFive()
        {
            int n = 5;
            int output = 5;
            Assert.AreEqual(output, myClass.Recursion(n));
        }
        [Test]
        public void RecursiveTest_WhenSix_ReturnEight()
        {
            int n = 6;
            int output = 8;
            Assert.AreEqual(output, myClass.Recursion(n));
        }
        [Test]
        public void RecursiveTest_WhenSeven_ReturnThirteen()
        {
            int n = 7;
            int output = 13;
            Assert.AreEqual(output, myClass.Recursion(n));
        }
        [Test]
        public void RecursiveTest_WhenEight_ReturnTwentyOne()
        {
            int n = 8;
            int output = 21;
            Assert.AreEqual(output, myClass.Recursion(n));
        }

    }
}
