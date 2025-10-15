namespace TheFountainOfObjects
{
    public class Room
    {
        public List<IItem> Items { get; set; }
        public Position Position { get; }
        public string Description { get; set; }

        public Room(Position position, string description, List<IItem> items)
        {
            Items = items;
            Position = position;
            Description = description;
        }        
    }
}
