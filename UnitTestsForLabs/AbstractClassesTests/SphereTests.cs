using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractClassesLab;

namespace UnitTestsForLabs
{
    [TestClass]
    public class TestClassForAbstractClass
    {
        private ThreeDShape shape;

        [TestInitialize]
        public void SetUp()
        {
            shape = new Sphere(12, "Sphere");
        }

        [TestMethod]
        public void TestVolumeOfSphere()
        {
            double vol = shape.CalculateVolumeOfShape();

            vol.Equals(7238.23);
        }

        [TestMethod]
        public void TestToStringOnShape()
        {
            String result = shape.ToString();
            
            result.Equals("Radius: 12\nCorresponding: Sphere");
        }
    }
}
