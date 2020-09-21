using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatModifierEffect : StatusEffect
{

    public string statName;
    public float modifyAmount;
    public bool isPercentage;

    private StatModifier statModifier;


    public override void OnAdd()
    {
        base.OnAdd();

        statModifier = new StatModifier(modifyAmount, isPercentage, statusType);
    }


}
