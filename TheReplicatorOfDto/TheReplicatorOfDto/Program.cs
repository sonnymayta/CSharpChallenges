namespace TheReplicatorOfDto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter the number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int[] numbersCopy = numbers[0..];

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            foreach (var number in numbersCopy)
            {
                Console.WriteLine(number);
            }
        }
    }
}
