using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndStructs.Structs
{
    public class Structs
    {
        public struct Currencys {
            public const double conversionRateOfOneEuroInDollars = 1.12;
            public const double conversionRateOfOneEuroToYen = 113.93;
            public const double conversionRateOfOneEuroToPounds = 0.87;

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
                else if(toMoney == "£")
                {
                    convertedMoney = MoneyAmount * conversionRateOfOneEuroToPounds;
                }
                return Math.Round(convertedMoney, 1);
            }

            // To Be Implemented
            public double MoneyAdditionUsingDifferentMoney(Currencys currency1, Currencys currency2)
            {

                return 0;
            }
        }
    }
}
