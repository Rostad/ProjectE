﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CombatEntity : MonoBehaviour
{

    public string entityName;
    public Sprite entitySprite;
    public TargetType entityTargetType;

   





    public TargetInformation GetTargetInformation()
    {
        return new TargetInformation(entityName, GetHealth(), entitySprite, entityTargetType);
    }

    //Placeholder for Proof of Concept where enemies and the player will be primitive shapes. For the proof of concept they'll shoot spells from a position just infront of them.
    //If the combatentity is an object the origin is ontop of them.
    public Vector3 GetCastOrigin()
    {
    
        if(entityTargetType == TargetType.Object)
        {
            return transform.position;
        }

        return transform.forward * 1.5f;                

    }

    protected abstract int GetHealth();

    public abstract int GetStat(StatType statType);

    public abstract void DoDamage(int damage, AttributeType attributeType);

    public abstract void ApplyStatus(CombatEntity caster, StatusEffect statusEffect);

    public abstract void AddStatModifier(StatType statusType, StatModifier statModifier);

    public abstract void RemoveStatModifier(StatType statusType, StatModifier statModifier);
    
}
