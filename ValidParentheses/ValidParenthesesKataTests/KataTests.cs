using NUnit.Framework;

namespace ValidParenthesesKata.Tests
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void SampleTest1()
        {
            Assert.AreEqual(true, Kata.ValidParentheses("()"));
        }

        [Test]
        public void SampleTest2()
        {
            Assert.AreEqual(false, Kata.ValidParentheses(")(((("));
        }
    }
}