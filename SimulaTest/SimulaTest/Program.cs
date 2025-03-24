namespace SimulaTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userAction;
            bool active = true;

            StateChest current = StateChest.Locked;

            do
            {
                Console.Write($"The chest is {current}. What do you want to do? ");
                userAction = Console.ReadLine();
                if (userAction == "open")
                {
                    if (current == StateChest.Unlocked)
                    {
                        current = StateChest.Open;
                    }
                }
                else if (userAction == "close")
                {
                    if (current == StateChest.Open)
                    {
                        current = StateChest.Unlocked;
                    }
                }
                else if (userAction == "lock")
                {
                    if (current == StateChest.Unlocked)
                    {
                        current = StateChest.Locked;
                    }
                }
                else if (userAction == "unlock")
                {
                    if (current == StateChest.Locked)
                    {
                        current = StateChest.Unlocked;
                    }
                }
                else { active = false; }
            } while (active);
        }

        enum StateChest { Open, Locked, Unlocked };
    }
}
