using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionBarsDisplay : MonoBehaviour
{

    public Image[] actionBarImages;


    // Start is called before the first frame update
    void Start()
    {
        actionBarImages = GetComponentsInChildren<Image>();
        var actionPoints = GameObject.Find("Player").GetComponent<ActionPoints>();
        actionPoints.OnActionEnergyChanged += OnActionEnergyChanged;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnActionEnergyChanged(object Sender, ActionPoints.OnActionEnergyChangedEventArgs e)
    {
        if(e.newActionPoints == 3)
        {
            foreach(Image image in actionBarImages)
            {
                image.fillAmount = 1;
            }
        }
        else if(e.newActionPoints == 0)
        {
            actionBarImages[0].fillAmount = e.newActionEnergy / 100;
            actionBarImages[1].fillAmount = 0;
            actionBarImages[2].fillAmount = 0;
        }
        else
        {
            for(int i = 0; i < e.newActionPoints; i++)
            {
                actionBarImages[i].fillAmount = 1;
            }
            actionBarImages[e.newActionPoints].fillAmount = e.newActionEnergy / 100;
        }
    }
}
