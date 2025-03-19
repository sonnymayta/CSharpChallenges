namespace HuntingTheManticore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int manticoreMaxHealth = 10;
            int manticoreHealth = 10;
            int cityMaxHealth = 15;
            int cityHealth = 15;
            int round = 1;
            int manticoreDistance;
            int cannonDistance;
            int cannonDamage;
            Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
            manticoreDistance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlayer 2, it is your turn.");
            do
            {                
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine($"STATUS: Round {round}  City: {cityHealth}/{cityMaxHealth}  Manticore: {manticoreHealth}/{manticoreMaxHealth}");
                cannonDamage = CannonDamage(round);
                Console.Write("Enter desired cannon range: ");
                cannonDistance = Convert.ToInt32(Console.ReadLine());
                if (CannonHit(manticoreDistance, cannonDistance))
                {
                    manticoreHealth = manticoreHealth - cannonDamage;
                }
                if (manticoreHealth > 0)
                {
                    cityHealth = cityHealth - 1;
                }
                round++;
            } while (manticoreHealth > 0 && cityHealth > 0);

            if (manticoreHealth == 0) Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
            if (cityHealth == 0) Console.WriteLine("The city has been destroyed by The Manticore!");

            int CannonDamage(int round)
            {
                if (round % 3 == 0 && round % 5 == 0)
                {
                    Console.WriteLine("The cannon is expected to deal 10 damage this round.");
                    return 10;
                }
                else if (round % 3 == 0 || round % 5 == 0)
                {
                    Console.WriteLine("The cannon is expected to deal 3 damage this round.");
                    return 3;
                }
                else
                {
                    Console.WriteLine("The cannon is expected to deal 1 damage this round.");
                    return 1;
                }

            }

            bool CannonHit(int manticoraDistance, int cannonDistance)
            {
                if (cannonDistance == manticoraDistance)
                {
                    Console.WriteLine("That round was a DIRECT HIT!");
                    return true;
                }
                else if (cannonDistance > manticoraDistance)
                {
                    Console.WriteLine("That round OVERSHOT the target.");
                    return false;
                }
                else
                {
                    Console.WriteLine("That round FELL SHORT of the target.");
                    return false;
                }
            }
        }
    }
}
