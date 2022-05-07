using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultCombatPuppet : UniversalData, ICombatObject//Implemented object for a combat scene
{
    public RadarInfo PercivedRadarInfo;
    public float Initiative = 0;
    private ICommanderInfo _ownerID;
    public ParticleSystem OnDeathEffect;

    public void Start()
    {
        DetermineInitiative();
        currentState = _baseStats;
    }
    
    public ICommanderInfo OwnerID
    {
        get => _ownerID;
        set => _ownerID = value; 
    }

    public void UpdatePosition()
    {
        
    }

    public void ProcessEquipmentEffect(Equipment equipment)
    {
        
    }
   

    public Equipment ReturnEquipmentOfType(EquipmentType _equipmentType)
    {
        foreach (Equipment equipment in Equipment)
        {
            if (equipment.EquipmentType == _equipmentType)
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

    public void GenerateBaseAttributes()
    {
        _attributes = ScriptableObject.CreateInstance<Attributes>();


        _attributes.Size = Random.Range(1, 10);
        _attributes.Engines = Random.Range(1, 10);
        _attributes.HeatManagement = Random.Range(1, 10);
        _attributes.Structure = Random.Range(1, 10);
        _attributes.Affinity = Random.Range(1, 10);
        _attributes.AI = Random.Range(1, 10);
        _attributes.ArmorRating = Random.Range(1, 10);
    }

    public void GenerateBaseStats()
    {
        _baseStats = ScriptableObject.CreateInstance<BaseStats>();

        _baseStats.maxPwrSupply = Random.Range(1, 10);
        _baseStats.maxHp = Random.Range(1, 10);
        _baseStats.maxSpeed =  Random.Range(1, 10);
        _baseStats.maxCharge = Random.Range(1, 10);
        _baseStats.maxEvasion = Random.Range(1, 10);
        _baseStats.maxDissipation = Random.Range(1, 10);
        _baseStats.maxLuck = Random.Range(1, 10);
        _baseStats.maxResistance = Random.Range(1, 10);
        _baseStats.maxHeat = Random.Range(1, 10);
        _baseStats.maxShield = Random.Range(1, 10);
        _baseStats.maxRadarRange = Random.Range(1, 10);

        currentState = _baseStats; 
    }

    public ICombatObject ImplementUniversalData(UniversalData universalData)
    {
        DefaultCombatPuppet puppet = ScriptableObject.CreateInstance<DefaultCombatPuppet>();
        puppet.Attributes = universalData.Attributes;
        puppet.Stats = universalData.Stats;
        puppet.currentState = universalData.currentState;
        puppet.universalName = universalData.universalName;
        PercivedRadarInfo = new RadarInfo();

        return puppet;
    }

    public void OnDeath()
    {
        OnDeathEffect.Play();
    }
}
