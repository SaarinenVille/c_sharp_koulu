using Pankki;
namespace Pankkitilitesti
{
    [TestClass]
    public class Pankkitilitesti
    {
        [TestMethod]
        public void OttoOikeallaSumalla()
        {
            double alkusaldo = 11.99;
            double ottoSumma = 4.55;
            double oletettu = 7.44;

            Pankki.Pankkitili pt = new Pankki.Pankkitili("Jaakko Tarvainen", alkusaldo);
            pt.Otto(ottoSumma);
            Assert.AreEqual(oletettu, pt.Saldo, 0.001, "Jokin m‰tt‰‰");
        }
    }
}