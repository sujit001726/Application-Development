class Program
{
    static void Main()
    {
        // 1. Create a list with 3 favorite fruits
        List<string> fruits = new List<string> { "Mango", "Apple", "Banana" };

        // 2. Add a new fruit
        fruits.Add("Orange");

        // 3. Remove one fruit
        fruits.Remove("Banana");

        // 4. Print all fruits using a foreach loop
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // 5. Create a dictionary with fruit IDs and names
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>();
        fruitDictionary.Add(1, "Mango");
        fruitDictionary.Add(2, "Apple");
        fruitDictionary.Add(3, "Banana");

        // 6. Add a new entry and print all key-value pairs
        fruitDictionary.Add(4, "Orange");

        foreach (KeyValuePair<int, string> item in fruitDictionary)
        {
            Console.WriteLine("ID " + item.Key + " = " + item.Value);
        }
    }
}