using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatPuppet : UniversalData, ICombatObject
{
    public RadarInfo PercivedRadarInfo;
    public float Initiative = 0;
    public ICommanderInfo Owner;

    public void Start()
    {
        DetermineInitiative();
    }

    public void UpdatePosition()
    {
        
    }

    public BaseStats Stats
    {
        get
        {
            return Stats;
        }
    }

    public Equipment ReturnEquipmentOfType(EquipmentType _equipmentType)
    {
        foreach (Equipment equipment in equipment)
        {
            if (equipment.equipmentType == _equipmentType)
            {
                return equipment;
            }
        }
        throw new System.Exception("Ship: " + universalName + " has no equipment of type: " + _equipmentType);
    }

    public float ReportInitiative()
    {
        DetermineInitiative();
        return Initiative;
    }

    void DetermineInitiative()
    {
        Initiative = _attributes.Engines + _attributes.Affinity +_attributes.AI;
    }

    public void SetOwner(ICommanderInfo _owner)
    {
        Owner = _owner;
    }

    public void SetBaseAttributes()
    {
        _attributes = ScriptableObject.CreateInstance<Attributes>();


        _attributes.Size = Random.Range(1, 100);
        _attributes.Engines = Random.Range(1, 100);
        _attributes.HeatManagement = Random.Range(1, 100);
        _attributes.Structure = Random.Range(1, 100);
        _attributes.Affinity = Random.Range(1, 100);
        _attributes.AI = Random.Range(1, 100);
        _attributes.ArmorRating = Random.Range(1, 100);
    }
}
