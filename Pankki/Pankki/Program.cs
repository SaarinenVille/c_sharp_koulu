// See https://aka.ms/new-console-template for more information


namespace Pankki
{


    public class Pankkitili
    {
        private readonly string m_asiakkaanNimi;
        private double m_saldo;

        public Pankkitili() { } // Oletuskonstraktori
                                // Ylikuormitettu konstraktori

        public Pankkitili(string asNimi, double saldo)
        {
            m_asiakkaanNimi = asNimi;
            m_saldo = saldo;
        }
        // Getterit
        public string asNimi
        {
            get
            {
                return m_asiakkaanNimi;
            }
        }
        public double Saldo
        {
            get
            {
                return m_saldo;
            }
        }
        // Tehdään metodit Otolle ja Panolle
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
            Console.WriteLine("Nykyinen saldo on {0} euroa", pt.Saldo);
        }

    }
}
