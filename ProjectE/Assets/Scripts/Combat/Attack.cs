using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Attack : ScriptableObject
{
    [Tooltip("The name of the attack, used in the user interface")]
    public string Name = "Attack";
    [Tooltip("The amount of time in seconds until the weapon that performed this attack can act again")]
    public float BaseCooldown = 1.0f;
    public DamageType DamageType = DamageType.None;

    public abstract void TriggerAttack(GameObject target);
    public abstract void Initialize(GameObject gameObject);

}
