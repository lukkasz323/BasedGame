using BasedGame.Components;

namespace BasedGame.Entities;

internal class Enemy : Entity
{
    internal CombatComponent Combat { get; } = new();
    internal int XpReward { get; set; }
}