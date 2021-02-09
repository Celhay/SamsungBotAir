using Microsoft.VisualStudio.TestTools.UnitTesting;
using SamsungBotAir;

namespace SamsungBotAirTests
{
    [TestClass]
    public class MotionTest
    {
        private Motion motion;
        private Processing processing;

        [TestInitialize]
        public void Initialise()
        {
            processing = new Processing();
            motion = new Motion(processing.getGrille());
            
        }

        [TestMethod]
        public void CreationDeLaGrille()
        { 
            int[,] expected = new int[66, 66];
            Assert.AreEqual(expected.ToString(), processing.getGrille().ToString());
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

        [TestMethod]
        public void CheckObstacle_returnTrue()
        {
            var actual = processing.CheckObstacle(5, 5);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckObstacle_returnFalse()
        {
            var actual = processing.CheckObstacle(5, 5);
            Assert.IsFalse(actual);
        }
    }
}
