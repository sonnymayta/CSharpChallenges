namespace TicTacToe
{
    internal class Player(char symbol)
    {
        private readonly char _symbol = symbol;

        public char GetSymbol()
        {
            return _symbol;
        }
    }

}
