using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatModifier
{

    private float modifyAmount;
    private bool isPercentage;
    private StatusType statusType;

    public StatModifier(float modifyAmount, bool isPercentage, StatusType statusType)
    {
        this.modifyAmount = modifyAmount;
        this.isPercentage = isPercentage;
        this.statusType = statusType;
    }

    public float ModifyStat(float stats)
    {
        
        

        if (isPercentage)
        {
            return (stats * modifyAmount) * (int)statusType;
        }

        return modifyAmount * (int)statusType;
    }

}
