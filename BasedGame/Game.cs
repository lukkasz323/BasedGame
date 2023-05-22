using BasedGame.Components;

namespace BasedGame;

internal class Game
{
    internal bool ShouldContinue { get; set; } = true;
    internal GameState State { get; } = new();

    internal Game()
    {
        State.Battle = new(State.Player.Combat);
    }

    internal void Run()
    {
        Drawing.DrawGame(State);
        while (ShouldContinue)
        {
            ShouldContinue = Updating.UpdateGame(State);
            Drawing.DrawGame(State);
        }
    }
}
