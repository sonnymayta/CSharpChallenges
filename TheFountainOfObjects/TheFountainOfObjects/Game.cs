using System;

namespace TheFountainOfObjects
{
    internal class Game
    {
        private Map _map;
        private Player _player;
        private bool _fountainStatus;

        public Game()
        {
            _map = new Map();
            _player = new Player(new Position(0, 0));
            _fountainStatus = false;
        }

        public void Star()
        {
            bool won = false;            
            _player.GetPosition();
            _map.GetRoomDescription(_player);
            while (!won)
            {
                Console.Write("What do you want to do? ");
                string action = Console.ReadLine() ?? "";
                PlayerAction(action);                
                _player.GetPosition();
                _map.GetRoomDescription(_player);
                won = IsVictory();
            }
        }

        private void PlayerAction(string action)
        {
            switch (action)
            {
                case "move north":
                    PlayerMove(-1, 0);
                    break;
                case "move east":
                    PlayerMove(0, 1);
                    break;
                case "move south":
                    PlayerMove(1, 0);
                    break;
                case "move west":
                    PlayerMove(0, -1);
                    break;
                case "enable fountain":
                    EnableFountain();
                    break;
                default:
                    break;
            }
        }

        private void PlayerMove(int horizontalMove, int verticalMove)
        {
            Position currentPosition = _player.Posicion;
            Position newPosition = new Position(currentPosition.Row + horizontalMove, currentPosition.Column + verticalMove);
            if (_map.IsValidPosition(newPosition))
            {
                _player.Posicion = newPosition;
                _map.SetPlayerPosition(_player);
            }
            else
            {
                Console.WriteLine("You can't move there. There's a wall.");
            }
        }

        private void EnableFountain()
        {
            List<IItem> items = _map.GetItemsRoom(_player);
            if (items != null)
            {
                IItem? item = items.FirstOrDefault(i => i.Name == "Fountain");
                if (item != null)
                {
                    item.Perception = "You hear the rushing waters from the Fountain of Objects. It has been reactivated!";
                    _fountainStatus = true;
                }
            }
        }

        private bool IsVictory()
        {
            if(_player.Posicion.Row == 0 && _player.Posicion.Column == 0 && _fountainStatus == true)
            {
                _player.GetPosition();
                Console.WriteLine("The Fountain of Objects has been reactivated, and you have escaped with your life!\nYou win!");
                return true;
            }            
            return false;
        }
    }
}
