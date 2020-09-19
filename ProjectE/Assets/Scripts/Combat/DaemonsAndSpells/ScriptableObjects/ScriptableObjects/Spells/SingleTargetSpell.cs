﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTargetSpell : Spell
{

    public override void perform(CombatEntity caster, CombatEntity target)
    {
        base.perform(caster, target);

        foreach(SpellBehaviour sb in spellBehaviours)
        {
            sb.Apply(caster, target);
        }
    }
}
