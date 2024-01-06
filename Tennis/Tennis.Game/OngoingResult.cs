namespace Tennis.Game
{
    public class OngoingResult : Game
    {
        public OngoingResult(int player1Score, int player2Score) : base(player1Score, player2Score)
        {
        }

        public override string GetScoreName()
        {
            return $"{GetScore(_player1Score)}-{GetScore(_player2Score)}";

            static string GetScore(int score)
            {
                return score switch
                {
                    0 => "Love",
                    1 => "Fifteen",
                    2 => "Thirty",
                    3 => "Forty",
                    _ => throw new ArgumentOutOfRangeException(nameof(score), "Invalid score")
                };
            }
        }
    }
}
