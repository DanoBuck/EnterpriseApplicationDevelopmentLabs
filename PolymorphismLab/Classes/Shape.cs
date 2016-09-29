using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorhismLab.Classes
{
    public class Shape
    {
        public String Colour { get; set; }
        public override string ToString()
        {
            return "Colour: " + Colour;
        }

        public Vertex Translate(int amountToTranslate, Vertex vertexTranslation)
        {
            vertexTranslation.XCoordinate -= amountToTranslate;
            vertexTranslation.YCoordinate -= amountToTranslate;
            return vertexTranslation;
        }
    }
}
