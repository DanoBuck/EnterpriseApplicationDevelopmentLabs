using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum GenderForTest
{
    Male,
    Female
}

namespace PracticeAssessment4.Classes
{
    public abstract class SportsPlayer
    {
        public string PlayerName { get; set; }
        public int PlayersAge { get; set; }
        public GenderForTest Gender { get; set; }

        protected SportsPlayer(string nameIn, int ageIn, GenderForTest gernderIn)
        {
            PlayerName = nameIn;
            PlayersAge = ageIn;
            Gender = gernderIn;
        }

        public override string ToString()
        {
            return "Player Name: " + PlayerName + "\nPlayer Age: " + PlayersAge + "\nGender: " + Gender;
        }
    }
}
