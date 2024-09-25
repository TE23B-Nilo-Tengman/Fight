
int hpe = Random.Shared.Next(40, 50);
int hp = Random.Shared.Next(40, 50);
int dmg = Random.Shared.Next(2, 5);
int healing = Random.Shared.Next(0, 7);





Console.WriteLine("skriv ditt namn");
string name = Console.ReadLine();

while (name == "")
{
    Console.WriteLine("Skriv ditt namn.");
    name = Console.ReadLine();
}





while (hp > 0 && hpe > 0)
{

    Console.WriteLine($"{name} hp{hp}");
    Console.WriteLine($"{name} killer hp{hpe}");
    Console.WriteLine($"----------------------------");
    Console.WriteLine($" ");
    Console.WriteLine($"skriv (a) för att slå (2-5 dmg)");
    Console.WriteLine($"skriv (b) för healing (0-7 hp)");

    string action = Console.ReadLine();
    if (action.ToLower() == "a")
    {
        dmg = Random.Shared.Next(2, 5);
        Console.WriteLine($"{name} slog för {dmg} dmg");
        hpe -= dmg;
    }
    else if (action.ToLower() == "b")
    {
        healing = Random.Shared.Next(0, 7);
        Console.WriteLine($"{name} healed för {healing} hp");
        hp += healing;
    }



    dmg = Random.Shared.Next(2, 5);
    Console.WriteLine($"{name} killer slog för {dmg} dmg");
    hp -= dmg;
    Console.WriteLine("");
}

if (hp > 0)
{
    Console.WriteLine("!!!YOU WIN!!!");
}
else if (hpe > 0)
{
    Console.WriteLine(":( YOU LOSE :(");
}


























Console.ReadLine();