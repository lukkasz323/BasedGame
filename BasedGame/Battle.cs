using BasedGame.Components;

namespace BasedGame;

internal class Battle
{
    private readonly CombatComponent _playerCombat = new();
    private bool _isPlayerTurn = true;
    
    internal CombatComponent EnemyCombat { get; } = new();

    internal Battle(CombatComponent playerCombat)
    {
        _playerCombat = playerCombat;
    }

    internal void NextTurn()
    {
        if (_isPlayerTurn)
        {
            _playerCombat.Attack(EnemyCombat);
            _isPlayerTurn = false;
        }
        else
        {
            EnemyCombat.Attack(_playerCombat);
            _isPlayerTurn = true;
        }
    }
}
