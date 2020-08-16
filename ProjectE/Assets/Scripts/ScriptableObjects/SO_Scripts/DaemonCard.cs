using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "DaemonCard", menuName = "ScriptableObjects/DaemonCard")]
public class DaemonCard :ScriptableObject
{

    public string cardName;
    public Image cardPicture;
    public AttributeTypes cardAttribute;

}
