using BasedGame.Components;

namespace BasedGame.Entities;

internal class Player : Entity
{
    internal int Level { get; set; }
    internal int Xp { get; set; }
    internal int MaxXp { get; set; }
    internal CombatComponent Combat { get; } = new();

    internal Player()
    {
        Combat.Strength = 2;
    }
}