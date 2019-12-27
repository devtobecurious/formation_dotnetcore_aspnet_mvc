using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestJeuDroides
{
    [TestClass]
    public class JediUnitTest
    {
        [TestMethod]
        public void TesterAttaquerToutEstOK()
        {
            ExempleJedis.Jedi jedi = new ExempleJedis.Jedi();
            ExempleJedis.Droide droide = new ExempleJedis.Droide()
            {
                PointsDeVie = 100
            };

            jedi.Attaquer(droide);

            Assert.IsTrue(droide.PointsDeVie == 50);
        }
    }
}
