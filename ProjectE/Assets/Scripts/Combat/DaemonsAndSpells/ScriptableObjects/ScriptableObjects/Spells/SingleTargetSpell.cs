using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SingleTargetSpell", menuName = "ScriptableObjects/Spell/SingleTargetSpell")]
public class SingleTargetSpell : Spell
{

    public override void perform(CombatEntity caster, CombatEntity target)
    {
        base.perform(caster, target);

        Instantiate(spellVFX, target.transform);

        foreach(SpellBehaviour sb in spellBehaviours)
        {
            sb.Apply(caster, target);
        }
    }
}
