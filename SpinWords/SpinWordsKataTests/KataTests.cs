using NUnit.Framework;

namespace SpinWordsKata.Tests
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual("emocleW", Kata.SpinWords("Welcome"));
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual("Hey wollef sroirraw", Kata.SpinWords("Hey fellow warriors"));
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual("This ecnetnes is a ecnetnes", Kata.SpinWords("This sentence is a sentence"));
        }
    }
}