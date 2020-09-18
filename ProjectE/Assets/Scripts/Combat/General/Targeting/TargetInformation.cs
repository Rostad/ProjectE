using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct TargetInformation
{

    public string name;
    public int health;
    public Sprite sprite;
    public TargetType targetType;

    public TargetInformation(string name, int health, Sprite sprite, TargetType targetType)
    {
        this.name = name;
        this.health = health;
        this.sprite = sprite;
        this.targetType = targetType;
    }

}
