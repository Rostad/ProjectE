using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class HomingProjectile : MonoBehaviour
{
    public float speed;
    public float maxLifeTime;
    public CombatEntity target;
    //private ITargetable target;
    private GameObject spellVFX;
    private ProjectileSpell castedSpell;

    public void Setup(GameObject spellVFX, CombatEntity target, ProjectileSpell castedSpell, float projectileSpeed)
    {
        this.spellVFX = Instantiate(spellVFX, transform.position, Quaternion.identity);
        this.spellVFX.transform.SetParent(transform);
        this.target = target;
        this.castedSpell = castedSpell;
        speed = projectileSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);

        if(Vector3.Distance(transform.position, target.transform.position) < 0.2f)
        {
            castedSpell.HitCallback();
            Destroy(this.gameObject);
        }
    }
}
