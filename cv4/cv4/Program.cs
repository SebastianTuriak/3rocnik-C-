int nasobilka = 1;
Console.WriteLine("Maĺa násobilka pomocou cyklu");

Console.WriteLine("Zadaj číslo, od ktorého chceš začať");
int zaciatok = int.Parse(Console.ReadLine());
for (int i = zaciatok; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {

        nasobilka = zaciatok * j;
        Console.Write("{0} ", nasobilka);
    }
    Console.WriteLine();
    zaciatok++;
}
Console.ReadKey();