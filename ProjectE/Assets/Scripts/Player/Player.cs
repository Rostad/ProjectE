using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CombatEntity
{

    
    

    private Mana mana;
    private Health playerHealth;
    private ActionPoints actionPoints;

    public Spell testSpell;
    public Enemy testTarget;


    

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
            /*if (Time.timeScale == 1)
            {
                Time.timeScale = 0.05f;
            }
            else
            {
                Time.timeScale = 1;
            }*/

            testSpell.perform(this, testTarget);

            
        }
    }

    private void CacheComponents()
    {
        mana = GetComponent<Mana>();
        playerHealth = GetComponent<Health>();
        actionPoints = GetComponent<ActionPoints>();
    }

    protected override int GetHealth()
    {
        throw new System.NotImplementedException();
    }

    public override void DoDamage(int Damage, AttributeType attributeType)
    {
        throw new System.NotImplementedException();
    }

    public override void ApplyStatus(CombatEntity caster, StatusEffect statusEffect)
    {
        throw new System.NotImplementedException();
    }

    public override int GetStat(StatType statType)
    {
        if (statType == StatType.Strength)
        {
            return 0;
        }
        else
        {
            return 6;
        }
    }

    public override void AddStatModifier(StatType statusType, StatModifier statModifier)
    {
        throw new System.NotImplementedException();
    }

    public override void RemoveStatModifier(StatType statusType, StatModifier statModifier)
    {
        throw new System.NotImplementedException();
    }

    private void OnDrawGizmos()
    {
        float width = 10;
        float lenght = 20;

        Vector3 targetPosition = new Vector3(testTarget.transform.position.x, transform.position.y, testTarget.transform.position.z);

        Vector3 direction = targetPosition - transform.position;

        var cubePos = transform.position + (direction.normalized * (lenght / 2));

        Gizmos.DrawWireCube(cubePos, new Vector3(lenght / 2, 2, width / 2));

        
    }
}
