using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DamageOverTime", menuName = "ScriptableObjects/StatusBehaviour")]
public class DamageOverTimeEffect : StatusBehaviour
{

    public float strengthScaling;
    public float magicScaling;
    public int totalTicks;
    public AttributeType damageType;


    private int totalDamage;
    private float timeSinceLastTick;
    private int tickDamage
    {
        get { return totalDamage / totalTicks; }
    }

    private float tickInterval
    {
        get { return statusDuration / totalTicks; }
    }

    public override void Initialize(float statusDuration, CombatEntity caster, CombatEntity target)
    {
        base.Initialize(statusDuration, caster, target);
        var d = (caster.GetStat(StatType.Strength) * strengthScaling) + (caster.GetStat(StatType.Magic) * magicScaling);
        totalDamage = (int)d;
    }

    public override void OnAdd()
    {
        target.DoDamage(tickDamage, damageType);
        timeSinceLastTick = Time.time;
    }

    public override void Update()
    {
        if(Time.time >= timeSinceLastTick + tickInterval)
        {
            target.DoDamage(tickDamage, damageType);
            timeSinceLastTick = Time.time;
        }


    }

    public override void OnRefresh()
    {
        target.DoDamage(tickDamage, damageType);
        timeSinceLastTick = Time.time;
    }

    public override void OnRemove()
    {
        Debug.Log("Poison was removed");   
    }
}
