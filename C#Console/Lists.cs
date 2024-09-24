class List
{
    public static void Eaiou(string[] args)
    {
        List<string> fruits = new List<string>();
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Orange");
        fruits.Add("Grapes");
        fruits.Add("Mango");
        fruits.Remove("Banana");
        fruits.RemoveAt(2);
        fruits.Insert(1, "Pineapple");

        int numberOfFruits = fruits.Count;
        Console.WriteLine("The list contains " + numberOfFruits + " fruits. ");


        int indexOfOrange = fruits.IndexOf("Orange");
        Console.WriteLine("Orange is at index" + indexOfOrange);
    }
}

