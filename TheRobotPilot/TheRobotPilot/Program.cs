int cityHealth = 15;
int manticoreHealth = 10;
int round = 1;

Random random = new Random();
int range = random.Next(100);

while (cityHealth > 0 && manticoreHealth > 0)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("-------------------------------------------------------------");
    DisplayStatus(round, cityHealth, manticoreHealth);
    int damage = DamageForRound(round);
    Console.WriteLine($"The cannon is expecto to deal {damage} damage this round.");
    Console.ForegroundColor = ConsoleColor.White;
    int targetRange = AskForNumber("Enter desired cannon range:");
    Console.ForegroundColor = ConsoleColor.Magenta;
    DisplayOverOrUnder(targetRange, range);
    if (targetRange == range) manticoreHealth -= damage;
    if (manticoreHealth > 0) cityHealth--;
    round++;
}

bool won = cityHealth > 0;
DisplayWinOrLose(won);

void DisplayWinOrLose(bool won)
{
    if (won)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The city has been destroyed. The Manticore and the Uncoded One have won.");
    }    
}
void DisplayOverOrUnder(int targetRange, int range)
{
    if (targetRange < range) Console.WriteLine("That round FELL SHORT of the target.");
    else if (targetRange > range) Console.WriteLine("That round OVERSHOT the target.");
    else Console.WriteLine("That round was a DIRECT HIT!");
}

void DisplayStatus(int round, int cityHealth, int manticoreHealth)
{
    Console.WriteLine($"STATUS: Round: {round}  City: {cityHealth}/15  Manticore: {manticoreHealth}/10");
}

int DamageForRound(int roundNumber)
{
    if (roundNumber % 5 == 0 && roundNumber % 3 == 0) return 10; // Combined Electric and Fire
    else if (roundNumber % 5 == 0) return 3; // Electric
    else if (roundNumber % 3 == 0) return 3; // Fire
    return 1; // Normal.
}

int AskForNumber(string text)
{
    Console.Write(text + " ");
    Console.ForegroundColor = ConsoleColor.Cyan;
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}