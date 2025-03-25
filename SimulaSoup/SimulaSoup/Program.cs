namespace SimulaSoup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.NoDefined;
            MainIngredient mainIngredient = MainIngredient.NoDefined;
            Seasoning seasoning = Seasoning.NoDefined;
            int number;

            Console.WriteLine("Build your soup. Enter de number");
            Console.WriteLine("Type:\n1. Soup\n2. Stew\n3. Gumbo");
            number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    type = Type.Soup;
                    break;
                case 2:
                    type = Type.Stew;
                    break;
                case 3:
                    type = Type.Gumbo;
                    break;
                default:
                    break;
            }
            
            Console.WriteLine("Main ingredient:\n1. Mushroom\n2. Chicken\n3. Carrot\n4. Potatoes");
            number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    mainIngredient = MainIngredient.Mushroom;
                    break;
                case 2:
                    mainIngredient = MainIngredient.Chicken;
                    break;
                case 3:
                    mainIngredient = MainIngredient.Carrot;
                    break;
                case 4:
                    mainIngredient = MainIngredient.Potatoes;
                    break;
                default:
                    break;
            }

            Console.WriteLine("Seasoning:\n1. Spicy\n2. Salty\n3. Sweet");
            number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    seasoning = Seasoning.Spicy;
                    break;
                case 2:
                    seasoning = Seasoning.Salty;
                    break;
                case 3:
                    seasoning = Seasoning.Sweet;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Your soup: {seasoning} {mainIngredient} {type}");
        }

        enum Type { NoDefined, Soup, Stew, Gumbo }

        enum MainIngredient { NoDefined, Mushroom, Chicken, Carrot, Potatoes }

        enum Seasoning { NoDefined, Spicy, Salty, Sweet }
    }
}
