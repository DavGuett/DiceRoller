using System.Runtime.InteropServices;

Console.WriteLine("Hello, what is your name?");

string name = GetName();

Console.WriteLine(
    $"Hello {name}, press any key to roll the dice");
Console.ReadLine();

int playerRoll = RollDice();
int computerRoll = RollDice();

if (playerRoll == computerRoll)
{
    Console.WriteLine($"You both rolled {playerRoll}");
    Console.WriteLine("Draw");
} else if (playerRoll > computerRoll)
{
    Console.WriteLine($"You rolled {playerRoll} while the computer rolled {computerRoll}");
    Console.WriteLine("You win");
}
else
{
    Console.WriteLine($"You rolled {playerRoll} while the computer rolled {computerRoll}");
    Console.WriteLine("You lose");
}

static string GetName()
{
    string name = Console.ReadLine();
    return name;
}

static int RollDice()
{
    var number = new System.Random();
    
    return number.Next(1,7);
}