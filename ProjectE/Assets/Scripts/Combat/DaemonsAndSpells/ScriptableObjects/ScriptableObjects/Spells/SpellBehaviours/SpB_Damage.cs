using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SBDamage", menuName = "ScriptableObjects/SpellBehaviours/SBDamage")]
public class SpB_Damage : SpellBehaviour
{

    public float strengthScaling;
    public float magicScaling;
    public AttributeType attributeType;


    public override void Apply(CombatEntity caster, CombatEntity target)
    {
        float damage = (caster.GetStat(StatType.Strength) * strengthScaling) + (caster.GetStat(StatType.Magic) * magicScaling);

        target.DoDamage((int)damage, attributeType);
    }
}
