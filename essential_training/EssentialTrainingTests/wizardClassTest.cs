using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using essential_training;

namespace EssentialTrainingTests
{
    [TestClass]
    public class wizardClassTest
    {
        [TestMethod]
        public void IsWizadTest()
        {
            var testInstance = new wizardClass();
            testInstance.Wizards.Add("Pyro");
            testInstance.Wizards.Add("Cryo");
            testInstance.Wizards.Add("Electro");

            // expect to pass
            Assert.IsTrue(testInstance.IsWizard("Pyro"));

            // expect to fail
            Assert.IsFalse(testInstance.IsWizard("Barbarian"));
        }
    }
}
