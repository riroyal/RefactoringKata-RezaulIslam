namespace Tennis.Game
{
    public class DrawResult : Game
    {
        public DrawResult(int player1Score, int player2Score) : base(player1Score, player2Score)
        {
        }

        public override string GetScoreName()
        {
            return _player1Score switch
            {
                0 => "Love-All",
                1 => "Fifteen-All",
                2 => "Thirty-All",
                _ => "Deuce"
            };
        }
    }
}
