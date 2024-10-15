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

        // Se alla produkter i shoppinglistan
        Console.WriteLine("Se hela Shoppinglistan:");
        List<string> shoppingList = new List<string>();

        shoppingList.Add("Banan");
        shoppingList.Add("Motorsåg");
        shoppingList.Add("Trollstav");

        Console.WriteLine("Visa alla Produkter");
        foreach (string product in shoppingList)
        {
            Console.WriteLine(product);
        }

    }
}
