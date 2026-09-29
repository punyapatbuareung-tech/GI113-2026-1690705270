/*
* Student ID : 1690705270
* Name       : Punyapat Bouruang
* Section    : 129B
* No.        : 39
* Course     : GI113 Computer Programming (GI)
*/

Console.WriteLine("I=======The coin has been tossed=======I");
Console.WriteLine("Heads or Tails ");
Console.WriteLine("1 For Heads | 2 For Tails");
Console.Write("Enter your choice: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int playerChoice);
if (isNumber && (playerChoice == 1 || playerChoice == 2))
{
    Random rng = new Random();
    int coin = rng.Next(1, 3);
    bool Win = (playerChoice == coin);
    if (coin == 1)
    {
        Console.WriteLine("Heads");
    }
    else
    {
        Console.WriteLine("Tails");
    }
    if (Win)
    {
        Console.WriteLine("You Win!");
    }
    else
    {
        Console.WriteLine("You Lose!");
    }
}
else
{
    Console.WriteLine("Please enter either 1 or 2.");
}