using BasedGame.Components;

namespace BasedGame.Entities;

internal class Player : Entity, ICombatant
{
    internal int Level { get; set; }
    internal int Xp { get; set; }
    internal int MaxXp { get; set; }

    public CombatComponent Combat { get; } = new();
}