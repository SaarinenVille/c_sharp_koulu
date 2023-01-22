// See https://aka.ms/new-console-template for more information

using System.Collections.Specialized;

// Hyppykohta, johon ohjelma palaa goto alku-komennolla
alku:

// Tehdään ensiksi valikko, josta voi valita haluamansa tehtävän
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

// Syötetään käyttäjän valinta muuttujaan
string valinta;
int numero;
valinta = Console.ReadLine();

// Varmistetaan, että käyttäjä syöttää kokonaisluvun
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

// switch casella käynnistetään haluttu ohjelma
switch (numero)
{
    case 1:
        IanSyotto();
        break;
    case 2:
        LuvunToisto();
        break;
    case 3:
        VaihdaKirjaimet();
        break;
    case 4:
        ParillisetParittomat();
        break;
    case 5:
        PisinSana();
        break;
    case 0:
        Exit();
        break;
    default:
        Console.WriteLine("Syötä oikea luku.");
        goto alku;
        break;
}

// Ohjelma, joka pyytää käyttäjältä ikää, tulostaa syötetyn iän ja antaa käyttäjälle kehut
static void IanSyotto()
{
    Console.Clear();
    int ika;

    Console.Write("Ole hyvä ja syötä ikäsi: ");
    ika = int.Parse(Console.ReadLine());
    Console.WriteLine(ika + ", näytät ikäistäsi nuoremmalta =).");
}

// Ohjelma tulostaa syötetyn luvun yhtä monta kertaa kahdella eri tavalla ja yhtä monelle riville 
static void LuvunToisto()
{
    toistoAlku:
    Console.Clear();
    int luku;
    int toisto = 1;
    Console.Write("Ole hyvä ja syötä suurempi kokonaisluku kuin 10: ");
    luku = int.Parse(Console.ReadLine());

    if(luku < 10)
    {
        Console.WriteLine("Antamasi luku ei ollut suurempi kuin 10. Paina enter jatkaaksesi: ");
        Console.ReadLine();
        goto toistoAlku;
    }
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


// Ohjelma vaihtaa syötetyn sanan ensimmäisen ja viimeisen kirjaimen paikkaa keskenään
static void VaihdaKirjaimet()

{
    Console.Clear();

    string sana;
    string uusiSana;
    
    Console.Write("Syötä jokin sana. Ohjelma vaihtaa ensimmäisen ja viimeisen kirjaimen paikkaa: ");
    sana = Console.ReadLine();
    char[] sanaTaulu = new char[sana.Length];

    for (int i = 0; i < sanaTaulu.Length; i++)
    
        sanaTaulu[i] = sana[i];
        sanaTaulu[0] = sana[sana.Length - 1];
        sanaTaulu[sana.Length - 1] = sana[0];
        uusiSana = String.Join("", sanaTaulu); 

        Console.WriteLine(uusiSana);
}

static void ParillisetParittomat()

{
    Console.Clear();
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

static void PisinSana()

{
    Console.Clear();

    string lause;
    Console.WriteLine("Syötä jokin lause. Ohjelma etsii lauseen pisimmän sanan. ");
    lause = Console.ReadLine();

    string[] sanaTaulu = lause.Split(' ');
    string pisinSana = sanaTaulu[0];

    for (int i = 1; i < sanaTaulu.Length; i++)
    {
        if(sanaTaulu[i].Length > pisinSana.Length)
        {
            pisinSana = sanaTaulu[i];
        }
    }
    Console.WriteLine("Lauseen pisin sana on: " + pisinSana);
}





goto alku;

static void Exit()
{
    System.Environment.Exit(0);
}

