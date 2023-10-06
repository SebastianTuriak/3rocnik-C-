
Console.WriteLine("Vitaj v našej kalkulačke");
int pokracovanie = 0;
do
{
    Console.WriteLine("Zadaj prve číslo");
    float a = float.Parse(Console.ReadLine());
    Console.WriteLine("Zadaj druhé číslo");
    float b = float.Parse(Console.ReadLine());
    Console.WriteLine("Zvolte si operáciu");
    Console.WriteLine("1. scitanie");
    Console.WriteLine("2. odcitanie");
    Console.WriteLine("3. nasobenie");
    Console.WriteLine("4. delenie");
    int volba = int.Parse(Console.ReadLine());
    float vysledok = 0;
    switch (volba)
    {
        case 1:
            vysledok = a + b;
            break;
        case 2:
            vysledok = a - b;
            break;
        case 3:
            vysledok = a * b;
            break;
        case 4:
            vysledok = a / b;
            break;
    }
    if ((volba > 0) && (volba < 5))
        Console.WriteLine("Vysledok: {0}", vysledok);
    else
        Console.WriteLine("Neplatna volba");
    Console.WriteLine("Chceš pokračovať? 1 - Áno   2 - Nie");
    pokracovanie = int.Parse(Console.ReadLine());
}
while (pokracovanie == 1 );

    
Console.WriteLine("Dakujem za pouzitie kalkulačky, aplikaciu ukoncite stlacenim tlacitka");
Console.ReadKey();