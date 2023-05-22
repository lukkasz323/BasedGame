namespace BasedGame.Components;

internal class CombatComponent
{
    private int _health;

    internal CombatComponent()
    {
        _health = MaxHealth;
    }

    internal int Health { get => _health; set => _health = Math.Clamp(value, 0, MaxHealth); }
    internal int MaxHealth { get; set; } = 10;
    internal int Strength { get; set; } = 1;
    internal bool IsAlive => Health > 0;

    internal void Attack(CombatComponent enemyCombat)
    {
        enemyCombat.Health -= Strength;
    }
}