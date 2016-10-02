using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAndIndexers.Classes
{
    public class ModuleCAResults
    {
        public String ModuleName { get; set; }
        public double CreditsWorth { get; set; }
        public String StudentName { get; set; }

        private double[] ResultsOfCAs = new double[10];

        // Indexer to access array
        public double this[int i]
        {
            get
            {
                return ResultsOfCAs[i];
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception("Result cannot be lower than 0 or higher than 100");
                }
                else {
                    ResultsOfCAs[i] = value;
                }
            }
        }

        public override string ToString()
        {
            return "Module Name: " + ModuleName +
                " Credits Worth: " + CreditsWorth +
                " Student Name: " + StudentName +
                " CA1: " + ResultsOfCAs[0] +
                " CA2: " + ResultsOfCAs[1];
        }
    }
}
