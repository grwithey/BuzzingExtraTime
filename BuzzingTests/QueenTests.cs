using Buzzing.Bees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuzzingTests
{
    [TestClass]
    public class QueenTests
    {
        [TestMethod]
        public void DamageCalled_HealthAfterDamageIsBelow20_BeeIsDead()
        {
            // Arrange
            var queenBee = new Queen();

            // Act
            queenBee.Damage(85);

            // Assert
            Assert.IsTrue(queenBee.IsDead);
        }

        [TestMethod]
        public void DamageCalled_HealthAfterDamageIsAbove20_BeeIsNotDead()
        {
            // Arrange
            var queenBee = new Drone();

            // Act
            queenBee.Damage(50);

            // Assert
            Assert.IsFalse(queenBee.IsDead);
        }
    }
}
