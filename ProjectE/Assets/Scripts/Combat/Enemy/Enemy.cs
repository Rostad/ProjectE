using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Enemy : CombatEntity
{
    public int maxHealth;

    private int health;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        entityTargetType = TargetType.Enemy;
        statusEffects = new List<StatusEffect>();
    }

    private List<StatusEffect> statusEffects;

    // Update is called once per frame
    void Update()
    {
        foreach(StatusEffect s in statusEffects.ToList())
        {
            if (s.Update())
            {
                s.OnRemove();
                statusEffects.Remove(s);
            }
        }
    }


    
    private void OnBecameVisible()
    {

        TargetHandler.instance.AddTarget(this);
        
    }

    private void OnBecameInvisible()
    {
        TargetHandler.instance.RemoveTarget(this);
        
    }

    protected override int GetHealth()
    {
        throw new System.NotImplementedException();
    }

    public override void DoDamage(int Damage, AttributeType attributeType)
    {
        Debug.Log("I just took: " + Damage + " of type: " + attributeType.ToString());
    }

    public override void ApplyStatus(CombatEntity caster, StatusEffect statusEffect)
    {
        statusEffects.Add(statusEffect);
        statusEffect.OnAdd();
    }

    public override int GetStat(StatType statType)
    {
        throw new System.NotImplementedException();
    }

    public override void AddStatModifier(StatType statusType, StatModifier statModifier)
    {
        throw new System.NotImplementedException();
    }

    public override void RemoveStatModifier(StatType statusType, StatModifier statModifier)
    {
        throw new System.NotImplementedException();
    }
}
