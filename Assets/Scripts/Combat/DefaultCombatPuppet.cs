using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultCombatPuppet : UniversalData, ICombatObject//Implemented object for a combat scene
{
    public RadarInfo PercivedRadarInfo;
    public float Initiative = 0;
    public ParticleSystem OnDeathEffect;

    public void Start()
    {

    }

    public void UpdatePosition()
    {
        
    }

    public void ProcessEquipmentEffect(Equipment equipment)
    {
        
    }

    public ICombatObject ImplementUniversalData(UniversalData universalData)
    {
        DefaultCombatPuppet puppet = ScriptableObject.CreateInstance<DefaultCombatPuppet>();
        puppet.Attributes = universalData.Attributes;
        puppet.Stats = universalData.Stats;
        puppet.universalName = universalData.universalName;
        PercivedRadarInfo = new RadarInfo();

        return puppet;
    }

    public void OnDeath()
    {
        OnDeathEffect.Play();
    }
}
