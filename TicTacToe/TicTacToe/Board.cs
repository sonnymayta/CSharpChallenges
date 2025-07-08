namespace TicTacToe
{
    internal class Board
    {
        private char[] _boardGame = new char[9];
        private int _currentPosition;
        private char _currentPlayerSymbol;
        private char _winner;

        public void GetBoard()
        {
            for (int i = 0; i < _boardGame.Length; i++)
            {
                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine($"[{GetCellSymbol(i)}]");
                }
                else
                {
                    Console.Write($"[{GetCellSymbol(i)}]");
                }
            }
        }

        public void SetPlayerMove(Player player)
        {
            _currentPlayerSymbol = player.GetSymbol();
            do
            {
                Console.Write($"What square do you want to play in? ");
                _currentPosition = ReadPlayerInput();
            } while (!IsValidMove());
            RegisterMove();
            Console.Clear();
        }

        public void CheckWinner()
        {
            if ((_boardGame[0] == _currentPlayerSymbol && _boardGame[1] == _currentPlayerSymbol && _boardGame[2] == _currentPlayerSymbol) ||
                (_boardGame[3] == _currentPlayerSymbol && _boardGame[4] == _currentPlayerSymbol && _boardGame[5] == _currentPlayerSymbol) ||
                (_boardGame[6] == _currentPlayerSymbol && _boardGame[7] == _currentPlayerSymbol && _boardGame[8] == _currentPlayerSymbol) ||
                (_boardGame[0] == _currentPlayerSymbol && _boardGame[3] == _currentPlayerSymbol && _boardGame[6] == _currentPlayerSymbol) ||
                (_boardGame[1] == _currentPlayerSymbol && _boardGame[4] == _currentPlayerSymbol && _boardGame[7] == _currentPlayerSymbol) ||
                (_boardGame[2] == _currentPlayerSymbol && _boardGame[5] == _currentPlayerSymbol && _boardGame[8] == _currentPlayerSymbol) ||
                (_boardGame[0] == _currentPlayerSymbol && _boardGame[4] == _currentPlayerSymbol && _boardGame[8] == _currentPlayerSymbol) ||
                (_boardGame[2] == _currentPlayerSymbol && _boardGame[4] == _currentPlayerSymbol && _boardGame[6] == _currentPlayerSymbol))
            {
                Console.WriteLine($"Congratulations! Player {_currentPlayerSymbol} wins!");
                _winner = _currentPlayerSymbol;
            }
        }

        public char GetWinner()
        {
            return _winner;
        }

        private void RegisterMove()
        {
            _boardGame[ConvertPosition(_currentPosition)] = _currentPlayerSymbol;
        }

        private int ConvertPosition(int position)
        {
            if (position >= 1 && position <= 3)
            {
                return position + 5;
            }
            else if (position >= 4 && position <= 6)
            {
                return position - 1;
            }
            else if (position >= 7 && position <= 9)
            {
                return position - 7;
            }
            return -1;
        }

        private int ReadPlayerInput()
        {
            char position = Console.ReadKey().KeyChar;
            if (char.IsDigit(position)) return position - '0';
            return -1;
        }

        private bool IsValidMove()
        {
            if (!IsValidNumber()) return false;
            if (!IsValidCell()) return false;
            return true;
        }

        private bool IsValidNumber()
        {
            if (_currentPosition >= 1 && _currentPosition <= 9) return true;
            else
            {
                Console.WriteLine("\nInvalid move. Please enter a number between 1 and 9.");
                return false;
            }
        }

        private bool IsValidCell()
        {
            if (_boardGame[ConvertPosition(_currentPosition)] == '\0') return true;
            else
            {
                Console.WriteLine("\nInvalid cell. Please choose an empty cell.");
                return false;
            }
        }

        private char GetCellSymbol(int position)
        {
            if (_boardGame[position] == '\0')
            {
                return ' ';
            }
            return _boardGame[position];
        }
    }
}
