namespace Tennis.Game
{
    public class TennisGame : ITennisGame
    {
        private int _player1Score = 0;
        private int _player2Score = 0;
        private readonly string _player1Name;
        private readonly string _player2Name;

        public TennisGame(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == _player1Name)
                _player1Score++;
            else if (playerName == _player2Name)
                _player2Score++;
        }

        public string GetScore()
        {
            if (_player1Score == _player2Score) {
                return new DrawResult(_player1Score, _player2Score).GetScoreName();
            }
            else if (_player1Score >= 4 || _player2Score >= 4) {
                return new AdvantageOrWinResult(_player1Score, _player2Score).GetScoreName();
            }
            else {
                return new OngoingResult(_player1Score, _player2Score).GetScoreName();
            }
        }
    }
}
