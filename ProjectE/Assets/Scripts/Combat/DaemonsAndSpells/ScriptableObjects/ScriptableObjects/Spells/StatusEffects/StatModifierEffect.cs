using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StatModifierBehaviour", menuName = "ScriptableObjects/StatusBehaviour")]
public class StatModifierEffect : StatusBehaviour
{

    public StatType statName;
    public float modifyAmount;
    public bool isPercentage;

    private StatModifier statModifier;


    public override void OnAdd()
    {

        statModifier = new StatModifier(modifyAmount, isPercentage);

        target.AddStatModifier(statName, statModifier);

        
    }

    public override void OnRefresh()
    {}

    public override void OnRemove()
    {
        target.RemoveStatModifier(statName, statModifier);
    }

    public override void Update()
    {}
}
