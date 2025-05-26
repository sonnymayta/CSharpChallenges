using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class CGame
    {
        private int _rounds = 0;

        private int _playerOneScore = 0;

        private int _playerTwoScore = 0;

        public void Round(CPlayer playerOne, CPlayer playerTwo)
        {
            _rounds++;
            if (playerOne.State == playerTwo.State)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((playerOne.State == State.Rock && playerTwo.State == State.Scissor) ||
                     (playerOne.State == State.Scissor && playerTwo.State == State.Paper) ||
                     (playerOne.State == State.Paper && playerTwo.State == State.Rock))
            {
                Console.WriteLine($"{playerOne.Name} wins!");
                _playerOneScore++;
            }
            else
            {
                Console.WriteLine($"{playerTwo.Name} wins!");
                _playerTwoScore++;
            }
        }

        public void ShowScore()
        {
            Console.WriteLine($"Rounds: {_rounds}");
            Console.WriteLine($"{_playerOneScore} - {_playerTwoScore}");
            if (_playerOneScore > _playerTwoScore)
            {
                Console.WriteLine("Player 1 is the winner!");
            }
            else if (_playerTwoScore > _playerOneScore)
            {
                Console.WriteLine("Player 2 is the winner!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
    }
}
