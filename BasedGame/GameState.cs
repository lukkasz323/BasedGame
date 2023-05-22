using BasedGame.Entities;

namespace BasedGame;

internal class GameState
{
    internal GameSettings Settings { get; } = new();
    internal Player Player { get; } = new();
    internal Arena Arena { get; } = new();
}