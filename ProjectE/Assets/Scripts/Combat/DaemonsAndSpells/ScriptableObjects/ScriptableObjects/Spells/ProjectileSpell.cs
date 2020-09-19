using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileSpell", menuName = "ScriptableObjects/Spell")]
public class ProjectileSpell : Spell
{

    public float projectileSpeed;

    public override void perform(CombatEntity caster, CombatEntity target)
    {
        base.perform(caster, target);
        GameObject projectileGameobject = new GameObject();
        projectileGameobject.transform.position = caster.transform.position;
        HomingProjectile hp = projectileGameobject.AddComponent<HomingProjectile>();
        hp.Setup(spellVFX, target, this, projectileSpeed);
        
    }


    public void HitCallback()
    {
        foreach(SpellBehaviour sb in spellBehaviours)
        {
            sb.Apply(caster, target);
        }
    }
}
