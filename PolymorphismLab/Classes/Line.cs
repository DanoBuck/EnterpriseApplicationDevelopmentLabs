
namespace PolymorphismLab.Classes
{
    public class Line : Shape
    {
        public Vertex Vertex1 { get; set; }
        public Vertex Vertex2 { get; set; }

        public override string ToString()
        {
            return "Colour: " + Colour + "\nCoordinates: (" + Vertex1.XCoordinate + "," + Vertex1.YCoordinate + ")" + " (" + Vertex2.XCoordinate + "," + Vertex2.YCoordinate + ")";
        }

        // To be overridden from Shape - to be done
        public virtual Line Translate(Vertex vertex1, Vertex vertex2, int amountToTranslate)
        {
            // Calculation by a single amount passed in

            int vertX1 = vertex1.XCoordinate + amountToTranslate;
            int vertY1 = vertex1.YCoordinate + amountToTranslate;
            int vertX2 = vertex2.XCoordinate + amountToTranslate;
            int vertY2 = vertex2.YCoordinate + amountToTranslate;

            return new Line()
            {
                Colour = Colour,
                Vertex1 = new Vertex
                {
                    XCoordinate = vertX1,
                    YCoordinate = vertY1
                },
                Vertex2 = new Vertex
                {
                    XCoordinate = vertX2,
                    YCoordinate = vertY2
                }
            };
        }
    }
}
