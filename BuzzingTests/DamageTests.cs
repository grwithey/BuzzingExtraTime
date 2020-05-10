using Buzzing.Bees;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BuzzingTests
{
    [TestClass]
    public class DamageTests
    {
        [TestMethod]
        public void DamageCalledOnWorker_HealthReducedBy10Percent()
        {
            // Arrange
            var workerBee = new Worker();
            workerBee.Health = 100;

            // Act
            workerBee.Damage(10);

            // Assert
            Assert.AreEqual(90, workerBee.Health);
        }

        [TestMethod]
        public void DamageCalledOnQueen_HealthReducedBy10Percent()
        {
            // Arrange
            var queenBee = new Queen();
            queenBee.Health = 100;

            // Act
            queenBee.Damage(5);

            // Assert
            Assert.AreEqual(95, queenBee.Health);
        }

        [TestMethod]
        public void DamageCalledOnDrone_HealthReducedBy10Percent()
        {
            // Arrange
            var droneBee = new Drone();
            droneBee.Health = 100;

            // Act
            droneBee.Damage(3);

            // Assert
            Assert.AreEqual(97, droneBee.Health);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DamageCalledOnWorker_ValueOver100_ArgumentExceptionIsThrown()
        {
            // Arrange
            var workerBee = new Worker();

            // Act
            workerBee.Damage(101);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DamageCalledOnQueen_ValueOver100_ArgumentExceptionIsThrown()
        {
            // Arrange
            var queenBee = new Worker();

            // Act
            queenBee.Damage(1000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DamageCalledOnDrone_ValueOver100_ArgumentExceptionIsThrown()
        {
            // Arrange
            var droneBee = new Worker();

            // Act
            droneBee.Damage(112);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DamageCalledOnWorker_ValueUnder0_ArgumentExceptionIsThrown()
        {
            // Arrange
            var workerBee = new Worker();

            // Act
            workerBee.Damage(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DamageCalledOnQueen_ValueUnder0_ArgumentExceptionIsThrown()
        {
            // Arrange
            var queenBee = new Worker();

            // Act
            queenBee.Damage(-10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DamageCalledOnDrone_ValueUnder0_ArgumentExceptionIsThrown()
        {
            // Arrange
            var droneBee = new Worker();

            // Act
            droneBee.Damage(-100);
        }

        [TestMethod]
        public void DamageCalledOnBee_KillBee_CallingDamageHasNoEffectOnHealthWhenDead()
        {
            // Arrange
            var bees = CreateAllBeeTypes();

            // Need to kill the bee with this call to test for no effect when it is dead.
            KillBees(bees);

            // Act
            foreach (var bee in bees)
            {
                bee.Damage(1);
            }

            // Assert
            foreach (var bee in bees)
            {
                Assert.AreEqual(1, bee.Health);
            }
        }

        private void KillBees(Bee[] bees)
        {
            foreach(var bee in bees)
            {
                bee.Damage(99);
            }
        }

        private Bee[] CreateAllBeeTypes()
        {
            return new Bee[3]
            {
                new Worker(),
                new Drone(),
                new Queen()
            };
        }
    }
}
