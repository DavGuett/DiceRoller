namespace DiceRoller;

public class DiceRoller
{
    public static int RollDice()
    {
        var number = new System.Random();
    
        return number.Next(1,7);
    }
}