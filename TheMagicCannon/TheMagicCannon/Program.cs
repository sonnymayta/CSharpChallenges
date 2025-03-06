namespace TheMagicCannon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{i}: Electric and Fire");
                }
                else
                {
                    if (i % 3 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{i}: Fire");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"{i}: Electric");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"{i}: Normal");
                    }
                }                               
            }
        }
    }
}
