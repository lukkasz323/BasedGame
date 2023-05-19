using BasedGame.Components;

namespace BasedGame.Entities;

internal class Player : Entity
{
    public ActorComponent ActorComponent { get; } = new();
}