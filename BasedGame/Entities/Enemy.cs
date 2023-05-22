using BasedGame.Components;

namespace BasedGame.Entities;

internal class Enemy : Entity
{
    internal int XpReward { get; set; } = 5;
    internal CombatComponent Combat { get; } = new();
}