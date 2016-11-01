
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAssessment4.Classes
{
    public class SoccerTeam : IEnumerable
    {
        private int ageLimit;

        public string TeamName { get; set; }
        public GenderForTest TeamGender { get; set; }
        public int AgeLimit
        {
            get
            {
                return ageLimit;
            }
            set
            {
                if(ageLimit > 5)
                {
                    ageLimit = value;
                }
                else
                {
                    throw new ArgumentException("Age is too young");
                }
            }
        }
        public List<SoccerPlayer> Players { get; set; }

        public SoccerTeam(string teamName, GenderForTest teamsGender, int ageLimitin)
        {
            TeamName = teamName;
            TeamGender = teamsGender;
            ageLimit = ageLimitin;
            AgeLimit = ageLimit;
            Players = new List<SoccerPlayer>();
        }

        public bool AddPlayer(SoccerPlayer newPlayer)
        {
            bool added = false;
            if (newPlayer.PlayerName != "" && newPlayer.PlayerName != null
                && newPlayer.PlayersAge > 5 && newPlayer.PlayersAge < 50
                && newPlayer.Gender == TeamGender)
            {
                Players.Add(newPlayer);
                added = true;
            }
            else
            {
                throw new ArgumentException("Error");
            }
            return added;
        }

        public SoccerPlayer this[string playerName]
        {
            get
            {
                var player = Players.Where(x => x.PlayerName.Equals(playerName, StringComparison.CurrentCultureIgnoreCase));
                if (player.Count() == 0)
                {
                    throw new ArgumentOutOfRangeException("No player found");
                }
                return player.Single();
            }
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)Players).GetEnumerator();
        }
    }
}
