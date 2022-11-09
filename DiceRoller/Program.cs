using System.Runtime.InteropServices;

Console.WriteLine("Hello, what is your name?");

string name = GetName();

Console.WriteLine(
    $"Hello {name}, press any key to roll the dice");
Console.WriteLine(RollDice());

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