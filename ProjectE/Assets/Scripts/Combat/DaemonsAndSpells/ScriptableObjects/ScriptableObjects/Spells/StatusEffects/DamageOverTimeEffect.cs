using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOverTimeEffect : StatusEffect
{

    public int totalDamage;
    public int totalTicks;
    public AttributeTypes damageType;


    private int tickDamage
    {
        get { return totalDamage / totalTicks; }
    }

    private float tickInterval
    {
        get { return statusDuration / totalTicks; }
    }

    private float timeSinceLastTick;

    public override void OnAdd()
    {
        base.OnAdd();
        target.DoDamage(tickDamage, damageType);
        timeSinceLastTick = Time.time;
    }

    public override bool Update()
    {
        if(Time.time >= timeSinceLastTick + tickInterval)
        {
            target.DoDamage(tickDamage, damageType);
            timeSinceLastTick = Time.time;
        }


        return base.Update();
    }

    public override void Refresh()
    {
        base.Refresh();
        target.DoDamage(tickDamage, damageType);
        timeSinceLastTick = Time.time;
    }

}
