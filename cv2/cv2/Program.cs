Console.WriteLine("Vítajte v kalkulačke!");
Console.WriteLine("Zadajte prvé číslo: ");
string s = Console.ReadLine();
float a = float.Parse(s);

Console.WriteLine("Zadajte druhé číslo: ");
string d = Console.ReadLine();
float b = float.Parse(d);

float sucet, rozdiel, sucin, podiel;

sucet = a + b;
rozdiel = a - b;
sucin = a * b;
podiel = a / b;

Console.WriteLine("Súčet: " + sucet);
Console.WriteLine("Rozdiel: " + rozdiel);
Console.WriteLine("Súčin: " + sucin);
Console.WriteLine("Podiel: " + podiel);

Console.ReadKey();