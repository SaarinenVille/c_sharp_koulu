// See https://aka.ms/new-console-template for more information

using Pankki;
namespace Pankki;

public class Pankkitili
{
    private readonly string m_asiakkaanNimi;
    private double m_saldo;

    private Pankkitili() { }

    public Pankkitili(string asiakkaanNimi, double saldo)
    {
        m_asiakkaanNimi = asiakkaanNimi;
        m_saldo = saldo;
    }

    public string AsiakkaanNimi
    {
       get { return m_asiakkaanNimi; }
    }
    public double Saldo
    {
        get { return m_saldo; }
    }

    public void Otto(double summa)
    {
        if (summa > m_saldo)
        {
            throw new ArgumentOutOfRangeException("summa");
        }
        if (summa < 0)
        {
            throw new ArgumentOutOfRangeException("summa");
        }
        m_saldo += summa; // Tässä virhe
    }

    public void Pano(double summa)
    {
        if (summa < 0)
        {
            throw new ArgumentOutOfRangeException("summa");
        }
        m_saldo += summa;
    }

    public static void Main()
    {
        Pankkitili pt = new Pankkitili("Ville Saarinen", 860.25);
        pt.Pano(140);
        pt.Otto(25.50);
        Console.WriteLine("Nykyinen salkdo on {0} euroa", pt.Saldo);
    }

}
