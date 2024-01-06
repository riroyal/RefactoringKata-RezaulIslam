namespace Tennis.Game
{
    public abstract class Game
    {
        public int _player1Score;
        public int _player2Score;
        public Game(int player1Score, int player2Score)
        {
            _player1Score = player1Score;
            _player2Score = player2Score;   
        }

        public abstract string GetScoreName();
    }
}
