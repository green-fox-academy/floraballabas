using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppleApp;

namespace AppleAppTest
{
    [TestFixture]
    public class ApplesTest
    {
        Apples apples = new Apples();

        [Test]
        public void GetAppleTest()
        {
            //arrange
            string myObject = "apple";

            //act
            string output = "apple";

            //assert
            Assert.AreEqual(output, apples.GetApple());
        }
    }
}
