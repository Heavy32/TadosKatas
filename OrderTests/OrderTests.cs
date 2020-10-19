﻿using NUnit.Framework;
using Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Tests
{
    public class OrderTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Thi1s is2 3a T4est", Order.OrderText("is2 Thi1s T4est 3a"));
            Assert.AreEqual("Fo1r the2 g3ood 4of th5e pe6ople", Order.OrderText("4of Fo1r pe6ople g3ood th5e the2"));
            Assert.AreEqual("", Order.OrderText(""));
        }
    }
}