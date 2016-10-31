using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeAssessment1.Classes;
using System;
using System.Collections.Generic;

namespace UnitTestsForLabs.PracticeAssessment1Tests
{
    [TestClass]
    public class PlayListTests
    {
        private PlayList playList;
        private MusicFile newMusic;

        [TestInitialize]
        public void SetUp()
        {
            playList = new PlayList("My New Playlist");
            newMusic = new MusicFile("My Music", "My Track", Genre.Dance);
        }

        [TestMethod]
        public void AddANewTrackTest()
        {
            bool result = playList.addANewTrack(newMusic);
            Assert.IsTrue(result);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void AddANewTrackWhichAlreadyExistsTest()
        {
            playList.addANewTrack(newMusic);
            playList.addANewTrack(newMusic);
        }

        [TestMethod]
        public void IndexerTest()
        {
            MusicFile track2 = new MusicFile("new music", "new track", Genre.HipHop);
            MusicFile track3 = new MusicFile("new musics", "new tracks", Genre.HipHop);
            MusicFile track4 = new MusicFile("news musics", "news tracks", Genre.Dance);
            playList.addANewTrack(newMusic);
            playList.addANewTrack(track2);
            playList.addANewTrack(track3);
            playList.addANewTrack(track4);

            List<MusicFile> expectedMusic = new List<MusicFile> { track2, track3 };
            List<MusicFile> result = playList[Genre.HipHop];
            CollectionAssert.AreEqual(expectedMusic, result);

            expectedMusic = null;
            expectedMusic = new List<MusicFile> { newMusic, track4 };
            result = playList[Genre.Dance];
            CollectionAssert.AreEqual(expectedMusic, result);
        }

        [TestMethod]
        public void ClassEnumeration()
        {
            MusicFile track2 = new MusicFile("new music", "new track", Genre.HipHop);
            MusicFile track3 = new MusicFile("new musics", "new tracks", Genre.HipHop);
            MusicFile track4 = new MusicFile("news musics", "news tracks", Genre.Dance);
            playList.addANewTrack(newMusic);
            playList.addANewTrack(track2);
            playList.addANewTrack(track3);
            playList.addANewTrack(track4);
            int i = 0;
            foreach(var s in playList)
            {
                i++;
            }
            Assert.AreEqual(4, i);
        }
    }
}
