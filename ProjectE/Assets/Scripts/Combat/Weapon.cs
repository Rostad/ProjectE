using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Attack[] Attacks;
    public string WeaponName ="A weapon";
    [Tooltip("Weapon attack range radius in units")]
    public float WeaponAttackRange = 5.0f;
    [Tooltip("Base weapon damage")]
    public float BaseDamageStat = 10f;
    
}
