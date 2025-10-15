namespace TheFountainOfObjects
{
    public class Player : Entity
    {
        public Player(Position posicion) : base(posicion)
        {

        }

        public void GetPosition()
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"You are in the room at ({Posicion}).");
        }
    }
}
