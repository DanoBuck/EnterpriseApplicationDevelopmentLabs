using System;

namespace PolymorphismLab.Classes
{
    public class Circle : Shape
    {
        public Vertex OriginVertex { get; set; }
        public double Radius { get; set; }

        public override string ToString()
        {
            return "Coordinates: (" + OriginVertex.XCoordinate + "," + OriginVertex.YCoordinate + ")" + "\nColour: " + Colour + "\nRadius: " + Radius;
        }

        public virtual Circle Translate(Vertex vertex, int amountToTranslate)
        {
            int vertexX = vertex.XCoordinate + amountToTranslate;
            int vertexY = vertex.YCoordinate + amountToTranslate;
            return new Circle()
            {
                Colour = Colour,
                OriginVertex = new Vertex
                {
                    XCoordinate = vertexX,
                    YCoordinate = vertexY
                },
                Radius = Radius
            };
        }

        public double Area(double radius)
        {
            double area = Math.PI * radius * radius;
            return Math.Round(area, 2);
        }
    }
}
