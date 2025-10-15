namespace TheFountainOfObjects
{
    public interface IItem
    {
        string Name { get; }
        string Perception { get; set; }
    }

    public class Fountain : IItem
    {
        public string Name { get; } = "Fountain";
        public string Perception { get; set; } = "You hear water dripping in this room. The Fountain of Objects is here!";
    }

    public class  CavernEntrance : IItem
    {
        public string Name { get; } = "Cavern Entrace";
        public string Perception { get; set; } = "You see light coming from the cavern entrance.";
    }
}
