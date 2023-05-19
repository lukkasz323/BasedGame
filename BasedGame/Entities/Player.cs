using BasedGame.Components;

namespace BasedGame.Entities;

internal class Player : Entity, IActor
{
    public ActorComponent ActorComponent { get; } = new();

    internal void Attack(IActor enemy)
    {

    }
}