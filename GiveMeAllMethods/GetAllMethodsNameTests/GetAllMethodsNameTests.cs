using NUnit.Framework;
using System.Linq;
using System;

namespace GetAllMethodsName.Tests
{
    public class GetAllMethodsNameTests
    {
        [Test]
        public void NullTestReturnEmptyArray()
        {
            Assert.AreEqual(0, GetAllMethodsName.GetMethodNames(null).Length);
        }

        [Test]
        public void NewObjectTest()
        {
            var testObject = new object();
            var methodNameArray = GetAllMethodsName.GetMethodNames(testObject);
            Assert.IsTrue(methodNameArray.Contains("ToString"));
        }
    }
}