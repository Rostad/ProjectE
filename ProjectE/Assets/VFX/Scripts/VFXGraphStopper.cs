using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VFXGraphStopper : MonoBehaviour
{

    public float timeUntilStop;

    private VisualEffect visualEffect;
    private float timeSpawned;


    // Start is called before the first frame update
    void Start()
    {
        visualEffect = GetComponent<VisualEffect>();
        timeSpawned = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeSpawned+ timeUntilStop) 
        {
            visualEffect.Stop();
            Destroy(this);
        }
    }
}
