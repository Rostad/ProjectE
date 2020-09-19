using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpellBehaviour : ScriptableObject
{
    public abstract void Apply(CombatEntity caster, CombatEntity target);
}
