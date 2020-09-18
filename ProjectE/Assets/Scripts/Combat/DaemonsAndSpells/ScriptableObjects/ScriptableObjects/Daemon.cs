using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Daemon", menuName = "ScriptableObjects/Daemon")]
public class Daemon : ScriptableObject
{

    public string daemonName;
    public Image daemonPicture;
    public AttributeTypes daemonAttribute;

}
