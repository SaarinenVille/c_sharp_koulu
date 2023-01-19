// See https://aka.ms/new-console-template for more information

// Kysytään käyttäjältä, minkä ohjelman tämä haluaa suorittaa

aloitus:
string kluku;
int numero;
Console.WriteLine("Minkä ohjelman haluat suorittaa: ");
Console.WriteLine("1. Kahden luvun järjestäminen");
Console.WriteLine("2. Suurin kolmesta");
Console.WriteLine("3. Luku sanaksi");
Console.WriteLine("4. Suurin viidestä");
Console.WriteLine("5. Käyttäjän syöttövalinta");
Console.WriteLine("6. Bonuspisteet");
Console.WriteLine("7. Luku 0-999 sanaksi");
kluku = Console.ReadLine();
try
{
    numero = Int32.Parse(kluku);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Syötä numero.");
        goto aloitus;
}

switch(numero)
{
    case 1:
        KaksiLukua();
        break;
    case 2:
        SuurinKolmesta();
        break;
    case 3:
        LukuSanaksi();
        break;
    case 4:
        SuurinViidesta();
        break;
    case 5:
        ValitseSyotto(); 
        break;
    case 6:
        BonusPisteet();
        break;
    default:
        Console.WriteLine("Syötä numero 1-7");
        goto aloitus;
}





// Harjoitus 1 - Ohjelma kysyy käyttäjältä kahta kokonaislukua, ja tulostaa pienemmän luvun ensin.

static void KaksiLukua()
{
    Console.WriteLine("Harjoitus 1");
    Console.WriteLine("");

    Console.Write("Ole hyvä ja syötä ensimmäinen kokonaisluku: ");
    int l1 = int.Parse(Console.ReadLine());
    Console.Write("Ole hyvä ja anna toinen kokonaisluku: ");
    int l2 = int.Parse(Console.ReadLine());

    if (l1 > l2)
    {
        Console.WriteLine(l2 + " " + l1);
    }
    else
    {
        Console.WriteLine(l1 + " " + l2);
    }
}

// Harjoitus 2 - Ohjelma etsii suurimman kolmesta kokonaisluvusta.

static void SuurinKolmesta()
{

    Console.WriteLine("");
    Console.WriteLine("Harjoitus 2");
    Console.WriteLine("");

    Console.WriteLine("Ole hyvä ja syötä ensimmäinen kokonaisluku: ");
    int lu1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ole hyvä ja syötä toinen kokonaisluku: ");
    int lu2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ole hyvä ja syötä kolmas kokonaisluku: ");
    int lu3 = int.Parse(Console.ReadLine());

    if (lu1 > lu2 && lu1 > lu3)
    {
        Console.WriteLine("Luku " + lu1 + " on suurin.");
    }
    else if (lu2 > lu1 && lu2 > lu3)
    {
        Console.WriteLine("Luku " + lu2 + " on suurin.");
    }
    else
    {
        Console.WriteLine("Luku " + lu3 + " on suurin.");
    }
}

// Harjoitus 3 - Ohjelma tulostaa syötetyn numeron sanana.

static void LukuSanaksi()
{

    Console.WriteLine("");
    Console.WriteLine("Harjoitus 3");
    Console.WriteLine("");

    Console.WriteLine("Ole hyvä ja syötä numero väliltä 0-9: ");
    int luku = int.Parse(Console.ReadLine());

    switch (luku)
    {
        case 0:
            Console.WriteLine("nolla");
            break;
        case 1:
            Console.WriteLine("yksi");
            break;
        case 2:
            Console.WriteLine("kaksi");
            break;
        case 3:
            Console.WriteLine("kolme");
            break;
        case 4:
            Console.WriteLine("neljä");
            break;
        case 5:
            Console.WriteLine("viisi");
            break;
        case 6:
            Console.WriteLine("kuusi");
            break;
        case 7:
            Console.WriteLine("seitsemän");
            break;
        case 8:
            Console.WriteLine("kahdeksan");
            break;
        case 9:
            Console.WriteLine("yhdeksän");
            break;

        default:
            Console.WriteLine("Syöte virheelllinen.");
            break;
    }
}

// Harjoitus 4 - Ohjelma etsii suurimman annetuista 5:stä kokonaisluvusta.

static void SuurinViidesta()
{

    Console.WriteLine("");
    Console.WriteLine("Harjoitus 4");
    Console.WriteLine("");

    Console.WriteLine("Ole hyvä ja syötä ensimmäinen kokonaisluku: ");
    int luku1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ole hyvä ja syötä toinen kokonaisluku: ");
    int luku2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ole hyvä ja syötä kolmas kokonaisluku: ");
    int luku3 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ole hyvä ja syötä neljäs kokonaisluku: ");
    int luku4 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ole hyvä ja syötä viides kokonaisluku: ");
    int luku5 = int.Parse(Console.ReadLine());

    if (luku1 > luku2 && luku1 > luku3 && luku1 > luku4 && luku1 > luku5)
    {
        Console.WriteLine("Luku " + luku1 + " on suurin.");
    }
    else if (luku2 > luku1 && luku2 > luku3 && luku2 > luku4 && luku2 > luku5)
    {
        Console.WriteLine("Luku " + luku2 + " on suurin.");
    }
    else if (luku3 > luku1 && luku3 > luku2 && luku3 > luku4 && luku3 > luku5)
    {
        Console.WriteLine("Luku " + luku3 + " on suurin.");
    }
    else if (luku4 > luku1 && luku4 > luku2 && luku4 > luku3 && luku4 > luku5)
    {
        Console.WriteLine("Luku " + luku4 + " on suurin.");
    }
    else
    {
        Console.WriteLine("Luku " + luku5 + " on suurin.");
    }
}
// Harjoitus 5 - Ohjelma kysyy käyttäjältä, haluaako tämä syöttää kokonaisluvun, double-luvun vai merkkijonon

static void ValitseSyotto()
{

    int kokonaisluku;
    double doubleluku;
    string merkkijono;
    string syote;

syotonaloitus:

    Console.WriteLine("Haluatko syöttää kokonaisluvun (i), doubleluvun (d) vai merkkijonon (s)? ");
    syote = Console.ReadLine();

    if (syote == "i" || syote == "d" || syote == "s")
    {
        switch(syote)
        {
            case "i":
                Console.Write("Syötä kokonaisluku: ");
                kokonaisluku = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Syötit luvun " + kokonaisluku + ", lopullinen tulos on " + (kokonaisluku + 1));
                break;
            case "d":
                Console.Write("Syötä doubleluku: ");
                doubleluku = Double.Parse(Console.ReadLine());
                Console.WriteLine("Syötit luvun " + doubleluku + ", lopullinen tulos on" + (doubleluku + 1));
                break;
            case "s":
                Console.Write("Syötä merkkijono: ");
                merkkijono = Console.ReadLine();
                merkkijono += "*";
                Console.WriteLine("Syötit " + merkkijono);
                break;
            default:
                Console.WriteLine("Syötit jotakin muuta");
                break;
        }
    }
}

static void BonusPisteet()
{
    int pisteet;

    Console.WriteLine("Ole hyvä ja syötä bonuspisteesi (1-9): ");
    pisteet = Console.ReadLine();
    
}


