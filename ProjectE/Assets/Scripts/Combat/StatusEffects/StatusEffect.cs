using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class StatusEffect : ScriptableObject
{

    public float statusDuration;
    public string statusName;
    public Image statusImage;
    public StatusType statusType;

    protected float timeAdded;
    protected CombatEntity combatEntity;

    public virtual void OnAdd()
    {
        //Add eventual icons to UI
    }

    public virtual void OnRemove()
    {
        //Remove eventual icons from UI
    }

    //Returns true if the buff has run out and should be removed
    public virtual bool Update()                        
    {
        if(Time.time > timeAdded + statusDuration)
        {
            return true;
        }

        return false;
    }

    public virtual void Refresh()
    {
        timeAdded = Time.time;
    }


}
