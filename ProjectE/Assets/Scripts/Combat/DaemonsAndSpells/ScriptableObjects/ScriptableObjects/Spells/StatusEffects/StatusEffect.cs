using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "StatusEffect", menuName = "ScriptableObjects/StatusEffect")]
public class StatusEffect : ScriptableObject
{

    public List<StatusBehaviour> statusBehaviours;
    public float statusDuration;
    public string statusName;
    public Image statusImage;

    protected float timeAdded;
    protected CombatEntity target;
    protected CombatEntity caster;

    public void Initialize(CombatEntity caster, CombatEntity target)
    {
        this.target = target;
        this.caster = caster;
        foreach(StatusBehaviour sb in statusBehaviours)
        {
            sb.Initialize(statusDuration, caster, target);
        }
    }

    public void OnAdd()
    {
        timeAdded = Time.time;
        foreach(StatusBehaviour sb in statusBehaviours)
        {
            sb.OnAdd();
        }
    }

    public void OnRemove()
    {
        foreach(StatusBehaviour sb in statusBehaviours)
        {
            sb.OnRemove();
        }
    }

    //Returns true if the buff has run out and should be removed
    public bool Update()                        
    {
        foreach(StatusBehaviour sb in statusBehaviours)
        {
            sb.Update();
        }

        if(Time.time > timeAdded + statusDuration)
        {
            return true;
        }

        return false;
    }

    public void Refresh()
    {
        timeAdded = Time.time;
    }


}
