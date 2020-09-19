using System.Collections;
using System.Collections.Generic;
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
    }

    // Update is called once per frame
    void Update()
    {
        
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

    public override void DoDamage(int Damage, AttributeTypes attributeType)
    {
        throw new System.NotImplementedException();
    }

    public override void ApplyStatus(CombatEntity caster, StatusEffect statusEffect)
    {
        throw new System.NotImplementedException();
    }
}
