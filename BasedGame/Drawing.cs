namespace BasedGame;

internal static class Drawing
{
    internal static void DrawGame(GameState state)
    {
        ClearAndSyncConsole();

        DrawScene(state);
    }

    private static void DrawScene(GameState state)
    {

    }

    private static void ClearAndSyncConsole()
    {
        int windowSize = 30;
        int w = windowSize * 2;
        int h = windowSize;

        Console.SetWindowSize(w, h);
        Console.SetBufferSize(w, h);
        Console.SetWindowSize(w, h);
        Console.SetCursorPosition(0, 0);
        Console.CursorVisible = false;
    }
}
