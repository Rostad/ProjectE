using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Mana mana;
    private Health health;
    private ActionPoints actionPoints;

    // Start is called before the first frame update
    void Start()
    {
        CacheComponents();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CacheComponents()
    {
        mana = GetComponent<Mana>();
        health = GetComponent<Health>();
        actionPoints = GetComponent<ActionPoints>();
    }
}
