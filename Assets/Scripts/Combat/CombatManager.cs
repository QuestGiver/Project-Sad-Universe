using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CombatManager : MonoBehaviour
{
    public static RadarManager radarManager;
    public static EncounterData encounterData;
    public EncounterBuilder Encounter_Builder;   
    public Button EndTurn;
    public Button Weapon;

    void Start()
    {
        encounterData = Encounter_Builder.BuildRandomEncounter();
        encounterData.ParticipantList.Add(PlayerState.CommanderInfoPassThrough());
        initializeCombat();
    }

    void initializeCombat()
    {
        List<ICombatObject> ships = new List<ICombatObject>();

        foreach (ICommanderInfo commander in encounterData.ParticipantList)
        {
            foreach  (ICombatObject ship in commander.SubmitFleet())
            {
                ship.OwnerID = commander;
            }
            ships.AddRange(commander.SubmitFleet());
        }
    }

    void Update()
    {
        ProcessPlayerShipMovement();
    }

    void ProcessPlayerShipMovement()
    {

    }

    void ProcessAICommands()
    {

    }

    void Actions()
    {
        
    }

    void UpdateRador()
    {

    }

    public void ProcessEquipmentAction(ICombatObject _source, Equipment _equipment)
    {
        _equipment.ActivateEquipment(_source);
    }





}
