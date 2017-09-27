using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extension;

namespace ExtensionTest
{
    [TestFixture]

    public class ExtensionTest
    {
        ExtensionClass extension = new ExtensionClass();

        [Test]
        public void TestAdd_2and3is5()
        {
            int a = 3;
            int b = 2;
            int expected = a + b;
            Assert.AreEqual(expected, extension.Add(a, b));
        }

        [Test]
        public void TestAdd_1and4is5()
        {
            int a = 1;
            int b = 4;
            int expected = a + b;
            Assert.AreEqual(expected, extension.Add(a, b));
        }

        [Test]
        public void TestMaxOfThree_First()
        {
            Assert.AreEqual(6, extension.MaxOfThree(5, 6, 3));
        }

        [Test]
        public void TestMaxOfThree_Fhird()
        {
            Assert.AreEqual(6, extension.MaxOfThree(6, 4, 5));
        }

        [Test]
        public void TestMedian_Four()
        {
            Assert.AreEqual(5, extension.Median(new List<int>() { 7, 3, 3, 5 }));
        }

        [Test]
        public void TestMedian_Five()
        {
            Assert.AreEqual(4, extension.Median(new List<int>() { 1, 2, 4, 4, 5 }));
        }

        [Test]
        public void TestIsVowel_a()
        {
            Assert.True(extension.IsVowel('á'));
        }

        [Test]
        public void TestIsVowel_u()
        {
            Assert.True(extension.IsVowel('u'));
        }

        [Test]
        public void testTranslate_bemutatkozik()
        {
            Assert.AreEqual("bevemuvutavatkovozivik", extension.Translate("bemutatkozik"));
        }

        [Test]
        public void testTranslate_kolbice()
        {
            Assert.AreEqual("lavagovopuvus", extension.Translate("lagopus"));
        }
    }
}
