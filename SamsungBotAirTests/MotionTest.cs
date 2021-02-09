using Microsoft.VisualStudio.TestTools.UnitTesting;
using SamsungBotAir;

namespace SamsungBotAirTests
{
    [TestClass]
    public class MotionTest
    {
        private Motion motion;

        [TestInitialize]
        public void Initialise()
        {
            motion = new Motion();
        }

        [TestMethod]
        public void CreationDeLaGrille()
        { 
            int[,] expected = new int[66, 66];
            Assert.AreEqual(expected.ToString(), motion.grille.ToString());
        }
        [TestMethod]
        public void AvancerDe40CMetres()
        {
            motion.Move(40);
            //Assert.AreEqual(, );
        }
        [TestMethod]
        public void AvancerJusquAObstacle()
        {

        }
        [TestMethod]
        public void TournerADroite()
        {

        }
        [TestMethod]
        public void TournerAGauche()
        {

        }
        [TestMethod]
        public void ChangerPosition()
        {

        }
    }
}
