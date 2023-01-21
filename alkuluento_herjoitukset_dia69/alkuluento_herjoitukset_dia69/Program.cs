// See https://aka.ms/new-console-template for more information

alku:

Console.WriteLine("");

Console.WriteLine("Valitse tehtävä 1-7: ");

Console.WriteLine("");

Console.WriteLine("1. Iän syöttö.");
Console.WriteLine("2. Luvun toisto.");
Console.WriteLine("3. Kirjainten vaihto.");
Console.WriteLine("4. Positiivinen / negatiivinen luku.");
Console.WriteLine("5. Lauseen pisin sana.");
Console.WriteLine("6. Parittomat luvut.");
Console.WriteLine("7. 3:lla jaolliset luvut.");
Console.WriteLine("");
Console.WriteLine("Paina 0 lopettaaksesi.");
Console.WriteLine("");

string valinta;
int numero;
valinta = Console.ReadLine();

try
{
    numero = Int32.Parse(valinta);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Syötä numero 1-7, tai 0 lopettaaksesi.");
    goto alku;
}

switch (numero)
{
    case 1:
        IanSyotto();
        break;
    case 2:
        LuvunToisto();
        break;
    case 4:
        ParillisetParittomat();
        break;
    case 0:
        Exit();
        break;
    default:
        Console.WriteLine("Syötä oikea luku.");
        goto alku;
        break;
}

static void IanSyotto()
{
    int ika;

    Console.WriteLine("Ole hyvä ja syötä ikäsi.");
    ika = int.Parse(Console.ReadLine());
    Console.WriteLine(ika + ", näytät ikäistäsi nuoremmalta =).");
}

static void LuvunToisto()
{
    int luku;
    int toisto = 1;
    Console.WriteLine("Ole hyvä ja syötä suurempi kokonaisluku kuin 10: ");
    luku = int.Parse(Console.ReadLine());

    for (int i = 0; i < luku; i++)
    {
        for (int j = 0; j < luku; j++)
        {
            Console.Write(luku + " ");
        }
        Console.WriteLine();
        for (int k = 0; k < luku; k++)
        {
            Console.Write(luku);
        }        
            Console.WriteLine();
    }
}

static void ParillisetParittomat()

{
    int ensimmainen;
    int toinen;

    Console.WriteLine("Ole hyvä ja syötä ensimmäinen luku: ");
    ensimmainen = int.Parse(Console.ReadLine());
    Console.WriteLine("Ole hyvä ja syötä toinen luku: ");
    toinen = int.Parse(Console.ReadLine());

    if (ensimmainen > 0  && toinen > 0)
    {
        Console.WriteLine("Molemmat luvut ovat positiivisia.");
    }
    else if (ensimmainen < 0 && toinen < 0)
    {
        Console.WriteLine("Molemmat luvut ovat negatiivisia.");
    }
    else
    {
        Console.WriteLine("Toinen luku on positiivinen ja toinen on negatiivinen.");
    }
        
}





goto alku;

static void Exit()
{
    System.Environment.Exit(0);
}

