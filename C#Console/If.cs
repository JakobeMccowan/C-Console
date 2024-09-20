
class If 
{
    public static void IfElse(int number)
    {

        if(number > 0)
        {
            Console.WriteLine("The Number is positive");
        }
        else if(number < 0)
        {
            Console.WriteLine("The Number is negative");
        }
        else
        {
            Console.WriteLine("Your Number is zero");
        }
    }

    public static void Life()
    {
        int health = -2;

        if(health > 75)
        {
            Console.WriteLine("The player is in great condition!");
        }
        else if(health > 50 )
        {
            Console.WriteLine("The player is in good condition.");
        }
        else if(health < 50)
        {
            Console.WriteLine("The player is in danger!");
        }
        else if(health <= 1)
        {
            Console.WriteLine("Game Over");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}