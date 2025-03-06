namespace Watchtower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            int y = int.Parse(Console.ReadLine());

            if (x == 0 && y == 0) Console.WriteLine("The enemy is here");
            if (x == 0 && y > 0) Console.WriteLine("The enemy is in the N");
            if (x == 0 && y < 0) Console.WriteLine("The enemy is in the S");
            if (x > 0 && y == 0) Console.WriteLine("The enemy is in the E");
            if (x < 0 && y == 0) Console.WriteLine("The enemy is in the W");
            if (x > 0 && y > 0) Console.WriteLine("The enemy is in the NE");
            if (x > 0 && y < 0) Console.WriteLine("The enemy is in the SE");
            if (x < 0 && y > 0) Console.WriteLine("The enemy is in the NW");
            if (x < 0 && y < 0) Console.WriteLine("The enemy is in the SW");
        }
    }
}
