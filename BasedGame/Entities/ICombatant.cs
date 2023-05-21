using BasedGame.Components;

namespace BasedGame.Entities;

interface ICombatant
{
    CombatComponent Combat { get; }
}