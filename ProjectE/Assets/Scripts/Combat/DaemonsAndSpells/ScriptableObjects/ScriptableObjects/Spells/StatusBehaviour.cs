using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusBehaviour : SpellBehaviour
{
    public StatusEffect statusEffect;

    public override void Apply(CombatEntity caster, CombatEntity target)
    {
        target.ApplyStatus(caster, statusEffect);
    }
}
