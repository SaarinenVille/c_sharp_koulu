internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ole hyvä ja anna etunimesi: ");
        string enimi = Console.ReadLine();
        Console.Write("Ole hyvä ja anna sukunimesi: ");
        string snimi = Console.ReadLine();
        Console.WriteLine("Hei, " + enimi + " " + snimi);
        Console.WriteLine("Hei, {0} {1}", enimi, snimi);
    }
}