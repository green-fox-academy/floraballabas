using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anagram;

namespace AnagramTest
{
    [TestFixture]
    public class AnagramAppTest
    {
        AnagramApp myClass = new AnagramApp();
        [Test]
        public void IsAnagramTest()
        {
            string input1 = "alma";
            string input2 = "mala";

            bool output = true;
            Assert.AreEqual(output,myClass.IsAnagram(input1, input2));
        }
    }
}
