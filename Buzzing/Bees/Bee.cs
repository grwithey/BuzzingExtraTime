using System;

namespace Buzzing.Bees
{
    internal class Bee
    {
        // Required at this level to be used when calculating damage.
        public int Health { get; internal set; }

        internal Bee()
        {
            // Health for all Bee's is initially 100 so this is given to all bee's inheriting
            // from this class when initialised.
            Health = 100;
        }

        /// <summary>
        /// Reduces health by a specified percentage.
        /// </summary>
        /// <param name="percentage">A whole number between 0 and 100 repersenting a %.</param>
        public virtual void Damage(int percentage)
        {
            if (percentage > 100)
                throw new ArgumentException("Percentage reduction cannot be greater than 100");

            if (percentage < 0)
                throw new ArgumentException("Percentage reduction cannot be less than 0");

            Health = RemovePercentageOfHealth(percentage, Health);
        }

        // Logic sits here so it can be re used across all bee classes to reduce repatition of 
        // an identical calculation.
        private static int RemovePercentageOfHealth(int percentage, int health)
        {
            // Reduces health by turning the percentage reduction given into a multiplier
            // so we can work out the number post reduction. Need to round to the nearest 2 decimal
            // places as float does not have great precision.
            double percentageMultiplier = Math.Round(1.0f - (float)percentage / 100.0f, 2);

            // Remaining health ,must be returned as a whole number
            return (int)((float)health * percentageMultiplier);
        }
    }
}
