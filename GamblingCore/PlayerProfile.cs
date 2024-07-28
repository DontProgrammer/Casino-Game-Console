namespace GamblingGame.GamblingCore
{
    public record PlayerProfile
    {
        public string Username { get; private set; }
        public int Money { get; private set; }
        public int Wins { get; private set; }
        public int Loses { get; private set; }
    }
}
