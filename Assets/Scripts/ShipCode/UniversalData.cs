using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New ShipData", menuName = "ScriptableObjects/ShipData", order = 1)]
public class UniversalData : ScriptableObject
{
    protected string universalName = "none";

    [SerializeField]
    protected BaseStats _baseStats;
    [SerializeField]
    protected Attributes _attributes;
    [SerializeField]
    protected List<Equipment> equipment = new List<Equipment>();
    [SerializeField]
    protected CombatObjectTypes combatObjectType = CombatObjectTypes.AntiShip;

    public Attributes Attributes
    {
        get
        {
            return _attributes;
        }
        set
        {
            _attributes = value;
        }
    }

    public string UniversalName
    {
        get
        {
            return universalName;
        }

        set
        {
            universalName = value;
        }
    }

}

