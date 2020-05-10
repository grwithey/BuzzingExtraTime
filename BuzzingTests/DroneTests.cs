using Buzzing.Bees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuzzingTests
{
    [TestClass]
    public class DroneTests
    {
        [TestMethod]
        public void DamageCalled_HealthAfterDamageIsBelow50_BeeIsDead()
        {
            // Arrange
            var droneBee = new Drone();

            // Act
            droneBee.Damage(60);

            // Assert
            Assert.IsTrue(droneBee.IsDead);
        }

        [TestMethod]
        public void DamageCalled_HealthAfterDamageIsAbove50_BeeIsNotDead()
        {
            // Arrange
            var droneBee = new Drone();

            // Act
            droneBee.Damage(49);

            // Assert
            Assert.IsFalse(droneBee.IsDead);
        }
    }
}
