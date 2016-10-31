using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeAssessment1.Classes;
using System;

namespace UnitTestsForLabs.PracticeAssessment1Tests
{
    [TestClass]
    public class MusicFileTests
    {
        private MusicFile musicFile;

        [TestInitialize]
        public void SetUp()
        {
            musicFile = new MusicFile("MyArtist", "MyTitle", Genre.Dance);
        }

        [TestMethod]
        public void ToStringTest()
        {
            string expectedValue = "File Name: Music File\nTitle: MyTitle\nArtist: MyArtist\nGenre: Dance";
            string result = musicFile.ToString();
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ConstructorTest()
        {
            string expectedValue = "File Name: Music File\nTitle: MyTitle\nArtist: MyArtist\nGenre: Other";
            MusicFile newMusic = new MusicFile("MyArtist", "MyTitle");
            string result = newMusic.ToString();
            Assert.AreEqual(expectedValue, result);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void ConstructorNullTest()
        {
            MusicFile newMusic = new MusicFile(null, "MyTitle");
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void ConstructorEmptyTest()
        {
            MusicFile newMusic = new MusicFile("", "MyTitle");
        }
    }
}
