using Buzzing.Bees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuzzingTests
{
    [TestClass]
    public class WorkerTests
    {  
        [TestMethod]
        public void DamageCalled_HealthAfterDamageIsBelow70_BeeIsDead()
        {
            // Arrange
            var workerBee = new Worker();

            // Act
            workerBee.Damage(40);

            // Assert
            Assert.IsTrue(workerBee.IsDead);
        }       
        
        [TestMethod]
        public void DamageCalled_HealthAfterDamageIsAbove70_BeeIsNotDead()
        {
            // Arrange
            var workerBee = new Worker();

            // Act
            workerBee.Damage(10);

            // Assert
            Assert.IsFalse(workerBee.IsDead);
        }
    }
}
