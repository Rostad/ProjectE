using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CombatEntity
{

    
    

    private Mana mana;
    private Health playerHealth;
    private ActionPoints actionPoints;


    

    // Start is called before the first frame update
    void Start()
    {
        CacheComponents();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerInputs.instance.ActionButton)
        {
            //GamePauser.ShouldPause(!GamePauser.IsPaused);
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0.05f;
            }
            else
            {
                Time.timeScale = 1;
            }

            
        }
    }

    private void CacheComponents()
    {
        mana = GetComponent<Mana>();
        playerHealth = GetComponent<Health>();
        actionPoints = GetComponent<ActionPoints>();
    }

    private void MouseTargeting()
    {

    }

    private void ATBActivate()
    {

    }

    protected override int GetHealth()
    {
        throw new System.NotImplementedException();
    }
}
