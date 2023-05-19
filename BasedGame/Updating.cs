namespace BasedGame;

internal static class Updating
{
    internal static bool UpdateGame(GameState state)
    {
        bool shouldGameContinue = true;

        ConsoleKeyInfo input = Console.ReadKey(true);

        shouldGameContinue = Debug(state);

        return shouldGameContinue;
    }

    private static bool Debug(GameState state)
    {
        state.Enemy.ActorComponent.Attack(state.Player.ActorComponent);
        if (state.Player.ActorComponent.Health <= 0)
        {
            return false;
        }
        return true;
    }
}
