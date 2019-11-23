using System;
using essential_training;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EssentialTrainingTests
{
    [TestClass]
    public class SimpleArrayTest
    {
        [TestMethod]
        public void TestInstantiation()
        {
            var testInstance = new SimpleArray();
            Assert.AreEqual(testInstance.Classes.Length, 4);
            Assert.AreEqual(testInstance.Classes[1], "Scout");
        }

        [TestMethod]
        public void TestToString()
        {
            var testInstance = new SimpleArray();
            Assert.IsTrue(testInstance.ToString().StartsWith("There are"));
        }
    }
}
