
class Character
{
    public string name = "Shara";
    public int health;
    public int strength;

    public static void Players()
    {
        Character player = new Character();
        player.name = "Jakobe";
        player.health = 100;
        player.strength = 100;

        Character player1 = new Character();
        player1.name = "Tom";
        player1.health = 50;
        player1.strength = 50;

        Console.WriteLine("Player name: " + player.name);
    }

}