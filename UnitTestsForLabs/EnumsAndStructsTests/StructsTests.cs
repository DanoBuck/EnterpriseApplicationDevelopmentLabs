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
            Assert.AreEqual(conversion, 106.1);
        }

        [TestMethod]
        public void ConversionOfDollarsToEuro()
        {
            myStruct.MoneyCurrency = "$";
            double convserion = myStruct.ConversionOfMoneyForDollars("€");
            Assert.AreEqual(convserion, 108.6);
        }

        [TestMethod]
        public void ConversionOfDollarsToYen()
        {
            myStruct.MoneyCurrency = "$";
            double convserion = myStruct.ConversionOfMoneyForDollars("YEN");
            Assert.AreEqual(convserion, 12363.5);
        }

        [TestMethod]
        public void ConversionOfDollarsToPounds()
        {
            myStruct.MoneyCurrency = "$";
            double convserion = myStruct.ConversionOfMoneyForDollars("£");
            Assert.AreEqual(convserion, 93.9);
        }

        [TestMethod]
        public void ConversionOfPoundsToEuros()
        {
            myStruct.MoneyCurrency = "£";
            double convserion = myStruct.ConversionOfMoneyForPounds("€");
            Assert.AreEqual(convserion, 140.3);
        }

        [TestMethod]
        public void ConversionOfPoundsToDollars()
        {
            myStruct.MoneyCurrency = "£";
            double convserion = myStruct.ConversionOfMoneyForPounds("$");
            Assert.AreEqual(convserion, 158.6);
        }

        [TestMethod]
        public void ConversionOfPoundsToYEN()
        {
            myStruct.MoneyCurrency = "£";
            double convserion = myStruct.ConversionOfMoneyForPounds("YEN");
            Assert.AreEqual(convserion, 16045.4);
        }

        [TestMethod]
        public void MoneyAdditionUsingPoundsToEuroTest()
        {
            myStruct = new EnumsAndStructs.Structs.Structs.Currencys()
            {
                MoneyAmount = 122.00,
                MoneyCurrency = "£"
            };

            double conversionAddition = myStruct.MoneyAdditionUsingDifferentMoneyToEuro(myStruct, myStruct);
            Assert.AreEqual(conversionAddition, 280.6);
        }

        [TestMethod]
        public void MoneyAdditionUsingDollarsToEuroTest()
        {
            myStruct = new EnumsAndStructs.Structs.Structs.Currencys()
            {
                MoneyAmount = 122.00,
                MoneyCurrency = "$"
            };

            double conversionAddition = myStruct.MoneyAdditionUsingDifferentMoneyToEuro(myStruct, myStruct);
            Assert.AreEqual(conversionAddition, 217.2);
        }


        [TestMethod]
        public void MoneyAdditionUsingDollarsAndPoundsToEuroTest()
        {
            myStruct = new EnumsAndStructs.Structs.Structs.Currencys()
            {
                MoneyAmount = 122.00,
                MoneyCurrency = "$"
            };

            EnumsAndStructs.Structs.Structs.Currencys myStruct2 = new EnumsAndStructs.Structs.Structs.Currencys()
            {
                MoneyAmount = 122.00,
                MoneyCurrency = "£"
            };

            double conversionAddition = myStruct.MoneyAdditionUsingDifferentMoneyToEuro(myStruct, myStruct2);
            Assert.AreEqual(conversionAddition, 248.9);
        }

        [TestMethod]
        public void MoneyAdditionUsingEurosAndDollarsToEuroTest()
        {
            myStruct = new EnumsAndStructs.Structs.Structs.Currencys()
            {
                MoneyAmount = 122.00,
                MoneyCurrency = "€"
            };

            EnumsAndStructs.Structs.Structs.Currencys myStruct2 = new EnumsAndStructs.Structs.Structs.Currencys()
            {
                MoneyAmount = 122.00,
                MoneyCurrency = "$"
            };

            double conversionAddition = myStruct.MoneyAdditionUsingDifferentMoneyToEuro(myStruct, myStruct2);
            Assert.AreEqual(conversionAddition, 230.6);
        }

        [TestMethod]
        public void MoneyAdditionUsingPoundsAndDollarsToEuroTest()
        {
            myStruct = new EnumsAndStructs.Structs.Structs.Currencys()
            {
                MoneyAmount = 122.00,
                MoneyCurrency = "£"
            };

            EnumsAndStructs.Structs.Structs.Currencys myStruct2 = new EnumsAndStructs.Structs.Structs.Currencys()
            {
                MoneyAmount = 122.00,
                MoneyCurrency = "$"
            };

            double conversionAddition = myStruct.MoneyAdditionUsingDifferentMoneyToEuro(myStruct, myStruct2);
            Assert.AreEqual(conversionAddition, 248.9);
        }

        [TestMethod]
        public void MoneyAdditionUsingEurosToDollarsTest()
        {
            myStruct = new EnumsAndStructs.Structs.Structs.Currencys()
            {
                MoneyAmount = 122.00,
                MoneyCurrency = "€"
            };

            double conversionAddition = myStruct.MoneyAdditionUsingDifferentMoneyToDollars(myStruct, myStruct);
            Assert.AreEqual(conversionAddition, 273.2);
        }

        [TestMethod]
        public void MoneyAdditionUsingPoundsToDollarsTest()
        {
            myStruct = new EnumsAndStructs.Structs.Structs.Currencys()
            {
                MoneyAmount = 122.00,
                MoneyCurrency = "£"
            };

            double conversionAddition = myStruct.MoneyAdditionUsingDifferentMoneyToDollars(myStruct, myStruct);
            Assert.AreEqual(conversionAddition, 317.2);
        }

        [TestMethod]
        public void MoneyAdditionUsingPoundsAndEurosToDollarsTest()
        {
            myStruct = new EnumsAndStructs.Structs.Structs.Currencys()
            {
                MoneyAmount = 122.00,
                MoneyCurrency = "£"
            };

            EnumsAndStructs.Structs.Structs.Currencys myStruct2 = new EnumsAndStructs.Structs.Structs.Currencys()
            {
                MoneyAmount = 122.00,
                MoneyCurrency = "€"
            };

            double conversionAddition = myStruct.MoneyAdditionUsingDifferentMoneyToDollars(myStruct, myStruct2);
            Assert.AreEqual(conversionAddition, 295.2);
        }

        [TestMethod]
        public void MoneyAdditionUsingEurosAndPoundsToDollarsTest()
        {
            myStruct = new EnumsAndStructs.Structs.Structs.Currencys()
            {
                MoneyAmount = 122.00,
                MoneyCurrency = "£"
            };

            EnumsAndStructs.Structs.Structs.Currencys myStruct2 = new EnumsAndStructs.Structs.Structs.Currencys()
            {
                MoneyAmount = 122.00,
                MoneyCurrency = "€"
            };

            double conversionAddition = myStruct.MoneyAdditionUsingDifferentMoneyToDollars(myStruct2, myStruct);
            Assert.AreEqual(conversionAddition, 295.2);
        }
    }
}
