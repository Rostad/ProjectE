using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// <c>Spell</c> is an abstract class for spells such as SingleTargetSpells to extend.
/// A spell has a name, a tooltip and an attribute that will be displayed in the user interface to provide players info about what it's name is and what it does.
///  A spell's function is to perform several SpellBehaviours on a target. A SpellBehaviour can for example deal fire damage or modify a character stat.
/// 
///  The spellAttribute has no function outside of providing information as dealing damage is handled by eventual connected SpellBehaviours.
/// 
///  spellVFX is the visual effects that this spell uses. Currently there is no way to handle impact and cast VFX
/// 
///  SpellBehaviours contain the list of all SpellBehaviours to be executed on the target.
/// 
///  target is what the SpellBehaviours will be applied to.
/// 
///  caster is the source of the spell, i.e who casted the spell.
/// 
///  perform sets the caster and target, spells that extend this class will need to implement a way to apply the SpellBehaviours on the target
/// </summary>
public abstract class Spell : ScriptableObject
{
    public string spellName;
    public string tooltip;
    public float manaCost;
    public AttributeType spellAttribute;
    public GameObject spellVFX;
    public SpellBehaviour[] spellBehaviours;

    protected CombatEntity target;
    protected CombatEntity caster;

    public virtual void perform(CombatEntity caster, CombatEntity target) {
        this.caster = caster;
        this.target = target;
    }

}
