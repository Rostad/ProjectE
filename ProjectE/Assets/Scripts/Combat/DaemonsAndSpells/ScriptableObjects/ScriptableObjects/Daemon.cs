using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Daemon", menuName = "ScriptableObjects/Daemon")]
public class Daemon : ScriptableObject
{

    public string daemonName;
    public Image daemonPicture;
    public AttributeType daemonAttribute;
    public List<NameStatPair> statNameAndAmount;
    public List<NameResistancePair> attributeResistances;
    public Spell[] startingSpells;


    [System.Serializable]
    public class NameStatPair
    {
        public StatType statType;
        public float value;

    }

    [System.Serializable]
    public class NameResistancePair
    {
        public AttributeType resistantAttribute;
        public ResistanceStrength resistanceStrength;

    }
}
