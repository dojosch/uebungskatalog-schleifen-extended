Console.WriteLine("Wie viele Credits möchtest du kaufen?");
int credits = Convert.ToInt32(Console.ReadLine());

//  Start      1. Schritt    3. Schritt
for(int i = 1; i <= credits; i++)
{
    // Bei den ersten 25% der Fahrten => Ich bin super gehyped
    // Aktuellen Schleifendurchlauf => i
    // Erstes Viertel: credits * 0.25
    if(i < credits * 0.25) {
        Console.WriteLine("Ich bin supergehyped");
    }

    // 2. Schritt
    Console.WriteLine("Mit welchem Fahrgeschäft möchtest du fahren?");
    Console.WriteLine("1. Kettenkarussell");
    Console.WriteLine("2. Geisterbahn");
    Console.WriteLine("3. Achterbahn");
    int auswahl = Convert.ToInt32(Console.ReadLine());

    // Hälfte der Credits
    // Zeitpunkt finden
    // Aktueller Schleichendurchlauf: i
    // Zeitpunkt finden => Hälfte => credits / 2
    // Eine Zahl genau eine andere Zahl: ==
    if(i == credits / 2)
    {
        Console.WriteLine("Hälfte der Credits aufgebraucht");
    }

    // Zeitspanne finden
    // Aktuellen Schleifendurchlauf: i
    // Start / End-Zeitpunkt => credits * 0.75
    if(i > credits * 0.75)
    {
        Console.WriteLine($"Du hast nur noch {credits - i} Fahrten übrig");
    }
}