using Buzzing.Interfaces;

namespace Buzzing.Bees
{
    internal class Worker : Bee, IBee // <-- Inheritance eases testing for each bee and provides a 
    {
        public bool IsDead
        {
            get
            {
                return Health < 70;
            }
        }

        public override void Damage(int percentage)
        {
            // Is dead is placed here as the one on the base class would not be relivant to
            if (!IsDead)
            {
                base.Damage(percentage); // Damage must not be caused as Bee is dead!
            }
        }
    }
}
