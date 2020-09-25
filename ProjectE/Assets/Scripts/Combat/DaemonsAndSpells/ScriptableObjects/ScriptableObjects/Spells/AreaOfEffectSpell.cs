using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AreaOfEffectSpell", menuName = "ScriptableObjects/Spell/AreaOfEffectSpell")]
public class AreaOfEffectSpell : Spell
{
    public float overlapBoxLength;
    public float overlapBoxWidth;

    private LayerMask layerMask;
    

    public override void perform(CombatEntity caster, CombatEntity target)
    {        
        base.perform(caster, target);

        Vector3 targetPosition = new Vector3(target.transform.position.x, caster.transform.position.y, target.transform.position.z);

        var vfxGameObject = SpawnVFX(targetPosition);

        Vector3 direction = targetPosition - caster.transform.position;

        Vector3 overlapBoxPosition = caster.transform.position + (direction.normalized * (overlapBoxLength / 2));



        Collider[] hits = Physics.OverlapBox(overlapBoxPosition, new Vector3(overlapBoxLength / 2, 2, overlapBoxWidth / 2), Quaternion.identity, layerMask);

        List<CombatEntity> combatEntitiesHit = new List<CombatEntity>();

        
        foreach(Collider coll in hits)
        {
            CombatEntity entityHit = coll.GetComponent<CombatEntity>();
            combatEntitiesHit.Add(entityHit);
        }

        if (combatEntitiesHit.Contains(caster))
        {
            combatEntitiesHit.Remove(caster);
        }

        foreach(CombatEntity cEntity in combatEntitiesHit)
        {
            foreach(SpellBehaviour sb in spellBehaviours)
            {
                sb.Apply(caster, cEntity);
            }
        }

    }

    public GameObject SpawnVFX(Vector3 targetPos)
    {
        var vfxGameobject = Instantiate(spellVFX, caster.transform.position, Quaternion.identity);
        vfxGameobject.transform.LookAt(targetPos);
        return vfxGameobject;
    }

    private void OnEnable()
    {
        layerMask = LayerMask.GetMask("CombatEntity");
    }
}
