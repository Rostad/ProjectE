using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXDestroyer : MonoBehaviour
{
    public float timeUntilDestroy;

    private float timeCreated;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeCreated + timeUntilDestroy)
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        timeCreated = Time.time;
    }
}
