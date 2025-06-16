namespace Hangman
{
    internal class Player(string name)
    {
        private readonly string _name = name;
        private int _incorrectGuesses = 0;
        private int _numberOfIntents = 0;
        private string _incorrectLetters = string.Empty;
        private string _guessedLetters = string.Empty;

        public void AddIncorrectGuess() => _incorrectGuesses++;

        public void AddIntent() => _numberOfIntents++;

        public void AddIncorrectLetter(string letter) => _incorrectLetters += letter;

        public void AddGuessedLetter(string letter) => _guessedLetters += letter;

        public string GetIncorrectLetters() => _incorrectLetters;

        public string GetGuessedLetters() => _guessedLetters;

        public int GetIncorrectGuesses() => _incorrectGuesses;

        public void GetScore()
        {
            Console.WriteLine($"Player: {_name}");
            Console.WriteLine($"Incorrect Guesses: {_incorrectGuesses}");
            Console.WriteLine($"Number of Intents: {_numberOfIntents}");
        }
    }
}
