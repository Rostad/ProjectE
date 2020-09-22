using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatModifier
{

    private float modifyAmount;
    private bool isPercentage;

    public StatModifier(float modifyAmount, bool isPercentage)
    {
        this.modifyAmount = modifyAmount;
        this.isPercentage = isPercentage;
    }

    public float ModifyStat(float stats)
    {
        
        

        if (isPercentage)
        {
            return stats * modifyAmount;
        }

        return modifyAmount;
    }

}
