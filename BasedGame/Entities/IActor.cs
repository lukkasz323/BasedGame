using BasedGame.Components;

namespace BasedGame.Entities;

internal interface IActor
{
    ActorComponent ActorComponent { get; }
}