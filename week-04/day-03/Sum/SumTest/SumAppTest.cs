using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sum;

namespace SumTest
{
    [TestFixture]
    public class SumAppTest
    {
        SumApp myClass = new SumApp();
        [Test]
        public void GetSumTestEmpty()
        {
            //arrange
            List<int> sumList = new List<int>();
            //act
            int output = 0;
            //assert
            Assert.AreEqual(output, myClass.GetSum(sumList));
        }
        [Test]
        public void GetSumTest1()
        {
            //arrange
            List<int> sumList = new List<int>() {5};
            //act
            int output = 5;
            //assert
            Assert.AreEqual(output, myClass.GetSum(sumList));
        }
        [Test]
        public void GetSumTestMultiple()
        {
            //arrange
            List<int> sumList = new List<int>() {1,2,3};
            //act
            int output = 6;
            //assert
            Assert.AreEqual(output, myClass.GetSum(sumList));
        }
        [Test]
        public void GetSumTestNull()
        {
            //arrange
            List<int> sumList = new List<int>();
            //act
            int output = 0;
            //assert
            Assert.AreEqual(output, myClass.GetSum(null));
        }

    }
}
