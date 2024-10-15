class Shoppinglist
{
    static void Main(string[] args)
    {   // menu
        Console.WriteLine("=== SHOPPINGLISTA ===");
        Console.WriteLine("1. - Visa hela listan");
        Console.WriteLine("2. - Lägg till en artikel");
        Console.WriteLine("3. - Ta bort en artikel");
        Console.WriteLine("4. - Sök efter artikel");
        Console.WriteLine("5. - Avsluta");

        // Visar alla artiklar i shoppinglistan
        Console.WriteLine("Se hela Shoppinglistan:");
        List<string> shoppingList = new List<string>();

        shoppingList.Add("Banan");
        shoppingList.Add("Motorsåg");
        shoppingList.Add("Trollstav");

        Console.WriteLine("Visa alla artiklar");
        foreach (string articel in shoppingList)
        {
            Console.WriteLine(articel);
        }

        //Lägg till en artikel
        Console.Write("Lägg till en artikel: ");
        string newArticle = Console.ReadLine();
        shoppingList.Add(newArticle);
        foreach (string articel in shoppingList)
        {
            Console.WriteLine(articel);
        }
        Console.WriteLine($"Artikeln {newArticle} har lagts till.");

        // Ta bort en artikel
        Console.Write("Ta bort artikel: ");
        var removeArticle = Console.ReadLine();

        shoppingList.Remove(removeArticle);

        foreach (var articel in shoppingList)
        {
            Console.WriteLine(articel);
        }
        Console.WriteLine($"Artikeln {removeArticle} har tagits bort");



    }
}
