using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New ShipData", menuName = "ScriptableObjects/ShipData", order = 1)]
public class UniversalData : ScriptableObject//Implemented data handling class
{
    [SerializeField]
    public string universalName = "none";

    [SerializeField]
    protected BaseStats _baseStats;
    [SerializeField]
    protected Attributes _attributes;
    [SerializeField]
    private List<Equipment> equipment = new List<Equipment>();
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

    public BaseStats Stats
    {
        get
        {
            return _baseStats;
        }

        set { _baseStats = value; }
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

    public List<Equipment> Equipment { get => equipment; set => equipment = value; }
}

