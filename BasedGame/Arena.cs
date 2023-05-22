using BasedGame.Components;
using BasedGame.Entities;

namespace BasedGame;

internal class Arena
{
    private int _battleEndTimer;
    private bool _isPlayerTurn = true;

    internal Enemy? Enemy { get; private set; }
    internal bool IsVisible { get; private set; }

    internal void Update(Player player)
    {
        if (Enemy != null) 
        {
            if (Enemy.Combat.IsAlive)
            {
                if (_isPlayerTurn)
                {
                    player.Combat.Attack(Enemy.Combat);
                    _isPlayerTurn = false;
                }
                else
                {
                    Enemy.Combat.Attack(player.Combat);
                    _isPlayerTurn = true;
                }
            }
            else
            {
                _battleEndTimer++;
                if (_battleEndTimer >= 1)
                {
                    player.Xp += Enemy.XpReward;
                    StartNewBattle();
                }
            }
        }
    }

    internal void StartNewBattle()
    {
        Enemy = new();
        IsVisible = true;
    }

    private void EndBattle()
    {
        Enemy = null;
        IsVisible = false;
    }
}
