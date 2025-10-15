namespace TheFountainOfObjects
{
    internal class Map
    {
        private char[,] _map;
        private List<Room> _rooms;
        private Room? _currentRoom;

        public Map()
        {
            _map = new char[4, 4];
            _rooms = SetRooms();            
        }

        public void GetMap()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"[{(_map[i, j] != '\0' ? _map[i, j] : '_')}]");
                }
                Console.WriteLine();
            }
        }

        public void SetPlayerPosition(Player player)
        {
            Array.Clear(_map);
            _map[player.Posicion.Row, player.Posicion.Column] = 'P';
        }

        public void GetRoomDescription(Player player)
        {
            SetCurrentRoom(player);
            if (_currentRoom != null)
            {
                foreach (var item in _currentRoom.Items)
                {
                    Console.WriteLine(item.Perception);
                }
            }            
        }

        public bool IsValidPosition(Position position)
        {
            if (position.Row >= 0 && position.Row < _map.GetLength(0) && position.Column >= 0 && position.Column < _map.GetLength(1)) return true;
            else return false;
        }

        public List<IItem> GetItemsRoom(Player player)
        {
            SetCurrentRoom(player);
            if ( _currentRoom != null )
            {
                return _currentRoom.Items;
            }
            return [];
        }

        private void SetCurrentRoom(Player player)
        {
            _currentRoom = _rooms.FirstOrDefault(r => r.Position.Row == player.Posicion.Row && r.Position.Column == player.Posicion.Column);
        }

        private List<Room> SetRooms()
        {
            return new List<Room>
            {
                new Room(new Position(0, 0), string.Empty, new List<IItem> { new CavernEntrance() }),
                new Room(new Position(0, 2), string.Empty, new List<IItem> { new Fountain() })
            };
        }
    }

}
