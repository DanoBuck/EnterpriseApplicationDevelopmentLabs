using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndOpOverloading.Classes.OperatorOverloading
{
    public class MoneyConversion
    {
        public struct Currencys
        {
            // Conversions needed for euros
            public const double conversionRateOfOneEuroInDollars = 1.12;
            public const double conversionRateOfOneEuroToYen = 113.93;
            public const double conversionRateOfOneEuroToPounds = 0.87;

            // Conversions needed for dollars
            public const double conversionRateOfOneDollarInEuro = .89;
            public const double conversionRateOfOneDollarToYen = 101.34;
            public const double conversionRateOfOneDollarToPounds = 0.77;

            // Conversions for pounds
            public const double conversionRateOfOnePoundInEuro = 1.15;
            public const double conversionRateOfOnePoundToDollars = 1.30;
            public const double conversionRateOfOnePoundToYen = 131.52;

            public double MoneyAmount { get; set; }
            public string MoneyCurrency { get; set; }

            public double ConversionOfMoneyForEuro(string toMoney)
            {
                double convertedMoney = 0;

                if (toMoney == "$")
                {
                    convertedMoney = MoneyAmount * conversionRateOfOneEuroInDollars;
                }
                else if (toMoney == "YEN")
                {
                    convertedMoney = MoneyAmount * conversionRateOfOneEuroToYen;
                }
                else if (toMoney == "£")
                {
                    convertedMoney = MoneyAmount * conversionRateOfOneEuroToPounds;
                }
                return Math.Round(convertedMoney, 1);
            }

            public double ConversionOfMoneyForDollars(string toMoney)
            {
                double convertedMoney = 0;

                if (toMoney == "€")
                {
                    convertedMoney = MoneyAmount * conversionRateOfOneDollarInEuro;
                }
                else if (toMoney == "YEN")
                {
                    convertedMoney = MoneyAmount * conversionRateOfOneDollarToYen;
                }
                else if (toMoney == "£")
                {
                    convertedMoney = MoneyAmount * conversionRateOfOneDollarToPounds;
                }
                else // Not Found
                {
                    convertedMoney = MoneyAmount;
                }
                return Math.Round(convertedMoney, 1);
            }

            public double ConversionOfMoneyForPounds(string toMoney)
            {
                double convertedMoney = 0;

                if (toMoney == "€")
                {
                    convertedMoney = MoneyAmount * conversionRateOfOnePoundInEuro;
                }
                else if (toMoney == "YEN")
                {
                    convertedMoney = MoneyAmount * conversionRateOfOnePoundToYen;
                }
                else if (toMoney == "$")
                {
                    convertedMoney = MoneyAmount * conversionRateOfOnePoundToDollars;
                }
                else // Not Found
                {
                    convertedMoney = MoneyAmount;
                }
                return Math.Round(convertedMoney, 1);
            }

            public double MoneyAdditionUsingDifferentMoneyToEuro(Currencys currency1, Currencys currency2)
            {
                double conversionReturned = 0;
                if (currency1.MoneyCurrency == "£" && currency2.MoneyCurrency == "$")
                {
                    // Convert currency1 and 2 to euro
                    double conversion1 = currency1.ConversionOfMoneyForPounds("€");
                    double conversion2 = currency2.ConversionOfMoneyForDollars("€");
                    conversionReturned = conversion1 + conversion2;
                }
                else if (currency1.MoneyCurrency == "$" && currency2.MoneyCurrency == "£")
                {
                    // Convert currency1 and 2 to euro
                    double conversion1 = currency1.ConversionOfMoneyForDollars("€");
                    double conversion2 = currency2.ConversionOfMoneyForPounds("€");
                    conversionReturned = conversion1 + conversion2;
                }
                else if (currency1.MoneyCurrency == "£" && currency2.MoneyCurrency == "£")
                {
                    double conversion1 = currency1.ConversionOfMoneyForPounds("€");
                    double conversion2 = currency2.ConversionOfMoneyForPounds("€");
                    conversionReturned = conversion1 + conversion2;
                }
                else if (currency1.MoneyCurrency == "$" && currency2.MoneyCurrency == "$")
                {
                    double conversion1 = currency1.ConversionOfMoneyForDollars("€");
                    double conversion2 = currency2.ConversionOfMoneyForDollars("€");
                    conversionReturned = conversion1 + conversion2;
                }
                else if (currency1.MoneyCurrency == "€" && currency2.MoneyCurrency == "$")
                {
                    double conversion1 = currency1.MoneyAmount;
                    double conversion2 = currency2.ConversionOfMoneyForDollars("€");
                    conversionReturned = conversion1 + conversion2;
                }
                else
                {
                    conversionReturned = 0;
                }

                return Math.Round(conversionReturned, 1);
            }

            public double MoneyAdditionUsingDifferentMoneyToDollars(Currencys currency1, Currencys currency2)
            {
                double conversionReturned = 0;
                if (currency1.MoneyCurrency == "€" && currency2.MoneyCurrency == "€")
                {
                    // Convert currency1 and 2 to dollars
                    double conversion1 = currency1.ConversionOfMoneyForEuro("$");
                    double conversion2 = currency2.ConversionOfMoneyForEuro("$");
                    conversionReturned = conversion1 + conversion2;
                }
                else if (currency1.MoneyCurrency == "£" && currency2.MoneyCurrency == "£")
                {
                    // Convert currency1 and 2 to dollars
                    double conversion1 = currency1.ConversionOfMoneyForPounds("$");
                    double conversion2 = currency2.ConversionOfMoneyForPounds("$");
                    conversionReturned = conversion1 + conversion2;
                }
                else if (currency1.MoneyCurrency == "£" && currency2.MoneyCurrency == "€")
                {
                    double conversion1 = currency1.ConversionOfMoneyForPounds("$");
                    double conversion2 = currency2.ConversionOfMoneyForEuro("$");
                    conversionReturned = conversion1 + conversion2;
                }
                else if (currency1.MoneyCurrency == "€" && currency2.MoneyCurrency == "£")
                {
                    double conversion1 = currency1.ConversionOfMoneyForEuro("$");
                    double conversion2 = currency2.ConversionOfMoneyForPounds("$");
                    conversionReturned = conversion1 + conversion2;
                }
                else
                {
                    conversionReturned = 0;
                }

                return Math.Round(conversionReturned, 1);
            }

            public static Currencys operator +(Currencys currencyToAdd1, Currencys currencyToAdd2)
            {
                Currencys newCurrency = new Currencys();
                if (currencyToAdd1.MoneyCurrency == "€" && currencyToAdd2.MoneyCurrency == "£")
                {
                    // Convert pounds to euro
                    double converted = currencyToAdd2.ConversionOfMoneyForPounds("€");
                    // Add the converted pounds to the euros
                    newCurrency.MoneyAmount = currencyToAdd1.MoneyAmount + converted;
                    newCurrency.MoneyCurrency = "€";
                }
                else if (currencyToAdd1.MoneyCurrency == "£" && currencyToAdd2.MoneyCurrency == "€")
                {
                    double converted = currencyToAdd2.ConversionOfMoneyForEuro("£");
                    newCurrency.MoneyAmount = currencyToAdd1.MoneyAmount + converted;
                    newCurrency.MoneyCurrency = "£";
                }
                return newCurrency;
            }
        }
    }
}
