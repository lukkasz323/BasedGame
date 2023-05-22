using BasedGame.Components;

namespace BasedGame.Entities;

internal class Player : Entity
{
    private int _xp = 0;

    internal int Level { get; private set; } = 1;
    internal int MaxXp { get; private set; } = 10;
    internal CombatComponent Combat { get; } = new();

    internal int Xp 
    {
        get => _xp;
        set 
        {
            _xp = value;
            if (_xp >= MaxXp)
            {
                LevelUp();
            }
        }
    }

    internal Player()
    {
        Combat.MaxHealth = 1000;
        Combat.Health = 1000;
        Combat.Strength = 2;
    }

    private void LevelUp()
    {
        _xp -= MaxXp;
        MaxXp *= 2;
    }
}