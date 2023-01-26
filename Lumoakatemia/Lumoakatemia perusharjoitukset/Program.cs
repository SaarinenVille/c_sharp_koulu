using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
    alku:
        Console.Clear();
        // Tehdään valikko tehtävien valintaa varten
        Console.WriteLine("");
        Console.WriteLine("Ole hyvä ja valitse ohjelma 1-16: ");
        Console.WriteLine("");

        Console.WriteLine("1. Hei maailma!");
        Console.WriteLine("2. Ohjelma laskee luvut 10 ja 20 yhteen.");
        Console.WriteLine("3. Ohjelma laskee lukujen 20 ja 10 erotuksen");
        Console.WriteLine("4. Ohjelma laskee lukujen 20 ja 10 tulot");
        Console.WriteLine("5. Ohjelma laskee lukujen 5.50 ja 2.50 osamäärän: ");
        Console.WriteLine("6. Ohjelma muuntaa celsiusasteet fahrenheitasteiksi: ");
        Console.WriteLine("7. Ohjelma muuntaa fahrenheitasteet celsiusasteiksi:");
        Console.WriteLine("8. Ohjelma muuntaa mailit kilometreiksi: ");
        Console.WriteLine("9. Ohjelma muuntaa kilometrit maileiksi:  ");
        Console.WriteLine("10. Hei maailma!");
        Console.WriteLine("11. Hei maailma!");
        Console.WriteLine("12. Hei maailma!");
        Console.WriteLine("13. Hei maailma!");
        Console.WriteLine("14. Hei maailma!");
        Console.WriteLine("15. Hei maailma!");
        Console.WriteLine("16. Hei maailma!");
        Console.WriteLine("");
        Console.WriteLine("Paina 0 lopettaaksesi.");
        Console.WriteLine("");

        // Tehdään valinta muuttuja ja numero muuttuja metodin käynnistämistä varten
        string valinta;
        int numero;
        valinta = Console.ReadLine();
        numero = int.Parse(valinta);


        switch (numero)
        {
            case 0:
                Exit();
                break;
            case 1:
                HeiMaailma();
                break;
            case 2:
                Summa();
                break;
            case 3:
                Erotus();
                break;
            case 4:
                Tulo();
                break;
            case 5:
                Osamaara();
                break;
            case 6:
                CelsiusFahrenheit();
                break;
            case 7:
                FahrenheitCelsius();
                break;
            case 8:
                MailitKm();
                break;
            case 9:
                 KmMailit();
                break;


        }


        static void HeiMaailma()
        {
            Console.Clear();
            Console.WriteLine("Hei maailma!");
            Console.Write("Paina enter palataksesi valikkoon: ");
            Console.ReadLine();
        }

        static void Summa()
        {
            Console.Clear();

            int nro1 = 10;
            int nro2 = 20;
            int summa = nro1 + nro2;

            Console.WriteLine("Lukujen 10 ja 20 summa on: " + summa);
            Console.Write("Paina enter palataksesi valikkoon: ");
            Console.ReadLine();
        }

        static void Erotus()
        {
            Console.Clear();

            int nro1 = 20;
            int nro2 = 10;
            int erotus = nro2 - nro1;

            Console.WriteLine("Lukujen 20 ja 10 erotus on: " + erotus);
            Console.Write("Paina enter palataksesi valikkoon: ");
            Console.ReadLine();
        }

        static void Tulo()
        {
            Console.Clear();

            int nro1 = 20;
            int nro2 = 10;
            int tulo = nro2 * nro1;

            Console.WriteLine("Lukujen 20 ja 10 tulo on: " + tulo);
            Console.Write("Paina enter palataksesi valikkoon: ");
            Console.ReadLine();
        }

        static void Osamaara()
        {
            Console.Clear();

            double nro1 = 5.50;
            double nro2 = 2.50;
            double osamaara = nro1 / nro2;

            Console.WriteLine("Lukujen 5.50 ja 2.50 osamäärä on: " + osamaara);
            Console.Write("Paina enter palataksesi valikkoon: ");
            Console.ReadLine();
        }
        
        static void CelsiusFahrenheit()
        {
            Console.Clear();

            Console.Write("Ole hyvä ja syötä lämpötila Celsiusasteena: ");
            int celsius = Int32.Parse(Console.ReadLine());
            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine(celsius + " celsiusastetta on " + fahrenheit + " fahrenheitia.");
            Console.Write("Paina enter palataksesi valikkoon: ");
            Console.ReadLine();
        }

        static void FahrenheitCelsius()
        {
            Console.Clear();

            Console.Write("Ole hyvä ja syötä lämpötila fahrenheitasteena: ");
            int fahrenheit = Int32.Parse(Console.ReadLine());
            double celsius = (fahrenheit - 32) / 1.8;

            Console.WriteLine(fahrenheit + " fahrenheitastetta on " + celsius + " celsiusta.");
            Console.Write("Paina enter palataksesi valikkoon: ");
            Console.ReadLine();
        }
        
        static void MailitKm()
        {
            Console.Clear();

            Console.Write("Ole hyvä ja syötä muunnettava mailimäärä: ");
            double mailit = Double.Parse(Console.ReadLine());
            double kilometrit = mailit * 1.609344;

            Console.WriteLine("");
            Console.WriteLine(mailit + " mailia on " + kilometrit + " kilometriä.");

            Console.Write("Paina enter palataksesi valikkoon: ");
            Console.ReadLine();
        }

        static void KmMailit()
        {
            Console.Clear();

            Console.Write("Ole hyvä ja syötä muunnettava kilometrimäärä: ");
            double kilometrit = Double.Parse(Console.ReadLine());
            double mailit = kilometrit / 1.609344;

            Console.WriteLine("");
            Console.WriteLine(kilometrit + " kilometriä on " + mailit + " mailia.");

            Console.Write("Paina enter palataksesi valikkoon: ");
            Console.ReadLine();
        }

        goto alku;








        static void Exit()
        {
            Environment.Exit(0);
        }
    }
}