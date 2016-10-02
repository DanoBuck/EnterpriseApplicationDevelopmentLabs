using ExceptionsAndIndexers.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestsForLabs.ExceptionsAndIndexersTests
{
    [TestClass]
    public class ModuleCAResultsTests
    {
        private ModuleCAResults resultsFromCA;

        [TestInitialize]
        public void SetUp() { 

            resultsFromCA = new ModuleCAResults
            {
                ModuleName = "Software Development",
                CreditsWorth = 40.00,
                StudentName = "Daniel Buckley",
            };

            resultsFromCA[0] = 100;
            resultsFromCA[1] = 90;
        }

        [TestMethod]
        public void TestToString()
        {
            string expected = "Module Name: Software Development Credits Worth: 40 Student Name: Daniel Buckley CA1: 100 CA2: 90";


            string results = resultsFromCA.ToString();
            Assert.AreEqual(results, expected);
        }

        [TestMethod]
        public void TestInvalidIndexerLessThan0()
        {
            try {
                resultsFromCA[0] = -100;
                Assert.Fail("Test Failed");
            } catch (Exception e)
            {
                Assert.IsTrue(e is Exception);
            }
        }

        [TestMethod]
        public void TestInvalidIndexerGreaterThan100()
        {
            try
            {
                resultsFromCA[0] = 101;
                Assert.Fail("Test Failed");
            }
            catch (Exception e)
            {
                Assert.IsTrue(e is Exception);
            }
        }
    }
}
