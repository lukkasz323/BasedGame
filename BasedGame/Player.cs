namespace BasedGame;

internal class Player : Entity
{
    private int _maxHealth = 100;
    private int _health;

    internal Player()
    {
        _health = _maxHealth;
    }

    internal int Health { get => _health; set => _health = Math.Clamp(value, 0, _maxHealth); }
    internal int Weapon { get; set; }
    internal int Armor { get; set; }
}