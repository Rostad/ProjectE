using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : ScriptableObject
{
    public string spellName;
    public string tooltip;
    public float manaCost;
    public AttributeTypes spellAttribute;
    public GameObject spellVFX;

    protected CombatEntity target;
    protected CombatEntity caster;

    public virtual void perform(CombatEntity caster, CombatEntity target) {
        this.caster = caster;
        this.target = target;
    }
}
