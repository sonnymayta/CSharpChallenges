namespace BuyingInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string catalog = "The following items are available:\r\n1 – Rope\r\n2 – Torches\r\n3 – Climbing Equipment\r\n4 – Clean Water\r\n5 – Machete\r\n6 – Canoe\r\n7 – Food Supplies\r\nWhat number do you want to see the price of?: ";
            Console.Write(catalog);
            int itemNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nWhat is your name?: ");
            string name = Console.ReadLine().ToUpper().Trim();

            string itemName = itemNumber switch
            {
                1 => "Rope",
                2 => "Torches",
                3 => "Climbing Equipment",
                4 => "Clean Water",
                5 => "Machete",
                6 => "Canoe",
                7 => "Food Supplies",
                _ => string.Empty
            };

            double itemPrice = itemName switch
            {
                "Rope" => 10,
                "Torches" => 16,
                "Climbing Equipment" => 24,
                "Clean Water" => 2,
                "Machete" => 20,
                "Canoe" => 200,
                "Food Supplies" => 1,
                _ => 0
            };            

            if (string.IsNullOrEmpty(itemName))
            {
                Console.WriteLine("Invalid value");
            }
            else
            {
                double priceWhitDiscount = name == "SONNY" ? itemPrice * 0.5 : itemPrice;
                Console.WriteLine($"{itemName} ${priceWhitDiscount}");
            }                
        }
    }
}
