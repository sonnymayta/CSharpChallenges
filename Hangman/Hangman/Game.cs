using System.Text;

namespace Hangman
{
    internal class Game(string wordToGuess)
    {
        private readonly string _wordToGuess = wordToGuess;
        private readonly int _maxAttempts = 5;
        private Player _player = new("Player");

        public void Start()
        {
            SetTheGame();
            Play();
            ShowScore();
        }

        private void SetTheGame()
        {
            Console.Write("Introduce your name: ");
            string playerName = Console.ReadLine() ?? "Player";
            _player = new Player(playerName);
        }

        private void Play()
        {
            while (IsWordGuessed(_player.GetGuessedLetters()) == false && _player.GetIncorrectGuesses() < _maxAttempts)
            {
                Console.Write($"\nWord: {GetMaskedWord(_player.GetGuessedLetters())} | Remaining: {_maxAttempts - _player.GetIncorrectGuesses()} | Incorrect: {_player.GetIncorrectLetters()} | Guess: ");
                char guess = Console.ReadKey().KeyChar;
                IsLetterInWord(guess);
            }            
        }

        private string GetMaskedWord(string guessedLetters)
        {
            StringBuilder maskedWord = new();
            foreach (char letter in _wordToGuess)
            {
                if (guessedLetters.Contains(letter))
                {
                    maskedWord.Append(letter);
                }
                else
                {
                    maskedWord.Append('_');
                }
            }
            return maskedWord.ToString();
        }

        private bool IsWordGuessed(string guessedLetters)
        {
            return _wordToGuess.All(guessedLetters.Contains);
        }

        private bool IsLetterInWord(char letter)
        {
            if (_wordToGuess.Contains(letter))
            {
                _player.AddGuessedLetter(letter.ToString());
                _player.AddIntent();
                return true;
            }
            else
            {
                _player.AddIncorrectLetter(letter.ToString());
                _player.AddIncorrectGuess();
                _player.AddIntent();
                return false;
            }
        }

        private void ShowScore()
        {
            Console.WriteLine($"\nWord: {_wordToGuess}");
            _player.GetScore();            
            if (IsWordGuessed(_player.GetGuessedLetters()))
            {
                Console.WriteLine("Congratulations! You've guessed the word!");
            }
            else
            {
                Console.WriteLine("Game Over! Better luck next time.");
            }
        }
    }
}
