using BasedGame.Components;

namespace BasedGame.Entities;

internal class Enemy : Entity
{
    internal int XpReward { get; set; }
    internal CombatComponent Combat { get; } = new();
}