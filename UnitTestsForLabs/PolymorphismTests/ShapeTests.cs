using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolymorphismLab.Classes;
using System;

namespace UnitTestsForLabs
{
    [TestClass]
    public class ShapeTests
    {
        private Shape shape;
        private Vertex vertex;

        [TestInitialize]
        public void SetUp()
        {
            shape = new Shape()
            {
                Colour = "Blue"
            };
            vertex = new Vertex()
            {
                XCoordinate = 12,
                YCoordinate = 12
            };
        }

        [TestMethod]
        public void TranslateTestForXCoordinates()
        {
            var result = shape.Translate(12, vertex);
            Assert.AreEqual(result.XCoordinate, 24);
            Assert.AreEqual(result.YCoordinate, 24);
        }

        [TestMethod]
        public void TranslateTestForYCoordinates()
        {
            var result = shape.Translate(-200, vertex);
            Assert.AreEqual(result.XCoordinate, -188);
            Assert.AreEqual(result.YCoordinate, -188);

        }

        [TestMethod]
        public void TestToString()
        {
            String result = shape.ToString();
            Assert.AreEqual(result, "Colour: Blue");
        }
    }
}
