namespace BasedGame.Components;

internal class ActorComponent
{
    private readonly int _maxHealth = 100;
    private int _health;

    internal ActorComponent()
    {
        _health = _maxHealth;
    }

    internal int Health { get => _health; set => _health = Math.Clamp(value, 0, _maxHealth); }
}