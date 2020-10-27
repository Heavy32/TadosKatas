using NUnit.Framework;

namespace SumStringsAsNumbersKata.Tests
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("579", Kata.SumStrings("123", "456"));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual("8842", Kata.SumStrings("8797", "45"));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual("10367", Kata.SumStrings("800", "9567"));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual("100", Kata.SumStrings("99", "1"));
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual("8670", Kata.SumStrings("00103", "08567"));
        }
        [Test]
        public void Test6()
        {
            Assert.AreEqual("5", Kata.SumStrings("", "5"));
        }
        [Test]
        public void Test7()
        {
            Assert.AreEqual("712577413488402631964821329", Kata.SumStrings("712569312664357328695151392", "8100824045303269669937"));
        }
        [Test]
        public void Test8()
        {
            Assert.AreEqual("131151201344081895336534324866", Kata.SumStrings("50095301248058391139327916261", "81055900096023504197206408605"));
        }
    }
}

