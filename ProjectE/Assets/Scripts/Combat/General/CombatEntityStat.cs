using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CombatEntityStat
{

    public float Value 
    { 
        get 
        {
            if (isDirty)
            {
                lastCalculatedValue = CalculateModifiedValue();
                isDirty = false;
            }
            return lastCalculatedValue;
        } 
    }

    private string name;
    private float baseValue;
    private bool isDirty = true;
    private float lastCalculatedValue;

    private readonly List<StatModifier> statModifiers;

    public CombatEntityStat(string name, float baseValue)
    {
        this.name = name;
        this.baseValue = baseValue;

        statModifiers = new List<StatModifier>();
    }


    public void AddModifier(StatModifier addMod)
    {
        statModifiers.Add(addMod);
        isDirty = true;
        
    }

    public void RemoveModifier(StatModifier removeMod)
    {
        statModifiers.Remove(removeMod);
        isDirty = true;
    }

    private float CalculateModifiedValue()
    {
        if (statModifiers.Count == 0)
        {
            return baseValue;
        }

        float ModifiedValue = baseValue;

        foreach(StatModifier m in statModifiers)
        {
            ModifiedValue += m.ModifyStat(baseValue);
        }

        return (float)Math.Round(ModifiedValue, 4);

     
    }

}
