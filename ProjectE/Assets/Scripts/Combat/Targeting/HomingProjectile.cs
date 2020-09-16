using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class HomingProjectile : MonoBehaviour
{
    public float speed;
    public float maxLifeTime;
    public GameObject Prefab;
    public GameObject target;
    //private ITargetable target;
    private GameObject projectile;

    public void Start()
    {
        projectile = Instantiate(Prefab, this.transform.position, Quaternion.identity);
        projectile.transform.parent = this.gameObject.transform;
    }

    /*public HomingProjectile(GameObject Prefab, ITargetable target)
    {
        projectile = Instantiate(Prefab, Vector3.zero, Quaternion.identity);
        this.target = target;
    }*/

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, target.transform.position, speed * Time.deltaTime);
    }
}
