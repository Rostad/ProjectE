using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, ITargetable
{

    public Sprite uiSprite;

    private TargetInformation targetInformation;

    // Start is called before the first frame update
    void Start()
    {
        targetInformation = new TargetInformation(this.name, 100, uiSprite, TargetType.Enemy);
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

    public TargetInformation GetTargetInformation()
    {
        return targetInformation;
    }
}
