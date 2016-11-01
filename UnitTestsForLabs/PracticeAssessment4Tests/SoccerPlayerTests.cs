using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeAssessment4.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsForLabs.PracticeAssessment4Tests
{
    [TestClass]
    public class SoccerPlayerTests
    {
        private SoccerPlayer player;

        [TestInitialize]
        public void SetUp()
        {
            player = new SoccerPlayer("Daniel Buckley", 21, GenderForTest.Male, Position.Defender);
        }

        [TestMethod]
        public void ToStringTest()
        {
            string expectedResult = "Player Name: Daniel Buckley\nPlayer Age: 21\nGender: Male\nPosition: Defender";
            string result = player.ToString();

            Assert.AreEqual(expectedResult, result);
        }
    }
}
