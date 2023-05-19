namespace BasedGame;

internal class Game
{
    internal bool ShouldContinue { get; set; } = true;
    internal GameState State { get; } = new();

    internal void Run()
    {
        Draw();
        while (ShouldContinue)
        {
            ShouldContinue = Update();
            Draw();
        }
    }

    private bool Update()
    {
        bool shouldGameContinue = true;

        ConsoleKeyInfo input = Console.ReadKey(true);

        State.Player.Health -= 1;
        if (State.Player.Health <= 0)
        {
            shouldGameContinue = false;
        }

        return shouldGameContinue;
    }

    private void Draw()
    {
        Console.WriteLine(State.Player.Health);
    }
}
