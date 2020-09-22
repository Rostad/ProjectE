using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StatusBehaviour : ScriptableObject
{

    protected float statusDuration;
    protected CombatEntity target;
    protected CombatEntity caster;


    public virtual void Initialize(float statusDuration, CombatEntity caster, CombatEntity target)
    {
        this.statusDuration = statusDuration;
        this.caster = caster;
        this.target = target;
    }

    public abstract void OnAdd();
    public abstract void Update();
    public abstract void OnRemove();
    public abstract void OnRefresh();
}
