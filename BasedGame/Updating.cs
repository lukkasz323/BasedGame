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
        state.Player.Combat.Attack(state.Enemy.Combat);
        state.Enemy.Combat.Attack(state.Player.Combat);

        if (state.Player.Combat.Health <= 0)
        {
            return false;
        }
        return true;
    }
}
