using PolymorhismLab.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismLab.Classes
{
    public class Circle : Shape
    {
        public Vertex OriginVertex { get; set; }
        public double Radius { get; set; }

        public override string ToString()
        {
            return "Coordinates: (" + OriginVertex.XCoordinate + "," + OriginVertex.YCoordinate + ")" + "\nColour: " + Colour;
        }

        public virtual Circle Translate(Vertex vertex, int amountToTranslate)
        {
            int vertexX = vertex.XCoordinate - amountToTranslate;
            int vertexY = vertex.YCoordinate - amountToTranslate;
            return new Circle()
            {
                OriginVertex = new Vertex
                {
                    XCoordinate = vertexX,
                    YCoordinate = vertexY
                }
            };
        }

        public double Area(int radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }
    }
}
