using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolymorphismLab.Classes;
using System;

namespace UnitTestsForLabs.PolymorphismTests
{
    [TestClass]
    public class CircleTests
    {
        private Circle circle;

        [TestInitialize]
        public void SetUp()
        {
            circle = new Circle
            {
                Colour = "YELLOW",
                OriginVertex = new Vertex
                {
                    XCoordinate = 5,
                    YCoordinate = 15
                },
                Radius = 6
            };
        }

        [TestMethod]
        public void ToStringTest()
        {
            String result = circle.ToString();
            String expected = "Coordinates: (5,15)\nColour: YELLOW\nRadius: 6";
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TranslationTest()
        {
            Circle result = circle.Translate(circle.OriginVertex, 6);
            Assert.AreEqual(result.OriginVertex.XCoordinate, 11);
            Assert.AreEqual(result.OriginVertex.YCoordinate, 21);
            Assert.AreEqual(result.Radius, 6);
            Assert.AreEqual(result.Colour, "YELLOW");
        }

        [TestMethod]
        public void AreaTest()
        {
            double result = circle.Area(circle.Radius);
            Assert.AreEqual(result, 113.1);

            result = circle.Area(circle.Radius * 16);
            Assert.AreEqual(result, 28952.92);
        }
    }
}
