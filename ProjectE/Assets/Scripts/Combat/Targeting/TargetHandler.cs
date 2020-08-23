using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TargetHandler : MonoBehaviour
{
    public static TargetHandler instance;

    public event EventHandler<EventArgs> OnTargetsChanged;

    private List<ITargetable> targets;
    

    // Start is called before the first frame update
    void Start()
    {
        targets = new List<ITargetable>();
        instance = this;
    }

   
    public List<ITargetable> GetTargets()
    {
        return targets;
    }

    public void AddTarget(ITargetable target)
    {
        targets.Add(target);
        OnTargetsChanged?.Invoke(this, EventArgs.Empty);
    }

    public void RemoveTarget(ITargetable target)
    {
        targets.Remove(target);
        OnTargetsChanged?.Invoke(this, EventArgs.Empty);
    }



}
