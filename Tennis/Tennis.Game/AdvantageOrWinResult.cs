namespace Tennis.Game
{
    public class AdvantageOrWinResult : Game
    {
        public AdvantageOrWinResult(int player1Score, int player2Score) : base(player1Score, player2Score)
        {
        }

        public override string GetScoreName()
        {
            var scoreDifference = _player1Score - _player2Score;

            var player1Name = "player1";
            var player2Name = "player2";

            return scoreDifference switch
            {
                1 => $"Advantage {player1Name}",
                -1 => $"Advantage {player2Name}",
                >= 2 => $"Win for {player1Name}",
                _ => $"Win for {player2Name}"
            };
        }
    }
}
