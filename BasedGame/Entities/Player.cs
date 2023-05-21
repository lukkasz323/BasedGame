using BasedGame.Components;

namespace BasedGame.Entities;

internal class Player : Entity
{
    internal CombatComponent Combat { get; } = new();
    internal int Level { get; set; }
    internal int Xp { get; set; }
    internal int MaxXp { get; set; }
}