using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAndIndexers.Classes
{
    public class Calculator
    {
        public static float Division(float number1, float number2)
        {
            float result = 0;
            if(number2 == 0)
            {
                throw new ArgumentException("Division By Zero Is Undefined");
            } else
            {
                result = number1 / number2;
            }
            return result;
        }
    }
}
