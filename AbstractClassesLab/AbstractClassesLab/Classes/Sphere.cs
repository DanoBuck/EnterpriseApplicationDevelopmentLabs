using System;

namespace AbstractClassesLab
{
    public class Sphere : ThreeDShape
    {
        private double radius { get; set; }

        public Sphere(double radiusIn, String correspondIn) : base ()
        {
            radius = radiusIn;
            corresponding = correspondIn;
        }

        public Sphere() : base("")
        {
        }

        // To Be Finished
        public override double CalculateVolumeOfShape()
        {
            double fraction = 1.3333333;
            double rad = fraction * Math.PI * radius * radius * radius;
            return rad;
        }

        public override String ToString()
        {
            return "Radius: " + radius + "\nCorresponding: " + corresponding;
        }

    }
}
