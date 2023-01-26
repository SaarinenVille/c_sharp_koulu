using Pankki;

namespace Pankkitesti
{ 
    [TestClass]
    public class PankkitiliTesti
    {
     [TestMethod]
       public void Otto_OikeallaSummalla_PaivitaSaldo()
      {
        // Alkuvalmistelut
        double alkusaldo = 11.99;
        double ottoSumma = 4.55;
        double oletettu = 7.44;
        Pankkitili tili = new Pankkitili("Jaakko Tarvainen", alkusaldo);

        // Toiminta
        tili.Otto(ottoSumma);

        // Oletettu lopputulos
        double todellinen = tili.Saldo;
        Assert.AreEqual(oletettu, todellinen, 0.001, "Tililtä otto ei onnistunut!");
     }
    }
}