using BasedGame.Components;
using BasedGame.Entities;

namespace BasedGame;

internal static class Updating
{
    internal static bool UpdateGame(GameState state)
    {
        bool shouldGameContinue;

        shouldGameContinue = Frame(state, Console.ReadKey(true));

        return shouldGameContinue;
    }

    private static bool Frame(GameState state, ConsoleKeyInfo input)
    {
        state.Arena.Update(state.Player);

        if (!state.Player.Combat.IsAlive)
        {
            return false;
        }
        return true;
    }
}
