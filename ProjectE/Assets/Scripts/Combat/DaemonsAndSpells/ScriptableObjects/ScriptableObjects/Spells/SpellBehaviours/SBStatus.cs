using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SBStatus", menuName = "ScriptableObjects/SpellBehaviours/SBStatus")]
public class SBStatus : SpellBehaviour
{
    public StatusEffect statusEffect;

    public override void Apply(CombatEntity caster, CombatEntity target)
    {
        statusEffect.Initialize(caster, target);
        target.ApplyStatus(caster, statusEffect);
    }
}
