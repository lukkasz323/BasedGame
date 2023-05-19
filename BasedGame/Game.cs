using BasedGame.Entities;
using BasedGame.Components;

namespace BasedGame;

internal class Game
{
    internal bool ShouldContinue { get; set; } = true;
    internal GameState State { get; } = new();

    internal void Run()
    {
        while (ShouldContinue)
        {
            Drawing.DrawGame(State);
            ShouldContinue = Updating.UpdateGame(State);
        }
    }
}
