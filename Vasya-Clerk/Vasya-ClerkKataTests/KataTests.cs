using NUnit.Framework;

namespace Vasya_ClerkKata.Tests
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void Test1()
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 50 };
            Assert.AreEqual("YES", Kata.Tickets(peopleInLine));
        }

        [Test]
        public void Test2()
        {
            int[] peopleInLine = new int[] { 25, 100 };
            Assert.AreEqual("NO", Kata.Tickets(peopleInLine));
        }

        [Test]
        public void Test3()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 };
            Assert.AreEqual("YES", Kata.Tickets(peopleInLine));
        }

        [Test]
        public void Test4()
        {
            int[] peopleInLine = new int[] { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 };
            Assert.AreEqual("NO", Kata.Tickets(peopleInLine));
        }

        [Test]
        public void Test5()
        {
            int[] peopleInLine = new int[] { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 };
            Assert.AreEqual("NO", Kata.Tickets(peopleInLine));
        }

        [Test]
        public void Test6()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 50, 100, 50 };
            Assert.AreEqual("YES", Kata.Tickets(peopleInLine));
        }

        [Test]
        public void Test7()
        {
            int[] peopleInLine = new int[] { 25, 25 };
            Assert.AreEqual("YES", Kata.Tickets(peopleInLine));
        }

        [Test]
        public void Test8()
        {
            int[] peopleInLine = new int[] { 50, 100, 100 };
            Assert.AreEqual("NO", Kata.Tickets(peopleInLine));
        }

        [Test]
        public void Test9()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 25, 25, 25, 50, 50, 50, 100, 100, 100, 100 };
            Assert.AreEqual("NO", Kata.Tickets(peopleInLine));
        }

        [Test]
        public void Test10()
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 50, 100 };
            Assert.AreEqual("NO", Kata.Tickets(peopleInLine));
        }
        [Test]
        public void Test11()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 25, 100, 100 };
            Assert.AreEqual("NO", Kata.Tickets(peopleInLine));
        }
        [Test]
        public void Test12()
        {
            int[] peopleInLine = new int[] { 25, 50, 25, 100, 25, 25, 50, 100, 25, 25, 25, 100, 25, 25, 50, 100, 25, 50, 25, 100, 25, 50, 50, 50 };
            Assert.AreEqual("NO", Kata.Tickets(peopleInLine));
        }
        [Test]
        public void Test13()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 100, 25, 25, 25, 100, 25, 25, 50, 100, 25, 25, 50, 100, 50, 50 };
            Assert.AreEqual("NO", Kata.Tickets(peopleInLine));
        }
        [Test]
        public void Test14()
        {
            int[] peopleInLine = new int[] { 25, 50, 25, 100, 25, 25, 50, 100, 25, 50, 25, 100, 50, 25 };
            Assert.AreEqual("NO", Kata.Tickets(peopleInLine));
        }
        [Test]
        public void Test15()
        {
            int[] peopleInLine = new int[] { 25, 50, 100, 25, 25, 25, 50 };
            Assert.AreEqual("NO", Kata.Tickets(peopleInLine));
        }
        [Test]
        public void Test16()
        {
            int[] peopleInLine = new int[] { 25, 50, 25, 50, 100, 25, 25, 50 };
            Assert.AreEqual("NO", Kata.Tickets(peopleInLine));
        }
        [Test]
        public void Test17()
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 100 };
            Assert.AreEqual("YES", Kata.Tickets(peopleInLine));
        }
    }
}