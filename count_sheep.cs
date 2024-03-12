/* 
--> Count sheep <--
Ex: n = 3 result -> 1 sheep...2 sheep...3 sheep
Ex: n = 5 result -> 1 sheep...2 sheep...3 sheep...4 sheep...5 sheep...
*/

public static string CountSheep(int n)
{
        string frase = string.Empty;

        for (int i = 1; i <= n; i++)
        {
            frase += $"{i} sheep...";
        }
        return frase;
}

//Test
static void Main(string[] args)
{
        Console.WriteLine(CountSheep(3));
        Console.WriteLine(CountSheep(0));
        Console.WriteLine(CountSheep(1));
        Console.WriteLine(CountSheep(5));
        Console.ReadKey();
}
