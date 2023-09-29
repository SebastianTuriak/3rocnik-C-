Console.WriteLine("Ahoj, ja som virtuálny papusek Kubo, rad opakujem!");
Console.WriteLine("Napíš niečo čo budem opakovať: ");

string vstup;
vstup = Console.ReadLine();

string vystup;
vystup = vstup + ",   " + vstup + "!";
Console.WriteLine(vystup);
Console.ReadKey();