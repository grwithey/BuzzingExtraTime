namespace Buzzing.Interfaces
{
    // This enables testing for each bee to be performed generically as well as determine
    // any important properties that all bees share
    public interface IBee
    {
        bool IsDead { get; }
        int Health { get; }

        void Damage(int percentage);
    }
}
