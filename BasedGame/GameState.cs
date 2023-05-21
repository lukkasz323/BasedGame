using BasedGame.Entities;

namespace BasedGame;

internal class GameState
{
    internal GameSettings Settings { get; } = new();
    internal Player Player { get; set; } = new();
    internal Enemy Enemy { get; set; } = new();
}