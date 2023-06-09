﻿using BasedGame.Components;
using BasedGame.Entities;

namespace BasedGame;

internal static class Drawing
{
    internal static void DrawGame(GameState state)
    {
        SyncAndClearConsole(state.Settings);

        DrawHUD(state);
        if (state.Arena.IsVisible)
        {
            DrawArena(state);
        }

        static void SyncAndClearConsole(GameSettings settings)
        {
            int w = settings.Width;
            int h = settings.Height;

            Sync(w, h);
            Console.Clear();

            static void Sync(int w, int h)
            {
                Console.SetWindowSize(w, h);
                Console.SetBufferSize(w, h);
                Console.SetWindowSize(w, h);
                Console.CursorVisible = false;
            }
        }

        static void DrawHUD(GameState state)
        {
            DrawLine(1, 0, state.Settings.Width - 2, '=');
            Draw(5, 2, $"[ Level: {state.Player.Level} | XP: {state.Player.Xp}/{state.Player.MaxXp} ]");
            DrawLine(1, 4, state.Settings.Width - 2, '=');
            DrawLine(1, state.Settings.Height - 2, state.Settings.Width - 2, '=');
        }

        static void DrawArena(GameState state)
        {
            Draw(10, 8, "Player");
            DrawCombatant(10, 9, state.Player.Combat);

            if (state.Arena.Enemy != null)
            {
                Draw(30, 8, "Enemy");
                DrawCombatant(30, 9, state.Arena.Enemy.Combat);
            }

            if (state.Arena.Enemy != null && !state.Arena.Enemy.Combat.IsAlive)
            {
                Draw(20, 20, "The enemy dies!");
                Draw(20, 22, $"Reward: {state.Arena.Enemy.XpReward} XP");
            }
        }

        static void DrawCombatant(int x, int y, CombatComponent combat)
        {
            Draw(x, y, $"HP: {combat.Health}/{combat.MaxHealth}");
            Draw(x, y + 1, $"STR: {combat.Strength}");
        }

        static void DrawLine(int startX, int startY, int width, char ch)
        {
            for (int x = startX; x < width + startX; x++)
            {
                Draw(x, startY, ch);
            }
        }

        static void DrawArea(int startX, int startY, int width, int height, char ch)
        {
            for (int y = startY; y < height + startY; y++)
            {
                for (int x = startX; x < width + startX; x++)
                {
                    Draw(x, y, ch);
                }
            }
        }

        static void DrawBorder(int startX, int startY, int width, int height, char ch)
        {
            for (int y = startY; y < (height + startY); y++)
            {
                for (int x = startX; x < (width + startX); x++)
                {
                    if (x == startX ||
                        y == startY ||
                        x == width - 1 ||
                        y == height - 1)
                    {
                        Draw(x, y, ch);
                    }
                }
            }
        }

        static void Draw(int x, int y, object value)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(value);
        }
    }
}
