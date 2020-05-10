
using Buzzing.Interfaces;

namespace Buzzing.Bees
{
    internal class Queen : Bee, IBee
    {
        public bool IsDead
        {
            get
            {
                return Health < 20;
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
