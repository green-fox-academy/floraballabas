using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountLetter;

namespace CountLetterTest
{
    [TestFixture]
    public class CountAppTest
    {
        CountApp myClass = new CountApp();
        [Test]
        public void CounterTest()
        {
            string input = "macska";

            Dictionary<char, int> output = new Dictionary<char, int>()
            {
                { 'm', 1},
                { 'a', 2},
                { 'c', 1},
                { 's', 1},
                { 'k', 1}
            };

            Assert.AreEqual(output, myClass.LetterCounter(input));
        }
    }
}
