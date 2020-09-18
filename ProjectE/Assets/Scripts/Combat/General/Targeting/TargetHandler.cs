using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TargetHandler : MonoBehaviour
{
    public static TargetHandler instance;

    public event EventHandler<EventArgs> OnTargetsChanged;

    private List<CombatEntity> targets;
    

    // Start is called before the first frame update
    void Start()
    {
        targets = new List<CombatEntity>();
        instance = this;
    }

   
    public List<CombatEntity> GetTargets()
    {
        return targets;
    }

    public void AddTarget(CombatEntity target)
    {
        targets.Add(target);
        OnTargetsChanged?.Invoke(this, EventArgs.Empty);
    }

    public void RemoveTarget(CombatEntity target)
    {
        targets.Remove(target);
        OnTargetsChanged?.Invoke(this, EventArgs.Empty);
    }



}
