using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolymorphismLab.Classes;
using System;

namespace UnitTestsForLabs.PolymorphismTests
{
    [TestClass]
    public class LineTests
    {
        private Line line;

        [TestInitialize]
        public void SetUp()
        {
            line = new Line
            {
                Colour = "BLUE",
                Vertex1 = new Vertex
                {
                    XCoordinate = 2,
                    YCoordinate = 0
                },
                Vertex2 = new Vertex
                {
                    XCoordinate = 14,
                    YCoordinate = 15
                },
            };
        }

        [TestMethod]
        public void ToStringTest()
        {
            String result = line.ToString();
            String expectedOutput = "Colour: BLUE\nCoordinates: (2,0) (14,15)";
            Assert.AreEqual(result, expectedOutput);
        }

        [TestMethod]
        public void TranslationTest()
        {
            Line result = line.Translate(line.Vertex1, line.Vertex2, 13);
            Assert.AreEqual(result.Vertex1.XCoordinate, 15);
            Assert.AreEqual(result.Vertex1.YCoordinate, 13);
            Assert.AreEqual(result.Vertex2.XCoordinate, 27);
            Assert.AreEqual(result.Vertex2.YCoordinate, 28);
            Assert.AreEqual(result.Colour, "BLUE");
        }
    }
}
