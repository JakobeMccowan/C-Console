
class Dictonary1
{
    public static void Dict1(string[] args)
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        phoneBook.Add("Alice", "123-456-7890");
        phoneBook.Add("Bob", "987-654-3210");

        Console.WriteLine(phoneBook ["Alice"]);
    }

    public static void Dict2(string[] args)
    {
        Dictionary<string, int> inventory = new Dictionary<string, int>();

        inventory.Add("Apple", 50);
        inventory.Add("Orange", 30);
        inventory.Add("Banana", 20);
        inventory.Add("Mangos", 40);
        inventory.Add("Grapes", 35);

        foreach(KeyValuePair<string, int> items in inventory)
        {
            Console.WriteLine(items.Key + ": " + items.Value);
        }
    }
}
