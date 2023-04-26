Console.WriteLine("Wie viele Münzen möchtest du kaufen?");
int coins = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < coins; i++)
{
    Console.WriteLine("Welchen Gegenstand möchtest du kaufen?");
    Console.WriteLine("1: Schwert");
    Console.WriteLine("2: Rüstung");
    Console.WriteLine("3: Heiltrank");

    Console.Write("Deine Wahl: ");
    int selection = Convert.ToInt32(Console.ReadLine());

    // ==, weil es nur einmal ausgegeben werden soll
    // -1, weil man bei 0 zu zählen beginnt
    if(i == coins / 2 - 1)
    {
        Console.WriteLine("Du hast jetzt die Hälfte deiner Münzen ausgegeben");
    }

    // >, weil es über eine Spanne an Daten läuft
    // -1, weil man bei 0 zu zählen beginnt
    if(i > coins * 0.75 - 1)
    {
        Console.WriteLine($"Du hast nur noch {coins - i - 1} Münzen");
    }
}