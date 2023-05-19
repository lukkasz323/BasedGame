namespace BasedGame;

internal class Game
{
    internal GameState State { get; } = new();

    internal void Run()
    {
        while (true)
        {
            Console.WriteLine(State.Player.Health);
        }
    }
}
