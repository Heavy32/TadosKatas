using NUnit.Framework;
using Array.diffKata;

namespace Array.diffKata.Tests
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void InArray12Array1OutArray2()
        {
            Assert.AreEqual(new int[] { 2 }, Kata.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }));

        }

        [Test]
        public void InArray122Array1OutArray22()
        {
            Assert.AreEqual(new int[] { 2, 2 }, Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }));
        }

        [Test]
        public void InArray122Array2OutArray1()
        {
            Assert.AreEqual(new int[] { 1 }, Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }));
        }

        [Test]
        public void InArrayEmptyArray12OutArrayEmpty()
        {
            Assert.AreEqual(new int[] { }, Kata.ArrayDiff(new int[] { }, new int[] { 1, 2 }));
        }

        [Test]
        public void InArray122ArrayEmptyOutArray122()
        {
            Assert.AreEqual(new int[] { 1, 2, 2 }, Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }));
        }
    }
}