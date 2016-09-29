using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesLab1
{
    public abstract class ThreeDShape
    {
        private String shape { get; set; }
        public String corresponding { get; set; }

        public ThreeDShape()
        {
            shape = "";
            corresponding = shape;
        }

        public ThreeDShape(String shapeIn)
        {
            shape = shapeIn;
            corresponding = shapeIn;
        }

        // Abstract Method
        public abstract double CalculateVolumeOfShape();

        public override String ToString()
        {
            return "Shape: " + shape + "\nCorresponding: " + corresponding;
        }
    }
}
