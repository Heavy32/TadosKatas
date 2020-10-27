using NUnit.Framework;

namespace ValidBracesKata.Tests
{
    public class KataTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, Kata.ValidBraces("()"));
        }
        [Test]
        public void Test2()
        {

            Assert.AreEqual(false, Kata.ValidBraces("[(])"));
        }
    }
}