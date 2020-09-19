using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBehaviour : SpellBehaviour
{

    public int damage;
    public AttributeTypes attributeType;


    public override void Apply(CombatEntity caster, CombatEntity target)
    {
        target.DoDamage(damage, attributeType);
    }
}
