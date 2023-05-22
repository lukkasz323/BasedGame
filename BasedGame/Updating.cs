using BasedGame.Components;
using BasedGame.Entities;

namespace BasedGame;

internal static class Updating
{
    internal static bool UpdateGame(GameState state)
    {
        bool shouldGameContinue;

        ConsoleKeyInfo input = Console.ReadKey(true);
        shouldGameContinue = Frame(state);

        return shouldGameContinue;
    }

    private static bool Frame(GameState state)
    {
        if (state.Battle != null)
        {
            state.Battle.NextTurn();
            if (!state.Player.Combat.IsAlive)
            {
                return false;
            }
        }

        return true;
    }
}
