using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibrary;

namespace UnitTests
{
    [TestClass]
    public class AdditionTests
    {
        [TestMethod]
        public void BasicAdd()
        {
            var result = Addition.Add(5, 5);
            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void SingleItem()
        {
            var result = Addition.Add(4);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void NullTest()
        {
            var result = Addition.Add(null);
            Assert.AreEqual(0, result);
        }
    }
}
