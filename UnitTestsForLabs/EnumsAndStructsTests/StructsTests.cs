using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsForLabs.EnumsAndStructsTests
{
    [TestClass]
    public class StructsTests
    {
        EnumsAndStructs.Structs.Structs.Currencys myStruct;

        [TestInitialize]
        public void SetUp()
        {
            myStruct = new EnumsAndStructs.Structs.Structs.Currencys()
            {
                MoneyAmount = 122.00,
                MoneyCurrency = "€"
            };
        }

        [TestMethod]
        public void ConversionOfEuroToDollars()
        {
            double conversion = myStruct.ConversionOfMoneyForEuro("$");
            Assert.AreEqual(conversion, 136.6);
        }

        [TestMethod]
        public void ConversionOfEuroToYEN()
        {
            double conversion = myStruct.ConversionOfMoneyForEuro("YEN");
            Assert.AreEqual(conversion, 13899.5);
        }

        [TestMethod]
        public void ConversionOfEuroToPounds()
        {
            double conversion = myStruct.ConversionOfMoneyForEuro("£");
            Assert.AreEqual(conversion, 105.8);
        }
    }
}
