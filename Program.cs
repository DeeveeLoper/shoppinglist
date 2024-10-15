using System.Net;

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

        //Lägg till en artikel genom att använda Add
        Console.Write("Lägg till en artikel: ");
        string newArticle = Console.ReadLine();
        shoppingList.Add(newArticle);
        foreach (string articel in shoppingList)
        {
            Console.WriteLine(articel);
        }
        Console.WriteLine($"Artikeln {newArticle} har lagts till.");

        // Ta bort en artikel genom att använda RemoveAt
        Console.Write("Ta bort artikel: ");
        var removeArticle = Console.ReadLine();
        int removeIndex = shoppingList.IndexOf(removeArticle);
        shoppingList.RemoveAt(removeIndex);

        foreach (var articel in shoppingList)
        {
            Console.WriteLine(articel);
        }
        Console.WriteLine($"Artikeln {removeArticle} har tagits bort");

        // Sök efter en artikel genom att använda Contains
        Console.Write("Sök efter en artikel: ");
        string searcheArticle = Console.ReadLine();

        shoppingList.Contains(searcheArticle);
        foreach (var articel in shoppingList)
        {
            Console.WriteLine(articel);
        }
        Console.WriteLine($"Artikeln {searcheArticle} du söker har hittats.");

        // Avsluta prorgam
        Console.WriteLine("Vill du avsluta?");
        string quitProgram = Console.ReadLine();
        if (quitProgram == "5")
        {
            Console.WriteLine("Programmet avslutas!");
            Environment.Exit(0);
        }
    }
}
