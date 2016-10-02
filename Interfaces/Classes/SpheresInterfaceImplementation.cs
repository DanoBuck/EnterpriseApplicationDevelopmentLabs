using Interfaces.Interfaces;
using System;

namespace Interfaces.Classes
{
    public class SpheresInterfaceImplementation : IHasVolume
    {
        public double Radius { get; set; }

        // Implementation of iterface method
        public double CalculateVolume()
        {
            double fraction = 1.3333333;
            double radius = fraction * Math.PI * Radius * Radius * Radius;
            return Math.Round(radius, 2);
        }

        public override String ToString()
        {
            return "Radius: " + Radius;
        }
    }
}
