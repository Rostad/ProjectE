using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionPoints : MonoBehaviour
{

    public int MaxActionEnergy = 300;
    public float ActionEnergyRegen;


    private float currentActionEnergy;

    public int CurrentActionPoints
    {
        get { return (int) currentActionEnergy / 100; }
    }

    public bool CanSpend(int amount)
    {
        return CurrentActionPoints > 0;
    }


    public void AddActionEnergy(float amount)
    {
        currentActionEnergy += amount;
        currentActionEnergy = Mathf.Clamp(currentActionEnergy, 0, MaxActionEnergy);
    }

    private void Update()
    {
        AddActionEnergy(ActionEnergyRegen);
    }



}
