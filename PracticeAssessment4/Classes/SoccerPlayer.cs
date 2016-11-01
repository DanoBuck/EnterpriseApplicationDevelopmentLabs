public enum Position
{
    Goalkeeper,
    Defender,
    Midfielder,
    Striker
}
namespace PracticeAssessment4.Classes
{
    public class SoccerPlayer : SportsPlayer
    {
        public Position Position { get; set; }

        public SoccerPlayer(string name, int age, GenderForTest gender, Position position) : base(name, age, gender)
        {
            Position = position;
        }

        public SoccerPlayer() : base("", 0, GenderForTest.Male)
        {
            Position = Position.Defender;
        }

        public override string ToString()
        {
            return base.ToString() + "\nPosition: " + Position; 
        }
    }
}
