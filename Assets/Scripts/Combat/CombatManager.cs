using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CombatManager : MonoBehaviour
{
    public static TurnOrder turnOrder;
    public static RadarManager radarManager;
    public static EncounterData encounterData;
    public static List<ICombatObject> ships = new List<ICombatObject>();

    void Start()
    {
        BuildEncounter();
        
    }

    public void BuildEncounter()
    {
        encounterData = EncounterBuilder.BuildRandomEncounter();
    }

    public void TurnUpdate()
    {

    }

    void NextShip()
    {

    }

    void Actions()
    {

    }

    void UpdateRador()
    {

    }

    public void ProcessEquipmentAction(CombatPuppet _target, CombatPuppet _source, Equipment _equipment)
    {
        _equipment.ActivateEquipment(_target, _source);
    }

    void initializeShips()
    {
        foreach (EncounterAI ai in CombatManager.encounterData.AIList)
        {
            ships.AddRange(ai.SubmitFleet());
        }
    }





}
