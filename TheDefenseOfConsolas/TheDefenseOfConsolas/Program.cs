namespace TheDefenseOfConsolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            int choice;
            while (isRunning)
            {
                Console.Clear();
                Console.Title = "The Defense of Consolas";
                Console.WriteLine("The Defense of Consolas");
                Console.WriteLine("1. Start Game");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            int row;
                            int col;
                            int top;
                            int right;
                            int bottom;
                            int left;
                            Console.Write("Target Row? ");
                            row = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Target Col? ");
                            col = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Deploy to: ");
                            right = col + 1;
                            top = row + 1;
                            left = col - 1;
                            bottom = row - 1;
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Beep(800, 500);
                            Console.WriteLine($"({row}, {left})");
                            Console.WriteLine($"({bottom}, {col})");
                            Console.WriteLine($"({row}, {right})");
                            Console.WriteLine($"({top}, {col})");
                            Console.ReadKey(true);
                            break;
                        case 2:
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("\nInvalid choice.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey(true);
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nInvalid character.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);
                }                               
            }
        }        
    }
}
