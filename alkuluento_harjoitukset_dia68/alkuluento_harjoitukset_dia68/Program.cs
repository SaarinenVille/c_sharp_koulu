// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Runtime.Intrinsics.X86;

alku:

Console.WriteLine("");

Console.WriteLine("Valitse tehtävä (1-10): ");

Console.WriteLine("");

Console.WriteLine("1. Laskee yhteen 10 + 5.");
Console.WriteLine("2. Celsius --> Fahrenheit.");
Console.WriteLine("3. Lukujen 10 ja 3 peruslaskutoimitukset.");
Console.WriteLine("4. Jakojäännös kahdesta luvusta.");
Console.WriteLine("5. Syötä nimesi.");
Console.WriteLine("6. Kahden syötetyn luvun summa.");
Console.WriteLine("7. Syötetty celsius-arvo fahrenheitiksi.");
Console.WriteLine("8. Kahden syötetyn luvun peruslaskutoimitukset.");
Console.WriteLine("9. Kahden syötetyn luvun jakojäännös.");
Console.WriteLine("10. Kertotaulu. Syötä luku väliltä 1-10");
Console.WriteLine("");

Console.WriteLine("Paina 0 lopettaaksesi.");

Console.WriteLine("");

string kluku;
int numero;
kluku = Console.ReadLine();
try
{
    numero = Int32.Parse(kluku);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Syötä numero 1-10, tai 0 lopettaaksesi.");
    goto alku;
}

switch (numero)
{
    case 1:
        LaskeYhteen();
        break;
    case 2:
        CelsiusFahrenheit();
        break;
    case 3:
        PerusLaskut();
        break;
    case 4:
        JakoJaannos();
        break;
    case 5:
        Nimi();
        break;
    case 6:
        LaskeYhteenSyotto();
        break;
    case 7:
        FahrenheitCelsiusSyotto();
        break;
    case 8:
        PerusLaskutSyotto();
        break;
    case 9:
        JakoJaannosSyotto();
        break;
    case 10:
        KertoTaulu();
        break;
    case 0:
        Exit();
        break;
    default:
        Console.WriteLine("Syötä numero 1-10");
        goto alku;
        break;
}

// Ohjelma laskee kaksi lukua yhteen

static void LaskeYhteen()
{
    Console.WriteLine("10 + 5 = " + (10 + 5));
}

// Ohjelma muuntaa celsiuksen fahrenheitiksi

static void CelsiusFahrenheit()
{
    int celsius = 20;
    double fahrenheit = celsius * 1.8 + 32;
    Console.WriteLine(celsius + " celsiusta on " + fahrenheit + " fahrenheitia");
}



static void PerusLaskut()
{
    int a = 10;
    int b = 3;
    int summa, vahennys, tulo;
    double jako;

    summa = a + b;
    vahennys = a - b;
    tulo = a * b;
    jako = (double)a / b;

    Console.WriteLine("Lukujen " + a + " ja " + b + " summa = " + summa + ", erotus = " + vahennys + ", tulo = " + tulo + ", jakolasku = " + jako);
}

static void JakoJaannos()
{
    int a = 5;
    int b = 2;
    int jakoj = a % b;

    Console.Write("Lukujen " + a + " ja " + b + " jakojäännös on " + jakoj);
}

static void Nimi()
{
    string nimi;
    Console.WriteLine("Ole hyvä ja kirjoita nimesi: ");
    nimi = Console.ReadLine();
    Console.WriteLine("Hei " + nimi + "!");
}

static void LaskeYhteenSyotto()
{
    int nro1;
    int nro2;

    Console.WriteLine("Syötä ensimmäinen kokonaisluku: ");
    nro1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Syötä toinen kokonaisluku: ");
    nro2 = int.Parse(Console.ReadLine());

    int summa = nro1 + nro2;

    Console.WriteLine("Lukujen " + nro1 + " ja " + nro2 + " summa on " + summa);
}

static void FahrenheitCelsiusSyotto()
{
    double celsius;
    double fahrenheit;

    Console.WriteLine("Ole hyvä ja syötä celsiusaste, jonka haluat muuttaa fahrenheitiksi: ");
    celsius = double.Parse(Console.ReadLine());
    fahrenheit = celsius * 1.8 + 32;

    Console.WriteLine(celsius + " celsiusastetta" + " on " + fahrenheit + " fahrenheitastetta.");
}

static void PerusLaskutSyotto()
{
    int luku1;
    int luku2;

    int summa;
    int erotus;
    int kerto;
    double jako;

    Console.WriteLine("Ole hyvä ja syötä ensimmäinen luku: ");
    luku1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ole hyvä ja syötä toinen luku: ");
    luku2 = int.Parse(Console.ReadLine());

    summa = luku1 + luku2;
    erotus = luku1 - luku2;
    kerto = luku1 * luku2;
    jako = (double)luku1 / luku2;

    Console.WriteLine("lukujen " + luku1 + " ja " + luku2 + " summa = " + summa + ", erotus = " + erotus + ", tulo = " + kerto + " ja jakolasku = " + jako + ".");
}

static void JakoJaannosSyotto()
{
    int lu1;
    int lu2;

    Console.WriteLine("Ole hyvä ja syötä ensimmäinen kokonaisluku: ");
    lu1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ole hyvä ja syötä toinen kokonaisluku: ");
    lu2 = int.Parse(Console.ReadLine());

    int jakojaannos = lu1 % lu2;

    Console.WriteLine("Lukujen " + lu1 + " ja " + lu2 + " jakojäännös = " + jakojaannos + ".");
}

static void KertoTaulu()
{
    int luku;
    int kerto = 1;

    Console.WriteLine("Ole hyvä ja syötä kokonaisluku, jonka kertotaulun haluat: ");
    luku = Int32.Parse(Console.ReadLine());

    
        for (int i = 1; i < 11; i++)
        {
            
            Console.Write ("\n" + luku + " x " + kerto++  + " = " + luku * i);
        }
}

goto alku;

static void Exit()
{
    System.Environment.Exit(0);
}