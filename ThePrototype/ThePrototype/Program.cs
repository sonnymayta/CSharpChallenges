namespace ThePrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.Write("User 1, enter a number between 0 and 100: ");
                number = int.Parse(Console.ReadLine());
            } while (number < 0 || number > 100);

            Console.Clear();

            int guessNumber;
            Console.WriteLine("User 2, guess the number.");

            do
            {
                Console.Write("\nWhat is your next guess? ");
                guessNumber = int.Parse(Console.ReadLine());
                if (guessNumber > number)
                {
                    Console.WriteLine($"{guessNumber} is to high.");
                }
                if (guessNumber < number)
                {
                    Console.WriteLine($"{guessNumber} is to low.");
                }
            } while (guessNumber != number);

            Console.WriteLine("you guest the number.");
        }
    }
}
