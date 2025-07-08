namespace TicTacToe
{
    internal class Game
    {
        private readonly Board _board;
        private readonly Player _player1;
        private readonly Player _player2;
        private int _currentPlayerIndex = 1;
        private bool _isGameOver = false;

        public Game()
        {
            _board = new Board();
            _player1 = new Player('X');
            _player2 = new Player('O');
        }

        public void Start()
        {
            while (!_isGameOver && _currentPlayerIndex <= 9)
            {
                if (_currentPlayerIndex % 2 != 0)
                {
                    PlayerTurn(_player1);
                }
                else
                {
                    PlayerTurn(_player2);
                }
                _board.CheckWinner();
                _currentPlayerIndex++;
                CheckGameOver();
            }
        }        

        private void CheckGameOver()
        {
            if (_board.GetWinner() != '\0')
            {
                _isGameOver = true;
                _board.GetBoard();
                Console.WriteLine($"Game Over!");
            }
            else if (_currentPlayerIndex > 9)
            {
                _isGameOver = true;
                _board.GetBoard();
                Console.WriteLine("Game Over! It's a draw!");
            }
        }

        private void PlayerTurn(Player player)
        {
            Console.WriteLine($"It is {player.GetSymbol()}'s turn.");
            _board.GetBoard();
            _board.SetPlayerMove(player);
        }
    }
}
