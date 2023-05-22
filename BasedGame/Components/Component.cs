using BasedGame.Entities;

namespace BasedGame.Components;

internal class Component
{
    internal Entity Parent { get; }

    internal Component(Entity parent)
    {
        Parent = parent;
    }
}