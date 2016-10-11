using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumeratorsAndOpOverloading.Classes.OperatorOverloading;

namespace UnitTestsForLabs.EnumeratorsAndOpOverloadingTests
{
    [TestClass]
    public class OperatorOverloadingTests
    {
        private MoneyConversion.Currencys currency1, currency2;

        [TestInitialize]
        public void SetUp()
        {
            currency1 = new MoneyConversion.Currencys
            {
                MoneyAmount = 122.00,
                MoneyCurrency = "€"
            };
            currency2 = new MoneyConversion.Currencys
            {
                MoneyAmount = 122.00,
                MoneyCurrency = "£"
            };
        }

        [TestMethod]
        public void AdditionOfEurosAndPoundsTest()
        {
            MoneyConversion.Currencys currency3 = currency1 + currency2;
            Assert.AreEqual(currency3.MoneyCurrency, "€");
            Assert.AreEqual(currency3.MoneyAmount, 262.3);
        }

        [TestMethod]
        public void AdditionOfPoundsAndEurosTest()
        {
            currency1.MoneyCurrency = "£";
            currency2.MoneyCurrency = "€";
            MoneyConversion.Currencys currency3 = currency1 + currency2;
            Assert.AreEqual(currency3.MoneyCurrency, "£");
            Assert.AreEqual(currency3.MoneyAmount, 228.1);
        }
    }
}
