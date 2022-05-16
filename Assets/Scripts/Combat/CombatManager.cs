using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//the brain of the encounter which makes sure that combat flows normally
public class CombatManager : MonoBehaviour
{
    public RadarManager radarManager;
    public static EncounterData encounterData;
    public EncounterBuilder Encounter_Builder;
    public static Event commonUpdates;
    

    void Start()
    {
        initializeCombat();
    }

    void initializeCombat()
    {
        List<ICombatObject> ships = new List<ICombatObject>();

        foreach (ICommanderInfo commander in encounterData.ParticipantList)
        {
            ships.AddRange(commander.SubmitFleet());
        }
    }

    void Update()
    {
        //CommandPoints += Time.deltaTime * PlayerShip.Attributes.Affinity;
        //Mathf.Clamp(CommandPoints, 0, 100);
        //CommandBar.value = CommandPoints;

        ProcessPlayerShipMovement(); 
    }

    void ProcessPlayerShipMovement()
    {
        //movement update delegate goes here
        //test code -> radarManager.SetBlipArenaPosition(radarManager.blipArenaPosition + throttle.value * PlayerShip.Stats.maxSpeed);
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

    public void ProcessEquipmentAction(UniversalData _source, Equipment _equipment)
    {
        _equipment.ActivateEquipment();
    }





}
