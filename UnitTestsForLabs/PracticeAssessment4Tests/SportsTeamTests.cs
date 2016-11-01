using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeAssessment4.Classes;
using System;

namespace UnitTestsForLabs.PracticeAssessment4Tests
{
    [TestClass]
    public class SportsTeamTests
    {
        private SoccerTeam team;

        [TestInitialize]
        public void SetUp()
        {
            team = new SoccerTeam("My Team", GenderForTest.Male, 8);
        }

        [TestMethod]
        public void AddPlayerTest()
        {
            SoccerPlayer newPlayer = new SoccerPlayer("Daniel Buckley", 21, GenderForTest.Male, Position.Defender);
            bool result = team.AddPlayer(newPlayer);
            Assert.IsTrue(result);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void AgeLimitTest()
        {
            team = null;
            team = new SoccerTeam("", GenderForTest.Male, 2);
        }

        [TestMethod]
        public void IteratorTest()
        {
            SoccerPlayer newPlayer1 = new SoccerPlayer("Daniel Buckley", 21, GenderForTest.Male, Position.Goalkeeper);
            SoccerPlayer newPlayer2 = new SoccerPlayer("Dano", 22, GenderForTest.Male, Position.Defender);
            SoccerPlayer newPlayer3 = new SoccerPlayer("Daniel", 23, GenderForTest.Male, Position.Striker);
            team.AddPlayer(newPlayer1);
            team.AddPlayer(newPlayer2);
            team.AddPlayer(newPlayer3);
            SoccerPlayer resultPlayer = team["DaNiel Buckley"];

            Assert.AreEqual(resultPlayer.PlayerName, newPlayer1.PlayerName);
            Assert.AreEqual(resultPlayer.PlayersAge, newPlayer1.PlayersAge);
            Assert.AreEqual(resultPlayer.Gender, newPlayer1.Gender);
            Assert.AreEqual(resultPlayer.Position, newPlayer1.Position);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void IteratorTest2()
        {
            SoccerPlayer resultPlayer = team["Daniel Buckley"];
        }

        [TestMethod]
        public void IsClassEnumerable()
        {
            SoccerPlayer newPlayer1 = new SoccerPlayer("Daniel Buckley", 21, GenderForTest.Male, Position.Goalkeeper);
            SoccerPlayer newPlayer2 = new SoccerPlayer("Dano", 22, GenderForTest.Male, Position.Defender);
            SoccerPlayer newPlayer3 = new SoccerPlayer("Daniel", 23, GenderForTest.Male, Position.Striker);
            team.AddPlayer(newPlayer1);
            team.AddPlayer(newPlayer2);
            team.AddPlayer(newPlayer3);
            int counter = 0;
            foreach (SoccerPlayer player in team)
            {
                counter++;
            }
            Assert.AreEqual(3, counter);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void AddInDifferentGender()
        {
            SoccerPlayer newPlayer1 = new SoccerPlayer("Daniel Buckley", 21, GenderForTest.Male, Position.Goalkeeper);
            SoccerPlayer newPlayer2 = new SoccerPlayer("Dano", 22, GenderForTest.Male, Position.Defender);
            SoccerPlayer newPlayer3 = new SoccerPlayer("Daniel", 23, GenderForTest.Female, Position.Striker);
            team.AddPlayer(newPlayer1);
            team.AddPlayer(newPlayer2);
            team.AddPlayer(newPlayer3);
        }
    }
}
