using ExceptionsAndIndexers.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestsForLabs.ExceptionsAndIndexersTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void DivisionTestSuccessful1()
        {
            double number1 = 12.5;
            double number2 = 5;

            float result = Calculator.Division(float.Parse(number1.ToString()), float.Parse(number2.ToString()));
            Assert.AreEqual(result, 2.5);
        }

        [TestMethod]
        public void DivisionTestSuccessful2()
        {
            double number1 = 400000000;
            double number2 = 50000;

            float result = Calculator.Division(float.Parse(number1.ToString()), float.Parse(number2.ToString()));
            Assert.AreEqual(result, 8000);
        }

        [TestMethod]
        public void DivisionTestUnsuccessfulThrowsAnError()
        {
            double number1 = 12.5;
            double number2 = 0;
            try {
                float result = Calculator.Division(float.Parse(number1.ToString()), float.Parse(number2.ToString()));
                Assert.Fail("No Exception caught");
            }
            catch (ArgumentException a)
            {
                Assert.IsTrue(a is ArgumentException);
            }
        }

        [TestMethod]
        public void DivisionTestUnsuccessfulThrowsOverflowExceptionAsNumberTooLarge()
        {
            double number1 = 12.5;
            string number2 = "340282311100000000000000000000000000000000";
            try
            {
                float result = Calculator.Division(float.Parse(number1.ToString()), float.Parse(number2.ToString()));
                Assert.Fail("No Exception caught");
            }
            catch (ArgumentException)
            {
            } catch (OverflowException e)
            {
                Assert.IsTrue(e is OverflowException);
            }
        }

        [TestMethod]
        public void DivisionTestUnsuccessfulThrowsFormatException()
        {
            double number1 = 12.5;
            string number2 = "ABCDEFGHIJKLMNOP";
            try
            {
                float result = Calculator.Division(float.Parse(number1.ToString()), float.Parse(number2.ToString()));
                Assert.Fail("No Exception caught");
            }
            catch (ArgumentException)
            {
            }
            catch (OverflowException)
            {
            }
            catch (FormatException f)
            {
                Assert.IsTrue(f is FormatException);
            }
        }

        [TestMethod]
        public void DivisionTestUnsuccessfulThrowsException()
        {
            string number1 = "ABCDEFGHIJKLMNOP";
            string number2 = "ABCDEFGHIJKLMNOP";
            try
            {
                float result = Calculator.Division(float.Parse(number1.ToString()), float.Parse(number2.ToString()));
                Assert.Fail("No Exception caught");
            }
            catch (Exception e)
            {
                Assert.IsTrue(e is Exception);
            }
        }
    }
}
