using Interfaces.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestsForLabs.Interfaces
{
    [TestClass]
    public class SphereTests
    {
        private SpheresInterfaceImplementation sphere;

        [TestInitialize]
        public void SetUp()
        {
            sphere = new SpheresInterfaceImplementation()
            {
                Radius = 8
            };
        }

        [TestMethod]
        public void ToStringTest()
        {
            String result = sphere.ToString();
            String expected = "Radius: 8";
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void VolumeTest()
        {
            double result = sphere.CalculateVolume();
            Assert.AreEqual(result, 2144.66);
        }

        [TestMethod]
        public void TestWithCollection()
        {
            SpheresInterfaceImplementation[] spheres = {
                new SpheresInterfaceImplementation { Radius = 1},
                new SpheresInterfaceImplementation { Radius = 2},
                new SpheresInterfaceImplementation { Radius = 3},
                new SpheresInterfaceImplementation { Radius = 4},
                new SpheresInterfaceImplementation { Radius = 5},
            };
            int i = 1;
            // Loop to test ToString Method on collection of spheres
            foreach (var sph in spheres)
            {
                String resultsOfToString = sph.ToString();
                Assert.AreEqual(resultsOfToString, "Radius: " + i);
                i++;
            }
            
            // Testing all objects in collection by volume
            double volumeResults = spheres[0].CalculateVolume();
            Assert.AreEqual(volumeResults, 4.19);

            volumeResults = spheres[1].CalculateVolume();
            Assert.AreEqual(volumeResults, 33.51);

            volumeResults = spheres[2].CalculateVolume();
            Assert.AreEqual(volumeResults, 113.1);

            volumeResults = spheres[3].CalculateVolume();
            Assert.AreEqual(volumeResults, 268.08);

            volumeResults = spheres[4].CalculateVolume();
            Assert.AreEqual(volumeResults, 523.6);
        }
    }
}
