namespace Countdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintCountdown(10);

            void PrintCountdown(int n)
            {
                if (n == 1) Console.WriteLine("1");
                else
                {
                    Console.WriteLine(n);
                    PrintCountdown(n - 1);
                }
            }
        }        
    }
}
