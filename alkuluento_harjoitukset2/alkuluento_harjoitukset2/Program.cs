// See https://aka.ms/new-console-template for more information

// Harjoitus 1 - Ohjelma kysyy käyttäjältä kahta kokonaislukua, ja tulostaa pienemmän luvun ensin.
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

// Harjoitus 2 - Ohjelma etsii suurimman kolmesta kokonaisluvusta.
Console.WriteLine("");
Console.WriteLine("Harjoitus 2");
Console.WriteLine("");

Console.WriteLine("Ole hyvä ja syötä ensimmäinen kokonaisluku: ");
int lu1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ole hyvä ja syötä toinen kokonaisluku: ");
int lu2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ole hyvä ja syötä kolmas kokonaisluku: ");
int lu3 = int.Parse(Console.ReadLine());

if(lu1 > lu2 && lu1 > lu3)
{
    Console.WriteLine("Luku " + lu1 + " on suurin.");
}
else if(lu2 > lu1 && lu2 > lu3)
{
    Console.WriteLine("Luku " + lu2 + " on suurin.");
}
else
{
    Console.WriteLine("Luku " + lu3 + " on suurin.");
}

// Harjoitus 3 - Ohjelma tulostaa syötetyn numeron sanana.
Console.WriteLine("");
Console.WriteLine("Harjoitus 3");
Console.WriteLine("");

Console.WriteLine("Ole hyvä ja syötä numero väliltä 0-9: ");
int luku = int.Parse(Console.ReadLine());

switch(luku)
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

// Harjoitus 4 - Ohjelma etsii suurimman annetuista 5:stä kokonaisluvusta.
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

if (luku1 > luku2 && luku1 > luku3 && luku1 > luku4 && luku1 > luku5);
{
    Console.WriteLine("Luku " + luku1 + " on suurin.");
}



