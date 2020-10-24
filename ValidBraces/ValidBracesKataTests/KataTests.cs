using NUnit.Framework;
using ValidBracesKata;
using System;
using System.Collections.Generic;
using System.Text;

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