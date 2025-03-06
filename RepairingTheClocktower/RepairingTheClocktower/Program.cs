namespace RepairingTheClocktower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number: ");            
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                number = 0;
                throw;
            }
            
            if (number % 2 == 0)
            {
                Console.WriteLine("Tick");
            }
            else
            {
                Console.WriteLine("Tock");
            }
        }
    }
}
