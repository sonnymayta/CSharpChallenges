namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CPlayer playerOne = new CPlayer("Player 1", State.Undefined);
            CPlayer playerTwo = new CPlayer("Player 2", State.Undefined);
            CGame game = new CGame();
            for (int i = 0; i < 10; i++)
            {
                playerOne.SetState();
                playerTwo.SetState();
                game.Round(playerOne, playerTwo);
            }
            game.ShowScore();
        }
    }
}
