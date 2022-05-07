using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CombatManager : MonoBehaviour
{
    public static TurnOrder turnOrder =  new TurnOrder();
    public static RadarManager radarManager;
    public static EncounterData encounterData;
    public static CombatPuppetFactory PuppetFactory = new CombatPuppetFactory();
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

        turnOrder.InitializeTurnOrder(ships);

    }

    public void TurnUpdate()
    {
        NextShip();
        if (turnOrder.CurrentTurnHolder.OwnerID.PlayerRelationship != EncounterAIState.PLAYER)
        {
            ProcessAICommands();
        }
    }

    void NextShip()
    {
        turnOrder.EndTurn();
        turnOrder.StartTurn();
    }

    void ProcessAICommands()
    {
        NextShip();
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
